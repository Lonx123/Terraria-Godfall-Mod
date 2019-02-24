using Terraria.ID;
using Terraria.ModLoader;

namespace Godfall.Endgame
{
	public class Book : ModItem
	{
		public override void SetDefaults()
		{

			item.damage = 850;
			item.melee = false;
			item.magic = true;
			item.width = 50;
			item.height = 55;
			item.useTime = 3;
			item.useAnimation = 12;
			item.mana = 5;
			item.useStyle = 5;
			item.shoot = 469;
			item.shootSpeed = 26f;
			item.knockBack = 4;
			item.value = 50000000;
			item.rare = 11;
			item.expert= true;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bee Kind");
			Tooltip.SetDefault("Don't mess with the Hive...");
		}

	}
}