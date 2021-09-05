using HomeworkFiveForFifthDay.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkFiveForFifthDay.Concrete
{
    class Game : IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string GameCategory { get; set; }
        public double GamePrice { get; set; }

    }
}
