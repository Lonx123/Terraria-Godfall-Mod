using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Godfall.NPCs
{
	public class Tiki : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tiki");
			Main.npcFrameCount[npc.type] = 3;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 120;
			npc.damage = 26;
			npc.defense = 1;
			npc.knockBackResist = 0.3f;
			npc.width = 56;
			npc.height = 48;
			animationType = 3;
			npc.aiStyle = 3;
			aiType = 73;
			npc.npcSlots = 15f;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = Item.buyPrice(0, 0, 0, 0);
		}
		
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
		 return SpawnCondition.OverworldDaySlime.Chance * 0.1f;
		 if(spawnInfo.player.ZoneJungle);
        }
	}
}