using System;
using GameAppDemo.Controller;
using GameAppDemo.Entity;
using GameAppDemo.Services;
using InterfaceAbstractDemo.Adapters;

namespace GameAppDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //MernisServiceAdapter ile kullanıldıgında doğru bilgiler girilip Add fonkisyonu cagrıldıgında eklme işlemi simulasyonu calışır.
            //BasePlayerController basePlayerController = new PlayerController(new MernisServiceAdapter());
            BasePlayerController basePlayerController = new PlayerController(new CustomerCheckManager());
            basePlayerController.Add(new Player
            {
                Id = 1,
                BirthDay = new DateTime(2001, 1, 24),
                FirstName = "Hüseyin",
                LastName = "Taze",
                NationalityId = "12345678901"
            });
            Player player = new Player
            {
                Id = 1,
                BirthDay = new DateTime(2001, 1, 24),
                FirstName = "Hüseyin",
                LastName = "Taze",
                NationalityId = "12345678901"
            };
            basePlayerController.Delete(player);
            basePlayerController.Update(player);
            Game game = new Game {Id = 1, Name = "God Of War", Price = 360};
            Campaign campaign = new Campaign {Id = 1, Name = "Spring Campaign", DiscountRate = 20};
            GameController gameController = new GameController();
            gameController.Sell(game, player);
            CampaignController campaignController = new CampaignController();
            campaignController.Add(campaign);
            campaignController.Delete(campaign);
            campaignController.Update(campaign);
            campaignController.GameSellWithCampaign(campaign,game,player);
        }
    }
}