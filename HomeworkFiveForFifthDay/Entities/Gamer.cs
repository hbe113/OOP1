using HomeworkFiveForFifthDay.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkFiveForFifthDay
{
    class Gamer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcNo { get; set; }
        public DateTime Birthday { get; set; }
    }
}
