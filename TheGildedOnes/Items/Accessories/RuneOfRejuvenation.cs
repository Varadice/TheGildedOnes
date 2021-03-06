using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGildedOnes.Items.Accessories
{
	public class RuneOfRejuvenation : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Rune Of Rejuvenation");
			Tooltip.SetDefault("Grants increased life regen but sometimes, you need to have less to get more...");
		}

		public override void SetDefaults() {
			item.width = 28; 
			item.height = 24;
			item.accessory = true; // Makes this item an accessory.
			item.rare = ItemRarityID.Blue; 
			item.value = Item.sellPrice(gold: 1); // Sets the item sell price to one gold coin.
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.statLifeMax2 = player.statLifeMax2 - 20;
			player.lifeRegen = player.lifeRegen + 3;
		}
	}
}
