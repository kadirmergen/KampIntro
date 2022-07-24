using System;

namespace Demo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            gamer.FirstName = "Kadir";
            gamer.LastName = "Mergen";


            IGamerManager gamerManager = new GamerService();
            gamerManager.Add(gamer);

            Game game = new Game();
            game.GameId = 1;
            game.GameName = "God Of War";
            game.GamePrice = 450;

            Game game2 = new Game();
            game2.GameId = 2;
            game2.GameName = "Ghost Of Tshushima";
            game2.GamePrice = 500;

            IGameManager gameManager = new GameService();
            gameManager.Add(game);
            gameManager.Add(game2);

            Campaign campaign = new Campaign();
            campaign.CampaignId = 1;
            campaign.CampaignName = "Summer Bonus";
            campaign.Discount = 30;

            Campaign campaign2 = new Campaign();
            campaign2.CampaignId = 2;
            campaign2.CampaignName = "Winter Bonus";
            campaign2.Discount = 50;

            Campaign campaign3 = new Campaign();
            campaign3.CampaignId = 3;
            campaign3.CampaignName = "Yemeksepeti Bonus";
            campaign3.Discount = 25;

            Console.WriteLine("----------------------------------------------");

            ICampaignManager campaignManager = new CampaignService();
            campaignManager.Add(campaign);
            campaignManager.Add(campaign2);
            campaignManager.Add(campaign3);
            Console.WriteLine("-----------------------------------------------");

            gameManager.ListOfGame();
            Console.WriteLine("-----");            
            campaignManager.ListOfCampaign();


            int number1;
            Console.WriteLine("Choose a game: ");
            number1= Convert.ToInt32(Console.ReadLine());

            int number2;
            Console.WriteLine("Choose a campaign: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            int NewPrice;

            if (number1==game.GameId && number2==campaign.CampaignId)
            {
                NewPrice = game.GamePrice - campaign.Discount;
                Console.WriteLine("Original price of God of war: "+game.GamePrice+"\nAmount of discount that you choose: "+campaign.Discount+"\nThe new price after the discount: "+NewPrice);
            }
            if (number1==game.GameId && number2==campaign2.CampaignId)
            {
                NewPrice = game.GamePrice - campaign2.Discount;
                Console.WriteLine("Original price of God of war: " + game.GamePrice + "\nAmount of discount that you choose: " + campaign2.Discount + "\nThe new price after the discount: " + NewPrice);
            }
            if (number1==game.GameId && number2==campaign3.CampaignId)
            {
                NewPrice = game.GamePrice - campaign3.Discount;
                Console.WriteLine("Original price of God of war: " + game.GamePrice + "\nAmount of discount that you choose: " + campaign3.Discount + "\nThe new price after the discount: " + NewPrice);
            }
            if (number1==game2.GameId && number2==campaign.CampaignId)
            {
                NewPrice = game2.GamePrice - campaign.Discount;
                Console.WriteLine("Original price of God of war: " + game2.GamePrice + "\nAmount of discount that you choose: " + campaign.Discount + "\nThe new price after the discount: " + NewPrice);
            }
            if (number1 == game2.GameId && number2 == campaign2.CampaignId)
            {
                NewPrice = game2.GamePrice - campaign2.Discount;
                Console.WriteLine("Original price of God of war: " + game2.GamePrice + "\nAmount of discount that you choose: " + campaign2.Discount + "\nThe new price after the discount: " + NewPrice);
            }
            if (number1 == game2.GameId && number2 == campaign3.CampaignId)
            {
                NewPrice = game2.GamePrice - campaign3.Discount;
                Console.WriteLine("Original price of God of war: " + game2.GamePrice + "\nAmount of discount that you choose: " + campaign3.Discount + "\nThe new price after the discount: " + NewPrice);
            }


        }
    }
}
