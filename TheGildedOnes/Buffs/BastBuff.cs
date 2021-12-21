using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
namespace TheGildedOnes.Buffs
{
    class BastBuff : ModBuff
    {
        public override void SetDefaults()
        {
            // same thing as the cooldown debuff
            Description.SetDefault("offensive buff");
            DisplayName.SetDefault("Bast Buff");
            Main.debuff[Type] = false;
        }
        public override void Update(Player player, ref int buffIndex)
        {

            // gives the player a thorns endurence and welfed mix
            player.thorns += 1f;
            player.endurance += 1;
            player.wellFed = true;
        }
    }
}
