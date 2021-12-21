using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGildedOnes
{
	class TheGildedOnes : Mod
	{
        // for the hotkey
        internal static ModHotKey BastAbilityHotKey;
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
            //sets the hotkey as Z default
            BastAbilityHotKey = RegisterHotKey("Armor Ability", "Z");
        }
    }
}
