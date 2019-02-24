using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Godfall.NPCs
{
    public class GodfallZombie : ModNPC // ModNPC is used for Custom NPCs
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Godfall Zombie");
        }

        public override void SetDefaults()
        {
            /* Removed as of 0.10
            //npc.name = "Tutorial Zombie";
            //npc.displayName = "Tutorial Zombie";
            */
            npc.width = 18;
            npc.height = 40;
            npc.damage = 12;
            npc.defense = 5;
            npc.lifeMax = 300;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 100f;
            npc.knockBackResist = 0.75f;
            npc.aiStyle = 3;
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie]; //Main.npcFrameCount[3];
            aiType = NPCID.Zombie; // aiType = 3;
            animationType = NPCID.Zombie; // animationType = 3;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldNightMonster.Chance * 0.5f;
        }

		public override void NPCLoot()
        {
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GodfallOre"), Main.rand.Next(1, 2));
        }

    }
}