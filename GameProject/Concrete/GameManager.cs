using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Game Added");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Game Deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Game Updated");
        }
    }
}
