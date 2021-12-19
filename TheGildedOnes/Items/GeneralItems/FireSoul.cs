using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGildedOnes.Items.GeneralItems
{
	public class FireSoul : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Fire Soul");
			Tooltip.SetDefault("A soul taken from the hottest of climates.");
		}

		public override void SetDefaults() 
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 10000;
			item.rare = 0;
        }
	}

	class FireSoulDrop : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (!npc.boss && npc.lifeMax > 1 && npc.damage > 0 && !npc.friendly && npc.value > 0f )
			{
				if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneUnderworldHeight)
				{
					if (Main.rand.Next(2) == 0)
					{	
						Item.NewItem(npc.getRect(), ModContent.ItemType<GeneralItems.FireSoul>(), Main.rand.Next(1, 3));
					}
				}
			}		
		}
	}
	


}