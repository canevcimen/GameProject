using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            Gamer gamer1 = new Gamer()
            {
                Id = 1,
                FirstName = "Can",
                LastName = "Evcimen",
                IdentityNumber = "123456",
                BirthYear=2001
               
            };
            Gamer gamer2 = new Gamer()
            {
                Id = 2,
                FirstName = "Yahya",
                LastName = "Nehir",
                IdentityNumber = "12344",
                BirthYear = 2000
            };
            gamerManager.Add(gamer1);
            Game game1 = new Game() { GameName = "CS:GO", GameId = 1, GamePrice = 30, Discount = 20 };
            Game game2 = new Game() { GameName = "VALORANT", GameId = 2, GamePrice = 1, Discount = 99 };
            Game game3 = new Game() { GameName = "LOL", GameId = 1, GamePrice = 10, Discount = 70 };

            Campaign campaign1 = new Campaign() { CampaingId = 1, CampaingName = "New Member Campaign", DiscountRate = 20 };
            Campaign campaign2 = new Campaign() { CampaingId = 2, CampaingName = "First purchase campaign", DiscountRate = 15 };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            .
            SalesManager salesManager = new SalesManager();
            salesManager.Sales(gamer1, game2);
            salesManager.CampaignSales(game2, gamer1, campaign2);

        }
    }
}
