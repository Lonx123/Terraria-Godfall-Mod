using Terraria.ID;
using Terraria.ModLoader;

namespace Godfall.Items
{
	public class Hol : ModItem
	{
		public override void SetDefaults()
		{

			item.damage = 50;
			item.melee = false;
			item.magic = true;
			item.width = 50;
			item.height = 55;
			item.useTime = 3;
			item.useAnimation = 12;
			item.mana = 5;
			item.useStyle = 5;
			item.shoot = 335;
			item.shootSpeed = 26f;
			item.knockBack = 4;
			item.value = 1000000;
			item.rare = 10;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Holiday Hellstorm");
			Tooltip.SetDefault("Tis' the season...");
		}

	}
}