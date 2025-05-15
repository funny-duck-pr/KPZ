using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Director
    {
        public Character CreateHero(ICharacterBuilder builder)
        {
            return builder
                .SetName("Aria the Brave")
                .SetBodyType("Tall and athletic")
                .SetHairColor("Blonde")
                .SetEyeColor("Green")
                .SetOutfit("Shining armor")
                .AddToInventory("Sword of Light")
                .AddToInventory("Healing Potion")
                .AddDeed("Saved the village")
                .AddDeed("Healed a wounded animal")
                .Build();
        }

        public Character CreateEnemy(ICharacterBuilder builder)
        {
            return builder
                .SetName("Dreadlord Xarn")
                .SetBodyType("Tall and muscular")
                .SetHairColor("Black")
                .SetEyeColor("Red")
                .SetOutfit("Dark cloak")
                .AddToInventory("Cursed Blade")
                .AddToInventory("Scroll of Doom")
                .AddDeed("Destroyed a temple")
                .AddDeed("Poisoned a well")
                .Build();
        }
    }
}