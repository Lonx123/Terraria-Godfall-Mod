using Terraria;
using Terraria.ModLoader;

namespace Godfall.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class HellMask : ModItem
	{

		public override void SetDefaults()
		{

			item.width = 32;
			item.height = 26;

			item.value = 400;
			item.rare = 10;
			item.defense = 25;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hellrise Helmet");
			Tooltip.SetDefault("50% increased melee speed");
		}

		public override void UpdateEquip(Player player)
		{
			player.meleeSpeed += 0.50f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("HellChest") && legs.type == mod.ItemType("HellGreaves");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Doubles your melee speed!";
			player.meleeSpeed += 2.00f;
		}

		public override void ArmorSetShadows(Player player)
		{
			player.armorEffectDrawOutlines = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "HellBar", 16);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}