using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGildedOnes.Items.Accessories
{
    public class RuneOfDexterity : ModItem
    {
        //timer, duh
        int timer;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rune Of Dexterity");
            Tooltip.SetDefault("Grants spectral flight, but your legs are unused to walking");
        }
        //basic defaults
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 24;
            item.accessory = true; // Makes this item an accessory.
            item.rare = ItemRarityID.Blue;
            item.value = Item.sellPrice(gold: 1); // Sets the item sell price to one gold coin.
        }

        //this is to fly
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            //dont worry about this
            float SpeedX = 5;
            float SpeedY = 5;
            Color newColor = default;
            //this only happens if you have the space bar pressed down and the timer is less than 100
            if (player.controlJump && ++timer <= 100)
            {
                //this sets the player velocity so its like "flying" and a cool particle under the players feet
                player.velocity.Y = 100f * player.direction;
                player.velocity.X = 10f * player.direction;
                player.jump = 45;
                Dust.NewDust(player.BottomLeft , 1, 1, DustID.BlueFairy ,SpeedX, SpeedY, 0, newColor, 2f);
				
                
            }
            //resets the timer when the player touches the ground
            if (player.velocity.Y == 0f)
            {
				player.AddBuff(46, 60, false);
                timer = 0;
            }
        }
    }
}
