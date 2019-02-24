using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Godfall.Items
{
	public class PumpkingStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pumpking Staff");
			Tooltip.SetDefault("If you press it up to your ear, you can hear crows!");
		}
		public override void SetDefaults()
		{
			item.damage = 45;
			item.melee = true;
			item.ranged=true;
			item.width = 60;
			item.height = 70;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 100000005;
			item.rare = 5;
			item.shoot = 312; 
			item.shootSpeed = 15f;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.mana = 20;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WaterBolt, 1);
			recipe.AddIngredient(ItemID.RazorbladeTyphoon, 1);
		
			
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}