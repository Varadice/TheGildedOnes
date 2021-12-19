using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheGildedOnes
{
	class TheGildedOnes : Mod
	{
		public TheGildedOnes()
		{
			
			Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
		}	
	}
}
