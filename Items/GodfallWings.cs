using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Godfall.Items
{
    [AutoloadEquip(EquipType.Wings)]
    public class GodfallWings : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Godfall Wings");
			Tooltip.SetDefault("Back to where you came from!");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 22;
            item.value = 10000;
            item.rare = 4;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.wingTimeMax = 125;
        }

        public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising, ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
        {
            ascentWhenFalling = 0.9f;
            ascentWhenRising = 0.1f;
            maxCanAscendMultiplier = 1.2f;
            maxAscentMultiplier = 3.5f;
            constantAscend = 0.125f;
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofFlight, 20);
			recipe.AddIngredient(null, "GodfallBar", 25);
			
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
        public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
        {
            speed = 10f;
            acceleration *= 2.75f;
        }

    }
}