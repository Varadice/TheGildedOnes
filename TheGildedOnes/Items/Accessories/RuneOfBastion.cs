using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGildedOnes.Items.Accessories
{
	public class RuneOfBastion : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Rune Of Bastion");
			Tooltip.SetDefault("Grants 5 extra defense.");
		}

		public override void SetDefaults() {
			item.width = 28; 
			item.height = 24;
			item.accessory = true; // Makes this item an accessory.
			item.rare = ItemRarityID.Blue; 
			item.value = Item.sellPrice(gold: 1); // Sets the item sell price to one gold coin.
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.statDefense = player.statDefense + 5;
		}
	}
}
