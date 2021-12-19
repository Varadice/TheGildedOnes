using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGildedOnes.Items.GeneralItems
{
	public class WaterSoul : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Water Soul");
			Tooltip.SetDefault("A soul taken from the depths of the oceans.");
		}

		public override void SetDefaults() 
		{
			item.width = 40;
			item.height = 40;
			item.maxStack = 999;
			item.value = 10000;
			item.rare = 0;
        }
	}

	class WaterSoulDrop : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (!npc.boss && npc.lifeMax > 1 && npc.damage > 0 && !npc.friendly && npc.value > 0f) //Checks multiple conditions
			{
				if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneBeach) //Checks if the players position is in the desert biome.
				{
					if (Main.rand.Next(2) == 0)
					{	
						Item.NewItem(npc.getRect(), ModContent.ItemType<GeneralItems.WaterSoul>(), Main.rand.Next(1, 3));; //What the NPC drops
					}
				}
			}
			
		}
	}

}