using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Godfall.Items
{
	public class Hawkmoon : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("An Exotic weapon that fires a high powered shot, looks futuristic.");
		}
		/*public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .70f;
		}*/
		
		/*public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (type == ProjectileID.Bullet) // or ProjectileID.WoodenArrowFriendly
			{
				type = ProjectileID.BulletHighVelocity; // or ProjectileID.FireArrow;
			}
			return true; // return true to allow tmodloader to call Projectile.NewProjectile as normal
		}*/
		public override void SetDefaults()
		{
			item.damage = 350;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4;
			item.value = 5000000;
			item.rare = 7;
			item.UseSound = SoundID.Item11;
			item.autoReuse = false;
			item.shoot = 10; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 100f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID. Revolver, 1);
			recipe.AddIngredient(ItemID. IllegalGunParts, 1);
			recipe.AddIngredient(ItemID. GiantHarpyFeather, 1);
			recipe.AddTile(TileID. MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		}
}
