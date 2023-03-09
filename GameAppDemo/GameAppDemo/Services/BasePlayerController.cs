using GameAppDemo.Entity;

namespace GameAppDemo.Services;

public class BasePlayerController : IPlayerService
{
    //SIMULASYON CRUD OPERATIONLAR YAPILIYOR KABUL EDİYORUZ.
    public virtual void Add(Player player)
    {
        Console.WriteLine("Player added : " + player.FirstName + " " + player.LastName);
    }

    public void Delete(Player player)
    {
        Console.WriteLine("Player deleted : " + player.FirstName + " " + player.LastName);
    }

    public void Update(Player player)
    {
        Console.WriteLine("Player updated : " + player.FirstName + " " + player.LastName);
    }
}