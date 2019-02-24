using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace Godfall.Items
{
    public class Spirit : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lost Spirit");
            Tooltip.SetDefault("Summons the ancient spirits...");
        }

        public override void SetDefaults()
        {
            item.width = 20;
			item.value = Item.buyPrice(gold: 5);
            item.height = 20;
            item.maxStack = 20;
            item.value = 100000;
            item.rare = 1;
			item.value = 500000;
            item.useAnimation = 40;
            item.useTime = 45;
            item.consumable = true;

            item.useStyle = 4; // Holds up like a summon item.
        }

        public override bool CanUseItem(Player player)
        {
            // Main Bosses
            bool queenBee = NPC.downedQueenBee; // Downed Queen Bee

            bool bossOne = NPC.downedBoss1; // Downed EoC
            bool bossTwo = NPC.downedBoss2; // Downed EoW or BoC
            bool bossThree = NPC.downedBoss3; // Downed Skeletron

            bool isHardmode = Main.hardMode; // Downed WoF

            bool mechOne = NPC.downedMechBoss1; // Downed The Twins
            bool mechTwo = NPC.downedMechBoss2; // Downed The Destroyer
            bool mechThree = NPC.downedMechBoss3; // Downed Skeletron Prim

            bool plantera = NPC.downedPlantBoss; // Downed Plantera
            bool golem = NPC.downedGolemBoss; // Downed Golem;
            bool cultist = NPC.downedAncientCultist; // Downed Cultist
            bool moonLord = NPC.downedMoonlord; // Downed MoonLord

            // Does NPC Exist
            bool alreadySpawned = NPC.AnyNPCs(mod.NPCType("ZeusWatcher"));

            // return NPC.downedQueenBee && Main.hardMode && !NPC.AnyNPCs(mod.NPCType("TutorialBoss")); // NPC will spawn if No existing Tutorial Boss, Queen Bee is downed and it is hardmode 
            return !alreadySpawned;
        }

        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("Light")); // Spawn the boss within a range of the player. 
            Main.PlaySound(SoundID.Roar, player.position, 0); 
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("Night")); // Spawn the boss within a range of the player. 
            Main.PlaySound(SoundID.Roar, player.position, 0);
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("Fright")); // Spawn the boss within a range of the player. 
            Main.PlaySound(SoundID.Roar, player.position, 0); 
            return true;
        }

		public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
			r.AddIngredient(ItemID.SoulofNight, 5);
			r.AddIngredient(ItemID.SoulofFright, 5);
			r.AddIngredient(ItemID.SoulofLight, 5);
            r.AddIngredient(null, "GodfallBar", 5);
            r.AddTile(TileID.WorkBenches);
            r.SetResult(this);
            r.AddRecipe();
        }

    }
}