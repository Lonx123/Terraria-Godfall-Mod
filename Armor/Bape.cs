using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;

namespace Godfall.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class Bape : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bape Mask");
            Tooltip.SetDefault("Ape shall never kill Ape");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 1000;
            item.rare = 9;
        }

        
    }
}