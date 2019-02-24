using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Godfall.NPCs
{
    public class GodfallEye : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Godfall Eye");
        }

        public override void SetDefaults()
        {
            npc.width = 18;
            npc.height = 24;
            npc.damage = 12;
            npc.defense = 5;
            npc.lifeMax = 100;
            npc.HitSound = SoundID.NPCHit2;
            npc.DeathSound = SoundID.NPCDeath2;
            npc.value = 150f;
            npc.knockBackResist = 0.25f;
            npc.aiStyle = 2;
            Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.DemonEye]; //Main.npcFrameCount[2];
            aiType = NPCID.DemonEye; // aiType = 2;
            animationType = NPCID.DemonEye; // animationType = 2;aa
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldNightMonster.Chance * 0.5f;
        }

        public override void NPCLoot()
        {
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GodfallOre"), Main.rand.Next(1, 1));
        }
    }
}