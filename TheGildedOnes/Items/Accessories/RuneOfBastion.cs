using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGildedOnes.Items.Accessories
{
	public class RuneOfBastion : ModItem
	{
		bool PowerIsActive;

		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Rune Of Bastion");
			Tooltip.SetDefault("Turns you near indestructable, but there are some who are out for what is yours...");
		}
		
		public override void SetDefaults() {
			item.width = 28; 
			item.height = 24;
			item.accessory = true; // Makes this item an accessory.
			item.rare = ItemRarityID.Blue; 
			item.value = Item.sellPrice(gold: 1); // Sets the item sell price to one gold coin.
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
<<<<<<< HEAD
			player.statDefense = player.statDefense + 5;
			if (TheGildedOnes.ArmorAbilityHotKey.JustPressed)
			{
				player.AddBuff(BuffID.Battle, 120, false);
				player.AddBuff(BuffID.Endurance, 120, false);
				PowerIsActive = true;
				
			}
			if(PowerIsActive == true && player.HasBuff(BuffID.Battle) || PowerIsActive == true && player.HasBuff(BuffID.Battle))
            {

            }
=======
			player.statDefense = player.statDefense + 8;
			player.AddBuff(BuffID.Slow, 60, false);
			player.AddBuff(BuffID.WellFed, 60, false);
			player.AddBuff(BuffID.Thorns, 60, false);
>>>>>>> b1959742c65d1cf2f8d3986952fcd4d14dd71e7e
		}
	}
}
