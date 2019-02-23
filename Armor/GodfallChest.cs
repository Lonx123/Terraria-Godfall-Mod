using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Godfall.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class GodfallChest : ModItem
	{
		public override void SetDefaults()
		{

			item.width = 38;
			item.height = 22;

			item.value = 18000;
			item.rare = 10;
			item.defense = 30;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Godfall Chestplate");
			Tooltip.SetDefault("25% increased minion damage\n" +
"Increases your max number of minions");
		}

		public override void UpdateEquip(Player player)
		{
			player.maxMinions += 3;
			player.minionDamage += 0.25f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "GodfallBar", 25);
			recipe.AddIngredient(ItemID.HallowedPlateMail, 1);
			recipe.AddIngredient(ItemID.SoulofNight, 10);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}

	}
}