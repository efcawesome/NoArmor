using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace NoArmor
{
    class NoGlobalItem : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            if(item.defense > 0)
            {
                item.defense = 0;
            }
        }
        public override bool CanEquipAccessory(Item item, Player player, int slot)
        {
            if(item.wornArmor == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
