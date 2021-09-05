using HomeworkFiveForFifthDay.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkFiveForFifthDay.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName+ " oyunu başarıyla eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " oyunu başarıyla silindi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName+ " oyunu başarıyla güncellendi.");
        }
    }
}
