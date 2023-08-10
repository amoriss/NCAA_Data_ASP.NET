//using System;
//using System.Reflection;

//namespace NCAA_Data
//{
//    public class OffenseCategories
//    {
//        public async Task ChooseCategory()
//        {
//            Console.WriteLine("Which offensive stat category would you like to focus on: rushing, passing, or receiving?");
//            var offensiveCategory = Console.ReadLine().ToLower();

//            if (offensiveCategory == "rushing")
//            {
//                Rushing rushing = new Rushing();
//                rushing.GetParameters();
//                await rushing.DisplayStatistics();
//            }
//            else if (offensiveCategory == "receiving")
//            {
//                Receiving receiving = new Receiving();
//                receiving.GetParameters();
//                await receiving.DisplayStatistics();
//            }
//            else if (offensiveCategory == "passing")
//            {
//                Passing passing = new Passing();
//                passing.GetParameters();
//                await passing.DisplayStatistics();
//            }
//        }
//    }
//}