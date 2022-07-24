using System;
using System.Collections.Generic;
using System.Text;

namespace Demo5
{
    internal interface IGameManager
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
        void ListOfGame();
    }
}
