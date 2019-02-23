using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Godfall.Cosmo
{
    public class Astrofly : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cosmic Fly");
        }

        public override void SetDefaults()
        {
            npc.width = 18;
            npc.height = 24;
            npc.damage = 100;
            npc.defense = 5;
            npc.lifeMax = 850;
            npc.HitSound = SoundID.NPCHit2;
            npc.DeathSound = SoundID.NPCDeath2;
            npc.value = 150f;
            npc.knockBackResist = 0.25f;
            npc.aiStyle = 2;
            Main.npcFrameCount[npc.type] = 6; //Main.npcFrameCount[2];
            aiType = NPCID.QueenBee; // aiType = 2;
            animationType = NPCID.DemonEye; // animationType = 2;aa
        }


        public override void NPCLoot()
        {
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GodfallOre"), Main.rand.Next(1, 1));
        }
    }
}