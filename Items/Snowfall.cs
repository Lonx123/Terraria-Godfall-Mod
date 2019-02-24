using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Godfall.Items
{
	public class Snowfall : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Snowfall");
			Tooltip.SetDefault("Do you hear the sleigh bells ringing?");
		}
		public override void SetDefaults()
		{
			item.damage = 15;
			item.melee = true;
			item.ranged=true;
			item.width = 60;
			item.height = 70;
			item.useTime = 40;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 15;
			item.rare = 2;
			item.shoot = 344; 
			item.shootSpeed = 50f;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 50);
			recipe.AddIngredient(ItemID.SnowBlock, 50);
			
			recipe.AddIngredient(ItemID.IceBlock, 50);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}