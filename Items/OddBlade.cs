using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Godfall.Items
{
	public class OddBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Odd Looking Sword");
			Tooltip.SetDefault("BACKSLASH!");
		}
		public override void SetDefaults()
		{
			item.damage = 100;
			item.melee = true;
			item.ranged=true;
			item.width = 60;
			item.height = 70;
			item.useTime = 35;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 100000005;
			item.rare = 5;
			item.shoot = 684; 
			item.shootSpeed = 15f;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TrueExcalibur, 1);
			recipe.AddIngredient(ItemID.TrueNightsEdge, 1);
		
			
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}