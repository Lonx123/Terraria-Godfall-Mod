using Terraria.ModLoader;
using Terraria.ID;

namespace Godfall.Items
{
    public class HellBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hellrise Bar");
            Tooltip.SetDefault("An evil presence seems to follow this bar...");
        }

        public override void SetDefaults()
        {
            item.width = 24; // Hitbox Width
            item.height = 24; // Hitbox Height
            item.useTime = 20; // Speed before reuse
            item.useAnimation = 20; // Animation Speed
            item.useStyle = 1; // 1 = Broadsword 
            item.value = 500000; // 10 | 00 | 00 | 00 : Platinum | Gold | Silver | Bronze
            item.rare = 2; // Item Tier
            item.UseSound = SoundID.Item1; // Sound effect of item on use 
           
            item.maxStack = 99; // The maximum number you can have of this item.
        }

		 public override void AddRecipes()
        {
            ModRecipe r = new ModRecipe(mod);
            r.AddIngredient(null, "GodfallBar", 3);
			r.AddIngredient(ItemID.SoulofNight, 1);
            r.AddTile(TileID.Furnaces);
            r.SetResult(this);
            r.AddRecipe();
        }

    }
}