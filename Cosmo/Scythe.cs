using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Godfall.Cosmo
{
	public class Scythe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cosmic Scythe");
			Tooltip.SetDefault("Out of this world death!");
		}
		public override void SetDefaults()
		{
			item.damage = 85;
			item.melee = true;
			item.ranged=true;
			item.width = 60;
			item.height = 70;
			item.useTime = 5;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 50000;
			item.rare = 9;
			item.shoot = 585; 
			item.shootSpeed = 10f;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
	}
}