using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace TheGildedOnes.Buffs
{
    class CoolDownDebuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Tired");
            Description.SetDefault("Cannot use again for 40 seconds");
            Main.debuff[Type] = true;
        }
        public override void Update(NPC npc, ref int buffIndex)
        {
            
        }

    }
}
