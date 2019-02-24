using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

namespace Godfall.NPCs
{
	public class GodfallKnight : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Godfall Knight");
			Main.npcFrameCount[npc.type] = 15;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 100;
			aiType = 77;
			npc.damage = 5;
			npc.defense = 1;
			npc.knockBackResist = 0.05f;
			npc.width = 32;
			npc.height = 50;
			animationType = 21;
			npc.aiStyle = 3;
			npc.npcSlots = 0.5f;
			npc.HitSound = SoundID.NPCHit4;
			npc.DeathSound = SoundID.NPCDeath6;
			npc.value = Item.buyPrice(0, 0, 8, 0);
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			
		}

		public override void NPCLoot()
		{
		 Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GodfallOre"), Main.rand.Next(1, 5));
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			{
			 return SpawnCondition.OverworldDaySlime.Chance * 0.5f;
			}
	}
}