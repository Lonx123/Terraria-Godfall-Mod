using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Godfall.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class HellChest : ModItem
	{
		public override void SetDefaults()
		{

			item.width = 38;
			item.height = 22;

			item.value = 18000;
			item.rare = 10;
			item.defense = 35;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hellrise Chestplate");
			Tooltip.SetDefault("45% increased magic damage\n" +
            "Increases your max number of minions");
		}

		public override void UpdateEquip(Player player)
		{
			player.maxMinions += 3;
			player.magicDamage += 0.45f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "HellBar", 25);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
        }
	}
}