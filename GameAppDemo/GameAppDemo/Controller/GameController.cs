using GameAppDemo.Entity;
using GameAppDemo.Services;

namespace GameAppDemo.Controller;

public class GameController : IGameService
{
    public void Sell(Game game, Player player)
    {
        Console.WriteLine("The game named " + game.Name + " was sold to " + player.FirstName + " " + player.LastName + " for " + game.Price + "$");
    }
}