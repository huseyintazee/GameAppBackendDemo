using GameAppDemo.Entity;
using GameAppDemo.Services;

namespace GameAppDemo.Controller;

public class PlayerController : BasePlayerController
{
    private IPlayerCheckService _playerCheckService;

    public PlayerController(IPlayerCheckService playerCheckService)
    {
        _playerCheckService = playerCheckService;
    }

    public override void Add(Player player)
    {
        if (_playerCheckService.CheckIfRealPlayer(player))
            base.Add(player);
        else
        {
            throw new Exception("Failed to verify player information");
        }
    }
}