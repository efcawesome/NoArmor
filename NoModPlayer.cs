using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace NoArmor
{
    class NoModPlayer : ModPlayer
    {
        public override void UpdateEquips(ref bool wallSpeedBuff, ref bool tileSpeedBuff, ref bool tileRangeBuff)
        {
            if(player.statDefense > 0)
            {
                player.statDefense = 0; 
            }
            player.head = -1;
            player.body = -1;
            player.legs = -1;
        }
        public override void PreUpdate()
        {
            for (int i = 0; i < 3; i++)
            {
                if (player.armor[i].type > ItemID.None)
                {
                    player.QuickSpawnClonedItem(player.armor[i]);
                    player.armor[i].TurnToAir();
                    player.head = -1;
                    player.body = -1;
                    player.legs = -1;
                }
            }
        }
    }
}
