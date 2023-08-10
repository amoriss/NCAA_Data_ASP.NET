//using System;
//namespace NCAA_Data
//{
//    public class SpecialTeamsCategories
//    {
//        public async Task ChooseCategory()
//        {
//            Console.WriteLine("Which special teams stat category would you like to focus on: kicking, punting, kick returns or punt returns?");
//            var STCategory = Console.ReadLine().ToLower();

//            if (STCategory == "kicking")
//            {
//                Kicking kicking = new Kicking();
//                kicking.GetParameters();
//                await kicking.DisplayStatistics();
//            }
//            else if (STCategory == "punting")
//            {
//                Punting punting = new Punting();
//                punting.GetParameters();
//                await punting.DisplayStatistics();
//            }
//            else if (STCategory == "kick returns")
//            {
//                KickReturns kickReturns = new KickReturns();
//                kickReturns.GetParameters();
//                await kickReturns.DisplayStatistics();
//            }
//            else if (STCategory == "punt returns")
//            {
//                PuntReturns puntReturns = new PuntReturns();
//                puntReturns.GetParameters();
//                await puntReturns.DisplayStatistics();
//            }
//        }
//    }
//}