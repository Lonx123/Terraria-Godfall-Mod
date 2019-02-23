using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Godfall.Bosses
{
    [AutoloadBossHead]
	public class ZeusWatcher : ModNPC
	{

	    private Player player;
        private float speed;

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Zeus's Watcher");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 4000;
			npc.damage = 160;
			npc.defense = 5;
			npc.noTileCollide = true;
			npc.knockBackResist = 0.1f;
			npc.width = 70;
			npc.height = 50;
			animationType = 250;
			npc.aiStyle = 49;
			aiType = 250;
			npc.noGravity = true;
			npc.boss = true;
			npc.npcSlots = 0.5f;
			npc.HitSound = SoundID.NPCHit30;
			npc.buffImmune[20] = true;
			npc.buffImmune[24] = true;
			npc.buffImmune[39] = true;
			npc.buffImmune[31] = false;
			npc.DeathSound = SoundID.NPCDeath33;
		}


		   public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.625f * bossLifeScale);
            npc.damage = (int)(npc.damage * 0.6f);
            npc.defense = (int)(npc.defense + numPlayers);
        }

		 private void Move(Vector2 offset)
        {
            speed = 10f; // Sets the max speed of the npc.
            Vector2 moveTo = player.Center; // Gets the point that the npc will be moving to.
            Vector2 move = moveTo - npc.Center;
        }

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				Dust.NewDust(npc.position, npc.width, npc.height, 54, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
				Dust.NewDust(npc.position, npc.width, npc.height, 54, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
				Dust.NewDust(npc.position, npc.width, npc.height, 54, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
				Dust.NewDust(npc.position, npc.width, npc.height, 54, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);

				Gore.NewGore(npc.position, npc.velocity, 99, 1f);
				Gore.NewGore(npc.position, npc.velocity, 99, 2f);
				Gore.NewGore(npc.position, npc.velocity, 99, 1f);
				Gore.NewGore(npc.position, npc.velocity, 99, 2f);
				Gore.NewGore(npc.position, npc.velocity, 99, 1f);
				Gore.NewGore(npc.position, npc.velocity, 99, 3f);

				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 76, 0f, 0f, 200, npc.color, 1f);
			}
		}

		public override void AI()
		{
			if (Main.netMode != 1 && Main.rand.Next(1000) == 0)
			{
				NPC.NewNPC((int)npc.position.X - 50, (int)npc.position.Y, NPCID.AngryNimbus);
				NPC.NewNPC((int)npc.position.X + 50, (int)npc.position.Y, NPCID.AngryNimbus);
			}

			if (Main.rand.Next(700) == 0)
				Main.PlaySound(29, (int)npc.position.X, (int)npc.position.Y, Main.rand.Next(41, 44));
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			{
			 return SpawnCondition.OverworldDaySlime.Chance * 0.0001f;
			}
		
		public override void NPCLoot()
        {
            Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("GodfallBar"), Main.rand.Next(4, 5));
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("ZeusBolt"), Main.rand.Next(1, 1));
        }
	}
}