using GameAppDemo.Entity;

namespace GameAppDemo.Services;

public interface IPlayerService
{
    void Add(Player player);
    void Delete(Player player);
    void Update(Player player);
    
}