using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGildedOnes
{
	class TheGildedOnes : Mod
	{
        internal static ModHotKey ArmorAbilityHotKey;
        public TheGildedOnes()
		{
			
			Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
		
			
		}
        public override void Load()
        {
            ArmorAbilityHotKey = RegisterHotKey("Armor Ability", "Z");
        }
    }
}
