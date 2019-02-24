using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Godfall.Items
{
	public class ZeusBolt : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Zeus's Bolt");
			Tooltip.SetDefault("Stay out of the sky");
		}
		public override void SetDefaults()
		{
			item.damage = 20;
			item.melee = true;
			item.ranged=true;
			item.width = 60;
			item.height = 70;
			item.useTime = 30;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 100000005;
			item.rare = 7;
			item.shoot = 238; 
			item.shootSpeed = 5f;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Starfury, 1);
			recipe.AddIngredient(ItemID.NimbusRod, 1);
			
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}