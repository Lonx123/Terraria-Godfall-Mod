using Terraria;
using Terraria.ModLoader;

namespace Godfall.Endgame
{
	public class Mag : ModItem
	{

		public override void SetDefaults()
		{

			item.width = 26;
			item.height = 20;
			item.value = 10000000;
			item.rare = 11;
			item.expert = true;

			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nike Air Mags");
			Tooltip.SetDefault("Greatly increased movement speed and increases knockback effect\n" +
"Allows flight, super fast running, and extra mobility on ice");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)

		{
			player.accRunSpeed = 25.75f;
			player.rocketBoots = 3;
			player.moveSpeed += 5.5f;
			player.maxRunSpeed += 25.5f;
			player.kbBuff = true;
			player.iceSkate = true;
		}
	}
}