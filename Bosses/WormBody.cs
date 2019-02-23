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
    
    public class WormBody : ModNPC
    {

	   


	    private Player player;
        private float speed;
        public override void SetDefaults()
        {
            
            
            npc.width = 48;               //this is where you put the npc sprite width.     important
            npc.height = 50;              //this is where you put the npc sprite height.   important
            npc.damage = 200;
            npc.defense = 150;
            npc.lifeMax = 1;
            npc.knockBackResist = 0.0f;
            npc.behindTiles = true;
            npc.noTileCollide = true;
            npc.netAlways = true;
            npc.noGravity = true;
			npc.boss = true;

            npc.dontCountMe = true;
            npc.HitSound = SoundID.NPCHit1;
           
        }
        
	    public override void AI()
		{
			if (Main.netMode != 1 && Main.rand.Next(100) == 0)
			{
				NPC.NewNPC((int)npc.position.X - 50, (int)npc.position.Y, mod.NPCType("Eye"));
		        NPC.NewNPC((int)npc.position.X - 50, (int)npc.position.Y, mod.NPCType("Eye"));
				NPC.NewNPC((int)npc.position.X - 50, (int)npc.position.Y, mod.NPCType("Eye"));
		        NPC.NewNPC((int)npc.position.X - 50, (int)npc.position.Y, mod.NPCType("Eye"));
			}
			
			
			if (Main.rand.Next(700) == 0)
			Main.PlaySound(29, (int)npc.position.X, (int)npc.position.Y, Main.rand.Next(41, 44));
		}

        public override bool PreAI()
        {
            if (npc.ai[3] > 0)
                npc.realLife = (int)npc.ai[3];
            if (npc.target < 0 || npc.target == byte.MaxValue || Main.player[npc.target].dead)
                npc.TargetClosest(true);
            if (Main.player[npc.target].dead && npc.timeLeft > 300)
                npc.timeLeft = 300;
 
            if (Main.netMode != 1)
            {
                if (!Main.npc[(int)npc.ai[1]].active)
                {
                    npc.life = 0;
                    npc.HitEffect(0, 10.0);
                    npc.active = false;
                    NetMessage.SendData(28, -1, -1, null, npc.whoAmI, -1f, 0f, 0f, 0, 0, 0);
                }
            }
 
            if (npc.ai[1] < (double)Main.npc.Length)
            {
                // We're getting the center of this NPC.
                Vector2 npcCenter = new Vector2(npc.position.X + (float)npc.width * 0.5f, npc.position.Y + (float)npc.height * 0.5f);
                // Then using that center, we calculate the direction towards the 'parent NPC' of this NPC.
                float dirX = Main.npc[(int)npc.ai[1]].position.X + (float)(Main.npc[(int)npc.ai[1]].width / 2) - npcCenter.X;
                float dirY = Main.npc[(int)npc.ai[1]].position.Y + (float)(Main.npc[(int)npc.ai[1]].height / 2) - npcCenter.Y;
                // We then use Atan2 to get a correct rotation towards that parent NPC.
                npc.rotation = (float)Math.Atan2(dirY, dirX) + 1.57f;
                // We also get the length of the direction vector.
                float length = (float)Math.Sqrt(dirX * dirX + dirY * dirY);
                // We calculate a new, correct distance.
                float dist = (length - (float)npc.width) / length;
                float posX = dirX * dist;
                float posY = dirY * dist;
 
                // Reset the velocity of this NPC, because we don't want it to move on its own
                npc.velocity = Vector2.Zero;
                // And set this NPCs position accordingly to that of this NPCs parent NPC.
                npc.position.X = npc.position.X + posX;
                npc.position.Y = npc.position.Y + posY;
            }
            return false;
        }
        
		private void Target()
        {
            player = Main.player[npc.target]; // This will get the player target.
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
                    if(npc.timeLeft > 1000)
                    {
                        npc.timeLeft = 100;
                    }
                    return;
                }
            }
        }
    }
}