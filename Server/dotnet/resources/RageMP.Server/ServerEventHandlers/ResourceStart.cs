using GTANetworkAPI;
using RAGE;
using RageMP.Domain.Models;

namespace RageMP.Server.ServerEventHandlers
{
    public class ResourceStart : Script
    {
        [ServerEvent(Event.ResourceStart)]
        public void OnResourceStart()
        {
            Entities.Players.CreateEntity = netHandle => new PlayerModel(netHandle);
            ServicesContainer.Init();
        }
    }
}
