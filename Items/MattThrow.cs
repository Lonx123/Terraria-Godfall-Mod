using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Godfall.Items
{
	public class MattThrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("MattJ's Throw");
			Tooltip.SetDefault("Hey this is a dev weapon, how did you get this?");
		}
		public override void SetDefaults()
		{
			item.damage = 500;
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
			item.shoot = 15; 
			item.shootSpeed = 30f;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

	}
}