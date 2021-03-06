using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGildedOnes.NPCS.Hostile
{
	// Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class Rotter : ModNPC
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Rotter");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
		}

		public override void SetDefaults() {
			npc.width = 18;
			npc.height = 40;
			npc.damage = 20;
			npc.defense = 2;
			npc.lifeMax = 140;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 22;
			npc.noTileCollide = false;
			aiType = NPCID.Ghost;
			animationType = NPCID.Ghost;
			banner = Item.NPCtoBanner(NPCID.Zombie);
			bannerItem = Item.BannerToItem(banner);
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			return SpawnCondition.OverworldNightMonster.Chance * 0.5f;
		}
		
	}
}
