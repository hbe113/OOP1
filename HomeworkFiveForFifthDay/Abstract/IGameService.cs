using HomeworkFiveForFifthDay.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkFiveForFifthDay.Abstract
{
    interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
    }
}
