using GameAppDemo.Entity;

namespace GameAppDemo.Services;

public interface ICampaignService
{
    void Add(Campaign campaign);
    void Delete(Campaign campaign);
    void Update(Campaign campaign);
    void GameSellWithCampaign(Campaign campaign, Game game, Player player);
}