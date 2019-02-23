using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace Godfall.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class DevMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("MattJ's Mask");
            Tooltip.SetDefault("Did you... Inventory Edit?!");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 1000;
            item.rare = 10;
        }

        
    }
}