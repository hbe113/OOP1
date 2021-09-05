using HomeworkFiveForFifthDay.Abstract;
using HomeworkFiveForFifthDay.Entities;
using HomeworkFiveForFifthDay.Concrete;
using System;

namespace HomeworkFiveForFifthDay
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();
            CampaignManager campaignmanager = new CampaignManager();
            GamerManager gamerManager = new GamerManager();

            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "Hidayet";
            gamer1.LastName = "ERDOĞAN";
            gamer1.Birthday = new DateTime(2000,01,01);
            gamer1.TcNo = "12345678901";

            Gamer gamer2 = new Gamer {
            Id=2,
            FirstName="Büşra",
            LastName="ERDOĞAN",
            Birthday= new DateTime(2000,02,13),
            TcNo="01234567890"};

            Gamer gamer3 = new Gamer
            {
                Id = 3,
                FirstName = "Eda",
                LastName = "YILDIRIM",
                Birthday = new DateTime(2004, 05, 20),
                TcNo = "78945612309"
            };

            Gamer gamer4 = new Gamer
            {
                Id = 4,
                FirstName = "Berkay",
                LastName = "ERDOĞAN",
                Birthday = new DateTime(2005, 10, 19),
                TcNo = "45678912303"
            };

            Game game1 = new Game {
            Id=1,
            GameName="Pes 2021",
            GameCategory="Spor Oyunları",
            GamePrice=65};

            Game game2 = new Game
            {
                Id = 2,
                GameName = "Counter Strike GO",
                GameCategory = "Savaş Oyunları",
                GamePrice = 50
            };

            Game game3 = new Game
            {
                Id = 3,
                GameName = "F1",
                GameCategory = "Yarış Oyunları",
                GamePrice = 130
            };

            Campaign campaign1 = new Campaign {
                Id = 1,
            CampaignName="Yeni Kayıt Kampanyası",
            CampaignDiscount=25};

            Campaign campaign2 = new Campaign
            {
                Id = 2,
                CampaignName = "Yılbaşı Kampanyası",
                CampaignDiscount = 30
            };

            Campaign campaign3 = new Campaign
            {
                Id = 3,
                CampaignName = "Sezon Sonu Kampanyası",
                CampaignDiscount = 15
            };

            gamerManager.Add(gamer1);
            Console.WriteLine("--------------------------------");
            gamerManager.Add(gamer2);
            Console.WriteLine("--------------------------------");
            gamerManager.Delete(gamer3);
            Console.WriteLine("--------------------------------");
            gamerManager.Update(gamer4);
            Console.WriteLine("--------------------------------");
            gameManager.Add(game1);
            Console.WriteLine("--------------------------------");
            gameManager.Delete(game2);
            Console.WriteLine("--------------------------------");
            gameManager.Update(game3);
            Console.WriteLine("--------------------------------");
            campaignmanager.Add(campaign1);
            Console.WriteLine("--------------------------------");
            campaignmanager.Update(campaign2);
            Console.WriteLine("--------------------------------");
            campaignmanager.Delete(campaign3);
            

            SaleManager saleManager1 = new SaleManager();
            Console.WriteLine("--------------------------------");
            saleManager1.Sale(game1, gamer1, campaign1);

            SaleManager saleManager2 = new SaleManager();
            Console.WriteLine("--------------------------------");
            saleManager1.Sale(game2, gamer2, campaign2);

            SaleManager saleManager3 = new SaleManager();
            Console.WriteLine("--------------------------------");
            saleManager1.Sale(game3, gamer4, campaign3);

        }
    }
}
