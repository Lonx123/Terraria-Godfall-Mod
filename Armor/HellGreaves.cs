using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Godfall.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class HellGreaves : ModItem
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
			DisplayName.SetDefault("Hellrise Greaves");
			Tooltip.SetDefault("45% increased melee damage\n" +
            "Increases your max number of minions");
		}

		public override void UpdateEquip(Player player)
		{
			player.maxMinions += 2;
			player.meleeDamage += 0.45f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "HellBar", 15);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}