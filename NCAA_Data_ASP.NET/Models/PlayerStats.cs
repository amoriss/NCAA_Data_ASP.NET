using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;

namespace NCAA_Data
{
    public class PlayerStats
    {
        public static async Task<List<PlayerStatistics>> GetPlayerStats(int year, string conference, string season, string statCat)
        {
            string key = File.ReadAllText("appsettings.json");  //reads the content (our API Key) from the "appsettings.json file; storing into the variable key
            string bearerToken = JObject.Parse(key).GetValue("APIKey").ToString();
            double rushingYards = 0;

            string footballEndpoint = $"https://api.collegefootballdata.com/stats/player/" +    //making the API call
            $"season?year={year}&conference={conference}&seasonType={season}&category={statCat}";
            //Create a list to store player statistics
            List<PlayerStatistics> playerStatsList = new List<PlayerStatistics>();

            // Create an HttpClient instance
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    // Set the Bearer token in the Authorization header
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);

                    // Make the API call (GET request in this example)
                    HttpResponseMessage response = await httpClient.GetAsync(footballEndpoint);

                    // Check if the response is successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Read the response content as a string
                        string responseBody = await response.Content.ReadAsStringAsync();
                        JArray responseArray = JArray.Parse(responseBody);

                        foreach (JObject playerStats in responseArray)
                        {
                            // Create a new PlayerStatistics object and fill its properties with data from the JSON.
                            PlayerStatistics playerStatistics = new PlayerStatistics
                            {
                                PlayerId = (string)playerStats["playerId"],
                                PlayerName = (string)playerStats["player"],
                                Team = (string)playerStats["team"],
                                Conference = (string)playerStats["conference"],
                                Category = (string)playerStats["category"],
                                StatType = (string)playerStats["statType"],
                                Stat = (string)playerStats["stat"]
                            };
                            // Add the player statistics to the list.
                            playerStatsList.Add(playerStatistics);
                        }
                    }
                   
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            return playerStatsList;
        }
    }
}