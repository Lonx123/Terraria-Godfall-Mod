using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Godfall.Items
{
	public class Godfall : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Godfall");
			Tooltip.SetDefault("When the creator of all is slain, who assumes control?");
		}
		public override void SetDefaults()
		{
			item.damage = 65;
			item.melee = true;
			item.ranged=true;
			item.width = 60;
			item.height = 70;
			item.useTime = 4;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 100000005;
			item.rare = 2;
			item.shoot = 585; 
			item.shootSpeed = 30f;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.mana = 8;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WaterBolt, 1);
			recipe.AddIngredient(null, "GodfallBar", 10);
			
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}