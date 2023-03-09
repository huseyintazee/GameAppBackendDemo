using GameAppDemo.Entity;

namespace GameAppDemo.Services;

public interface IPlayerCheckService
{
    bool CheckIfRealPlayer(Player player);
}