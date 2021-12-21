using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TheGildedOnes.Buffs;

namespace TheGildedOnes.Items.Accessories
{
	public class RuneOfBastion : ModItem
	{
		bool PowerIsActive;
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
			//increase defence
			player.statDefense = player.statDefense + 8;

			//check if player has pressed the hotkey binded in the game and if the player doesnt have the cooldown debuff
			if (TheGildedOnes.BastAbilityHotKey.JustPressed && !player.HasBuff(ModContent.BuffType<CoolDownDebuff>()))
			{
				//adds the Bast buff for 20 seconds
				player.AddBuff(ModContent.BuffType<BastBuff>(), 1250);
			}
			//check if player has the bast buff
			if(player.HasBuff(ModContent.BuffType<BastBuff>()))
            {
				//gives the player a 40 second cooldown debuff
				player.AddBuff(ModContent.BuffType<CoolDownDebuff>(), 2450);
			}
		}
	}
}
