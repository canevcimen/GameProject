using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ISalesService
    {
        void Sales(Gamer gamer, Game game);
        void CampaignSales(Game game, Gamer gamer, Campaign campaign);
    }
}
