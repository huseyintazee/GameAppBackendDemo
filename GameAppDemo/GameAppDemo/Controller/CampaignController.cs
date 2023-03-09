using GameAppDemo.Entity;
using GameAppDemo.Services;

namespace GameAppDemo.Controller;

public class CampaignController : ICampaignService
{
    public void Add(Campaign campaign)
    {
        Console.WriteLine("Added campaign : " + campaign.Name);
    }

    public void Delete(Campaign campaign)
    {
        Console.WriteLine("Deleted campaign : " + campaign.Name);
    }

    public void Update(Campaign campaign)
    {
        Console.WriteLine("Updated campaign : " + campaign.Name);
    }

    public void GameSellWithCampaign(Campaign campaign, Game game, Player player)
    {
        var markDown = Math.Round(game.Price * (campaign.DiscountRate / 100m), 2, MidpointRounding.ToEven);
        var discountedPrice = game.Price - markDown;
        Console.WriteLine("The game named "
                          + game.Name + " was sold to "
                          + player.FirstName + " "
                          + player.LastName + " for "
                          + discountedPrice + "$"
                          + " with a " +
                          campaign.Name);
    }
}