﻿using GTANetworkAPI;

namespace Domain.Models
{
    public class PlayerModel : Player
    {
        public int AccountId { get; set; }

        public PlayerModel(NetHandle netHandle) : base(netHandle)
        {
        }
    }


}