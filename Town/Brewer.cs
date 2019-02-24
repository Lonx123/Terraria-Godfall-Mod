using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
 
namespace Godfall.Town          //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
    [AutoloadHead]
    public class Brewer : ModNPC
    {
        
        public override void SetDefaults()
        {
           
            npc.townNPC = true; //This defines if the npc is a town Npc or not
            npc.friendly = true;  //this defines if the npc can hur you or not()
            npc.width = 18; //the npc sprite width
            npc.height = 46;  //the npc sprite height
            npc.aiStyle = 7; //this is the npc ai style, 7 is Pasive Ai
            npc.defense = 25;  //the npc defense
            npc.lifeMax = 250;// the npc life
            npc.HitSound = SoundID.NPCHit1;  //the npc sound when is hit
            npc.DeathSound = SoundID.NPCDeath1;  //the npc sound when he dies
            npc.knockBackResist = 0.5f;  //the npc knockback resistance
            Main.npcFrameCount[npc.type] = 25; //this defines how many frames the npc sprite sheet has
            NPCID.Sets.ExtraFramesCount[npc.type] = 9;
            NPCID.Sets.AttackFrameCount[npc.type] = 4;
            NPCID.Sets.DangerDetectRange[npc.type] = 150; //this defines the npc danger detect range
            NPCID.Sets.AttackType[npc.type] = 3; //this is the attack type,  0 (throwing), 1 (shooting), or 2 (magic). 3 (melee)
            NPCID.Sets.AttackTime[npc.type] = 30; //this defines the npc attack speed
            NPCID.Sets.AttackAverageChance[npc.type] = 10;//this defines the npc atack chance
            NPCID.Sets.HatOffsetY[npc.type] = 4; //this defines the party hat position
            animationType = NPCID.Guide;  //this copy the guide animation
        }
        public override bool CanTownNPCSpawn(int numTownNPCs, int money) //Whether or not the conditions have been met for this town NPC to be able to move into town.
        {
            if (NPC.downedBoss1)  //so after the EoC is killed
            {
                return true;
            }
            return false;
        }
        public override bool CheckConditions(int left, int right, int top, int bottom)    //Allows you to define special conditions required for this town NPC's house
        {
            return true;  //so when a house is available the npc will  spawn
        }
        public override string TownNPCName()     //Allows you to give this town NPC any name when it spawns
        {
            switch (WorldGen.genRand.Next(6))
            {
                case 0:
                    return "Rick";
                case 1:
                    return "Denis";
                case 2:
                    return "Matt";
                case 3:
                    return "Jack";
                case 4:
                    return "Thayer";
                case 5:
                    return "Oddball";
                default:
                    return "Walter";
            }
        }
 
        public override void SetChatButtons(ref string button, ref string button2)  //Allows you to set the text for the buttons that appear on this town NPC's chat window.
        {
            button = "Buy Potions";   //this defines the buy button name
        }
        public override void OnChatButtonClicked(bool firstButton, ref bool openShop) //Allows you to make something happen whenever a button is clicked on this town NPC's chat window. The firstButton parameter tells whether the first button or second button (button and button2 from SetChatButtons) was clicked. Set the shop parameter to true to open this NPC's shop.
        {
 
            if (firstButton)
            {
                openShop = true;   //so when you click on buy button opens the shop
            }
        }
 
        public override void SetupShop(Chest shop, ref int nextSlot)       //Allows you to add items to this town NPC's shop. Add an item by setting the defaults of shop.item[nextSlot] then incrementing nextSlot.
        {
            shop.item[nextSlot].SetDefaults(mod.ItemType("BioBlade"));  //this is an example of how to add a modded item
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.IronskinPotion);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.WormholePotion);
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.RedPotion);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.LesserHealingPotion);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.HealingPotion);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.LesserManaPotion);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.ManaPotion);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.ThornsPotion);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.RestorationPotion);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.WaterWalkingPotion);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.SpelunkerPotion);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.MagicPowerPotion);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.ObsidianSkinPotion);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.ArcheryPotion);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.GravitationPotion);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.RecallPotion);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.BattlePotion);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.SwiftnessPotion);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.GillsPotion);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.TitanPotion);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.FlipperPotion);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.CalmingPotion);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.SummoningPotion);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.BuilderPotion);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.WarmthPotion);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.FishingPotion);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.WrathPotion);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.RagePotion);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.InfernoPotion);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.EndurancePotion);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.AmmoReservationPotion);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.GenderChangePotion);
            nextSlot++;
        }
 
        public override string GetChat()       //Allows you to give this town NPC a chat message when a player talks to it.
        {
           
            switch (Main.rand.Next(4))    //this are the messages when you talk to the npc
            {
                case 0:
                    return "Mph, mph, mph... What's up!";
                case 1:
                    return "Be quick, some of my items aren't really... legal.";
                case 2:
                    return "Nice hat!";
                case 3:
                    return "The dev told me that I was originally supposed to be a hat!";
                default:
                    return "Who the heck brews potions anyway? Oh wait... I do...";
 
            }
        }
        public override void TownNPCAttackStrength(ref int damage, ref float knockback)//  Allows you to determine the damage and knockback of this town NPC attack
        {
            damage = 40;  //npc damage
            knockback = 2f;   //npc knockback
        }
 
        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)  //Allows you to determine the cooldown between each of this town NPC's attack. The cooldown will be a number greater than or equal to the first parameter, and less then the sum of the two parameters.
        {
            cooldown = 5;
            randExtraCooldown = 10;
        }
        //------------------------------------This is an example of how to make the npc use a sward attack-------------------------------
        public override void DrawTownAttackSwing(ref Texture2D item, ref int itemSize, ref float scale, ref Vector2 offset)//Allows you to customize how this town NPC's weapon is drawn when this NPC is swinging it (this NPC must have an attack type of 3). Item is the Texture2D instance of the item to be drawn (use Main.itemTexture[id of item]), itemSize is the width and height of the item's hitbox
        {
            scale = 1f;
            item = Main.itemTexture[mod.ItemType("BioBlade")]; //this defines the item that this npc will use
            itemSize = 56;
        }
 
        public override void TownNPCAttackSwing(ref int itemWidth, ref int itemHeight) //  Allows you to determine the width and height of the item this town NPC swings when it attacks, which controls the range of this NPC's swung weapon.
        {
            itemWidth = 56;
            itemHeight = 56;
        }
 
        //----------------------------------This is an example of how to make the npc use a gun and a projectile ----------------------------------
        /*public override void DrawTownAttackGun(ref float scale, ref int item, ref int closeness) //Allows you to customize how this town NPC's weapon is drawn when this NPC is shooting (this NPC must have an attack type of 1). Scale is a multiplier for the item's drawing size, item is the ID of the item to be drawn, and closeness is how close the item should be drawn to the NPC.
          {
              scale = 1f;
              item = mod.ItemType("GunName");  
              closeness = 20;
          }
          public override void TownNPCAttackProj(ref int projType, ref int attackDelay)//Allows you to determine the projectile type of this town NPC's attack, and how long it takes for the projectile to actually appear
          {
              projType = ProjectileID.CrystalBullet;
              attackDelay = 1;
          }
 
          public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)//Allows you to determine the speed at which this town NPC throws a projectile when it attacks. Multiplier is the speed of the projectile, gravityCorrection is how much extra the projectile gets thrown upwards, and randomOffset allows you to randomize the projectile's velocity in a square centered around the original velocity
          {
              multiplier = 7f;
             // randomOffset = 4f;
 
          }   */
 
    }
}