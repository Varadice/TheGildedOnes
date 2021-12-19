using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGildedOnes.Items.GeneralItems
{
	public class EarthSoul : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Earth Soul");
			Tooltip.SetDefault("A soul taken from the monsters under our feet.");
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

	class EarthSoulDrop : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
		if (!npc.boss && npc.lifeMax > 1 && npc.damage > 0 && !npc.friendly && npc.value > 0f && npc.position.Y > Main.worldSurface * 16.0) //Checks multiple conditions
			{
				if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneJungle)
				{
					if (Main.rand.Next(2) == 0)
					{	
						Item.NewItem(npc.getRect(), ModContent.ItemType<GeneralItems.EarthSoul>(), Main.rand.Next(1, 3));; //What the NPC drops
					}
				}
			}
		}
			
	}
}
