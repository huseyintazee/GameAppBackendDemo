using GameAppDemo.Entity;

namespace GameAppDemo.Services;

public interface IGameService
{
    void Sell(Game game, Player player);
}