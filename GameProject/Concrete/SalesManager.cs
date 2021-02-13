using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class SalesManager : ISalesService
    {
        public void CampaignSales(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " "  + campaign.CampaingName + " "  + "ile" + " " + game.GameName + " "  + "oyunu aldı.");
        }

        public void Sales(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName+" " + game.GameName + " " + "satın aldı.");
        }
    }
}
