using GameAppDemo.Entity;
using GameAppDemo.KPSPublic;
using GameAppDemo.Services;

namespace InterfaceAbstractDemo.Adapters;

public class MernisServiceAdapter : IPlayerCheckService
{
    public bool CheckIfRealPlayer(Player player)
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
        return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(player.NationalityId), player.FirstName.ToUpper(), player.LastName.ToUpper(), player.BirthDay.Year).Result.Body
            .TCKimlikNoDogrulaResult;
    }
}