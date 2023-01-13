using Domain.Models;
using GTANetworkAPI;
using RAGE;

namespace Server.ServerEventHandlers
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
