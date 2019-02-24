using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Godfall.Endgame
{
	public class Holy : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Holy Warblade");
			Tooltip.SetDefault("You hear opera music in the background");
		}
		public override void SetDefaults()
		{
			item.damage = 300;
			item.melee = true;
			item.ranged=true;
			item.width = 60;
			item.height = 70;
			item.useTime = 5;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 50000000;
			item.rare = 11;
			item.shoot = 617;
			item.expert = true;
			item.shootSpeed = 10f;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
	}
}