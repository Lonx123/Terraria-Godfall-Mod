using Terraria.ModLoader;
using Terraria.ID;

namespace Godfall.Items
{
    public class GodfallOre : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Godfall Ore");
            Tooltip.SetDefault("A heavenly presence seems to follow this ore...");
        }

        public override void SetDefaults()
        {
            item.width = 12; // Hitbox Width
            item.height = 12; // Hitbox Height
            item.useTime = 20; // Speed before reuse
            item.useAnimation = 20; // Animation Speed
            item.useStyle = 1; // 1 = Broadsword 
            item.value = 50; // 10 | 00 | 00 | 00 : Platinum | Gold | Silver | Bronze
            item.rare = 2; // Item Tier
            item.UseSound = SoundID.Item1; // Sound effect of item on use 
           
            item.maxStack = 999; // The maximum number you can have of this item.
        }
    }
}