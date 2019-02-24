using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Godfall.Items
{
	public class EdgeofSpace : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Edge of Space");
			Tooltip.SetDefault("You ever wonder, what's truly out there?");
		}
		public override void SetDefaults()
		{
			item.damage = 150;
			item.melee = true;
			item.ranged=true;
			item.width = 60;
			item.height = 70;
			item.useTime = 4;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 100000005;
			item.rare = 10;
			item.shoot = 294; 
			item.shootSpeed = 30f;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
		
			recipe.AddIngredient(ItemID.ShadowbeamStaff, 1);
			recipe.AddIngredient(ItemID.TrueNightsEdge, 1);
			recipe.AddIngredient(ItemID.TrueExcalibur, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}