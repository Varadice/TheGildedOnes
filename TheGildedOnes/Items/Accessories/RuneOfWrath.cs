using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGildedOnes.Items.Accessories
{
	public class RuneOfWrath : ModItem
	{
		//random number integer
		int random;
		public class Wrath : ModPlayer
		{
			public bool Wrathed;
			public override void ResetEffects() 
			{
				Wrathed = false;
			}
			public override void OnHitNPC(Item item, NPC target, int damage, float knockback, bool crit) 
			{
				if (Wrathed)
				{
					target.AddBuff(BuffID.Frostburn, 60, false);
					target.AddBuff(BuffID.OnFire, 60, false);
					player.AddBuff(BuffID.OnFire, 300, false);
				}
			}
			public override void OnHitNPCWithProj(Projectile proj, NPC target, int damage, float knockback, bool crit) 
			{
				if (Wrathed)
				{
					target.AddBuff(BuffID.Frostburn, 60, false);
					target.AddBuff(BuffID.OnFire, 60, false);
					player.AddBuff(BuffID.OnFire, 300, false);
				}
			}

		}
		
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Rune Of Wrath");
			Tooltip.SetDefault("All attacks burn enemies, but power requires sacrifice...");
		}

		public override void SetDefaults() {
			item.width = 28; 
			item.height = 24;
			item.accessory = true; // Makes this item an accessory.
			item.rare = ItemRarityID.Blue; 
			item.value = Item.sellPrice(gold: 1); // Sets the item sell price to one gold coin.
		}

		public override void UpdateAccessory(Player player, bool hideVisual) {
			while (true)
			{
				 random = Main.rand.Next(1, 10);
				break;
			}
			float SpeedX = 0;
			float SpeedY = 0;
          
			Color newColor = default;
			
			Dust.NewDust(player.Center, 1, 1, DustID.BlueFairy, SpeedX, SpeedY, 0, newColor, 1f);
			Dust.NewDust(player.Center, 1, 1, DustID.PinkFairy, SpeedX, SpeedY, 0, newColor, 1f);
			player.GetModPlayer<Wrath>().Wrathed = true;
		}
		
	}
}
