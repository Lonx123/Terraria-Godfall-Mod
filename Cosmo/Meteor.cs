using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Godfall.Cosmo
{
	public class Meteor : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cosmic Meteorite");
			Main.npcFrameCount[npc.type] = 3;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 600;
			npc.damage = 130;
			npc.defense = 25;
			npc.knockBackResist = 0.5f;
			npc.width = 20;
			npc.height = 20;
			animationType = 288;
			aiType = 288;
			npc.aiStyle = 56;
			npc.npcSlots = 15f;
			npc.noTileCollide = true;
			npc.noGravity = true;
			npc.HitSound = SoundID.NPCHit3;
			npc.noGravity = true;
			npc.DeathSound = SoundID.NPCDeath5;
			npc.value = Item.buyPrice(0, 0, 4, 9);
		}
    }
}