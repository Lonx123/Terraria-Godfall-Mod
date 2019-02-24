using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Godfall.Items
{
	public class Keeper : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Swarm");
			Tooltip.SetDefault("This is a secret item!");
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
			item.rare = 9;
			item.shoot = 183; 
			item.shootSpeed = 15f;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;	
		}
	}
}