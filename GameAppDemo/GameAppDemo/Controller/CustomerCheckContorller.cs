using GameAppDemo.Entity;
using GameAppDemo.KPSPublic;
using GameAppDemo.Services;

namespace GameAppDemo.Controller;

public class CustomerCheckManager : IPlayerCheckService
{
    public bool CheckIfRealPlayer(Player player)
    {
        return true;
    }
}