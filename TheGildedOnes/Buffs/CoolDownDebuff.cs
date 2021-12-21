using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TheGildedOnes.Buffs
{
    class CoolDownDebuff : ModBuff
    {
        public override void SetDefaults()
        {
            // name and description
            DisplayName.SetDefault("Tired");
            Description.SetDefault("Cannot use again for 40 seconds");
            // makes sure nurse cannot take the buff off
            Main.debuff[Type] = false;
        }
        public override void Update(Player player, ref int buffIndex)
        {
          
        }

    }
}
