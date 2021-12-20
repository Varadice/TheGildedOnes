using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGildedOnes.Items.Accessories
{
	public class RuneOfBastion : ModItem
	{
		
		
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
			player.statDefense = player.statDefense + 8;
			player.AddBuff(BuffID.Slow, 60, false);
			player.AddBuff(BuffID.WellFed, 60, false);
			player.AddBuff(BuffID.Thorns, 60, false);
		}
	}
}
