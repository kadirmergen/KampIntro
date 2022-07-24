using System;
using System.Collections.Generic;
using System.Text;

namespace Demo5
{
    internal class GamerService : IGamerManager
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" "+ gamer.LastName+" "+"named gamer added!");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + "named gamer deleted!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + "named gamer updated!");
        }
    }
}
