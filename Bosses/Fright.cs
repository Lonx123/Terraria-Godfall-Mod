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
    public class Fright : ModNPC
    {
        private Player player;
        private float speed;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spirit of Fright");
            Main.npcFrameCount[npc.type] = 3;
        }

        public override void SetDefaults()
        {
            npc.aiStyle = -1; // Will not have any AI from any existing AI styles. 
            npc.lifeMax = 15000; // The Max HP the boss has on Normal
            npc.damage = 58; // The base damage value the boss has on Normal
            npc.defense = 25; // The base defense on Normal
            npc.knockBackResist = 0f; // No knockback
            npc.width = 100;
            npc.height = 100;
			aiType = 24;
            npc.value = 10000;
            npc.npcSlots = 1f; // The higher the number, the more NPC slots this NPC takes.
            npc.boss = true; // Is a boss
            npc.lavaImmune = true; // Not hurt by lava
			npc.noTileCollide = false; // Will not collide with the tiles. 
            npc.noGravity = false; // Not affected by gravity
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            music = MusicID.Boss3;
        }

        public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
        {
            npc.lifeMax = (int)(npc.lifeMax * 0.625f * bossLifeScale);
            npc.damage = (int)(npc.damage * 0.6f);
            npc.defense = (int)(npc.defense + numPlayers);
        }

		

        private void Target()
        {
            player = Main.player[npc.target]; // This will get the player target.
        }

        private void Move(Vector2 offset)
        {
            speed = 5f; // Sets the max speed of the npc.
            Vector2 moveTo = player.Center + offset; // Gets the point that the npc will be moving to.
            Vector2 move = moveTo - npc.Center;
            float magnitude = Magnitude(move);
            if(magnitude > speed)
            {
                move *= speed / magnitude; 
            }
            float turnResistance = 1f; // The larget the number the slower the npc will turn.
            move = (npc.velocity * turnResistance + move) / (turnResistance + 1f);
            magnitude = Magnitude(move);
            if(magnitude > speed)
            {
                move *= speed / magnitude;
            }
            npc.velocity = move;
        }

        private void DespawnHandler()
        {
            if(!player.active || player.dead)
            {
                npc.TargetClosest(false);
                player = Main.player[npc.target];
                if(!player.active || player.dead)
                {
                    npc.velocity = new Vector2(0f, -10f);
                    if(npc.timeLeft > 10)
                    {
                        npc.timeLeft = 10;
                    }
                    return;
                }
            }
        }


        private float Magnitude(Vector2 mag)
        {
            return (float)Math.Sqrt(mag.X * mag.X + mag.Y * mag.Y);
        }

        
        public override void FindFrame(int frameHeight)
        {
            npc.frameCounter += 1;
            npc.frameCounter %= 20;
            int frame = (int)(npc.frameCounter / 2.0);
            if (frame >= Main.npcFrameCount[npc.type]) frame = 0;
            npc.frame.Y = frame * frameHeight;

            RotateNPCToTarget();
        }

        private void RotateNPCToTarget()
        {
            if (player == null) return;
            Vector2 direction = npc.Center - player.Center;
            float rotation = (float)Math.Atan2(direction.Y, direction.X);
            npc.rotation = rotation + ((float)Math.PI * 0.5f);
        }
		
		
		public override void AI()
		{
			if (Main.netMode != 1 && Main.rand.Next(50) == 0)
			{
				NPC.NewNPC((int)npc.position.X - 50, (int)npc.position.Y, NPCID.ShadowFlameApparition);
				NPC.NewNPC((int)npc.position.X + 50, (int)npc.position.Y, NPCID.ShadowFlameApparition);
				NPC.NewNPC((int)npc.position.X + 50, (int)npc.position.Y, NPCID.Demon);
			}

			if (Main.rand.Next(700) == 0)
				Main.PlaySound(29, (int)npc.position.X, (int)npc.position.Y, Main.rand.Next(41, 44));
		}
        public override void NPCLoot()
        {
        
            {
                if (Main.rand.Next(3) == 0) // For items that you want to have a chance to drop 
                {
                 
                }
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HellBar"), Main.rand.Next(1, 1));
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HellBar"), Main.rand.Next(1, 1));
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HellBar"), Main.rand.Next(1, 1));
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HellBar"), Main.rand.Next(1, 1));
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HellBar"), Main.rand.Next(1, 1));
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HellBar"), Main.rand.Next(1, 1));
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HellBar"), Main.rand.Next(1, 1));
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HellBar"), Main.rand.Next(1, 1));
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HellBar"), Main.rand.Next(1, 1));
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HellBar"), Main.rand.Next(1, 1));
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Fright"), Main.rand.Next(1, 1));
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("HellBar"), Main.rand.Next(1, 1));// For Items that you want to always drop
            } 
        }
        public override bool? DrawHealthBar(byte hbPosition, ref float scale, ref Vector2 position)
        {
            scale = 1.5f;
            return null;
        }
		 public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldNightMonster.Chance * 0.00001f;
        }
        
    }
}