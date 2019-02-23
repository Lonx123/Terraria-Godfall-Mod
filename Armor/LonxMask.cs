using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace Godfall.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class LonxMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lonx's Mask");
            Tooltip.SetDefault("A gift for a friend...");
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