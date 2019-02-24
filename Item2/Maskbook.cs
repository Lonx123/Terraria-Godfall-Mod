using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
 
namespace Godfall.Item2
{
    public class Maskbook : ModItem
    {

	      public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Spear Strom");
			Tooltip.SetDefault("Roll 10 for fireball.");
			item.value = 5000000;
        }
        public override void SetDefaults()
        {
            //the name displayed when hovering over the Weapon ingame.
            item.damage = 100;  //The damage stat for the Weapon.
            //The description of the Weapon shown when hovering over the Weapon ingame.
            item.noMelee = true;  //Setting to True allows the weapon sprite to stop doing damage, so only the projectile does the damge
            item.noUseGraphic = false;
            item.magic = true;    //This defines if it does magic damage and if its effected by magic increasing Armor/Accessories.
            item.channel = true;                            //Channel so that you can held the weapon
            item.mana = 5; //How mutch mana this weapon use
            item.rare = 10;   //The color the title of your Weapon when hovering over it ingame
            item.width = 28; 
			item.value = 5000000;
			item.value = 5000000; //The size of the width of the hitbox in pixels.
            item.height = 30;    //The size of the height of the hitbox in pixels.
            item.useTime = 7;   //How fast the Weapon is used.
            item.UseSound = SoundID.Item13;  //The sound played when using your Weapon
            item.useStyle = 5;   //The way your Weapon will be used, 5 is the Holding Out Used for: Guns, Spellbooks, Drills, Chainsaws, Flails, Spears for example
            item.shootSpeed = 4f;       //This defines the projectile speed when shoot
            item.useAnimation = 7;
			item.autoReuse = true;   //Speed is not important here
            item.shoot = mod.ProjectileType("Mask");  //This defines what type of projectile this weapon will shoot  
            item.value = Item.sellPrice(2, 0, 0, 0);//  How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 3gold)
        }
    }
}