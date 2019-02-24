using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

using Godfall.Items;

namespace Godfall.NPCs
{
	public class MoonMage : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Moon Necromancer");
			Main.npcFrameCount[npc.type] = 3;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 250;
			npc.damage = 65;
			npc.defense = 1;
			npc.knockBackResist = 0.3f;
			npc.width = 42;
			npc.height = 56;
			animationType = 3;
			npc.aiStyle = 3;
			npc.npcSlots = 15f;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = Item.buyPrice(0, 0, 1, 21);
		}
		
	

		public override void AI()
		{
			if (Main.netMode != 1 && Main.rand.Next(1000) == 0)
			{
				NPC.NewNPC((int)npc.position.X - 50, (int)npc.position.Y, NPCID.SmallSkeleton);
				NPC.NewNPC((int)npc.position.X + 50, (int)npc.position.Y, NPCID.SmallSkeleton);
			
				
			}

			if (Main.rand.Next(700) == 0)
				Main.PlaySound(29, (int)npc.position.X, (int)npc.position.Y, Main.rand.Next(41, 44));
		}

		public override void FindFrame(int frameHeight)
		{
			if (npc.frameCounter++ >= 50)
			{
				npc.frame.Y = (npc.frame.Y + frameHeight) % (Main.npcFrameCount[npc.type] * frameHeight);
				npc.frameCounter = 0;
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldNightMonster.Chance * 0.1f;
        }
	}
}