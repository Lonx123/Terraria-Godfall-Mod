using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Godfall.Items
{
	public class SightsEdge : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sight's Edge");
			Tooltip.SetDefault("I can see EVERYTHING!");
		}
		public override void SetDefaults()
		{
			item.damage = 50;
			item.melee = true;
			item.ranged=true;
			item.width = 60;
			item.height = 70;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 100000005;
			item.rare = 5;
			item.shoot = 283; 
			item.shootSpeed = 10f;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
	}
}