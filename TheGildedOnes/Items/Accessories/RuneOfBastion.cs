using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGildedOnes.Items.Accessories
{
	public class RuneOfBastion : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Rune Of Bastion");
			Tooltip.SetDefault("Grants a great power, but there are some who are out for what is yours...");
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
			player.AddBuff(BuffID.Battle, 60, false);
			player.AddBuff(BuffID.Endurance, 60, false);
		}
	}
}
