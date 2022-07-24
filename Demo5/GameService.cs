using System;
using System.Collections.Generic;
using System.Text;

namespace Demo5
{
    internal class GameService : IGameManager
    {
        List<Game> games= new List<Game>();
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName+" "+" Added as "+game.GameId);
            games.Add(game);
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameId+" "+game.GameName+" has been deleted! ");
            games.Remove(game);
        }

        public void ListOfGame()
        {
            Console.WriteLine("The Games: ");
            foreach (Game game in games)
            {
                
                Console.WriteLine(game.GameId+" "+game.GameName);
            }
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameId+" "+game.GameName+" has been updated! ");
        }
    }
}
