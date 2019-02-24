using Terraria.ID;
using Terraria.ModLoader;

namespace Godfall.Items
{
	public class Grave : ModItem
	{
		public override void SetDefaults()
		{

			item.damage = 200;
			item.melee = false;
			item.magic = true;
			item.width = 50;
			item.height = 55;
			item.useTime = 5;
			item.useAnimation = 12;
			item.mana = 3;
			item.useStyle = 5;
			item.shoot = 424;
			item.shootSpeed = 26f;
			item.knockBack = 4;
			item.value = 100000;
			item.rare = 10;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Satanic Tomb");
			Tooltip.SetDefault("The most unholy thing to set foot on our Earth");
		}

	}
}