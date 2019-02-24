using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Godfall.Items
{
	public class BioBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bio Blade");
			Tooltip.SetDefault("*SNIFF* It smells rancid!");
		}
		public override void SetDefaults()
		{
			item.damage = 30;
			item.melee = true;
			item.ranged=true;
			item.width = 60;
			item.height = 70;
			item.useTime = 30;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 50000;
			item.rare = 2;
			item.shoot = 228; 
			item.shootSpeed = 10f;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Sunflower, 20);
			
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}