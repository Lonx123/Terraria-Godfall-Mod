using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Godfall.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class GodfallHelmet : ModItem
	{


		public override void SetDefaults()
		{

			item.width = 38;
			item.height = 22;

			item.value = 18000;
			item.rare = 10;
			item.defense = 15;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Godfall Helmet");
			Tooltip.SetDefault("25% increased ranged damage\n" +
"Increases your max number of minions");
		}
		

		public override void UpdateEquip(Player player)
		{
			player.rangedDamage += 0.25f;
			player.maxMinions += 2;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("GodfallChest") && legs.type == mod.ItemType("GodfallGreaves");
		}

		public override void UpdateArmorSet(Player player)
		{
		player.setBonus = "Increases maximum health by 50";
		player.statLifeMax2 += 50;
		
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "GodfallBar", 30);
			recipe.AddIngredient(ItemID.SoulofNight, 15);
			recipe.AddIngredient(ItemID.HallowedMask, 1);
			
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}

	}
}