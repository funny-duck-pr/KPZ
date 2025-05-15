using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class HeroBuilder : ICharacterBuilder
    {
        private Character _character = new();

        public ICharacterBuilder SetName(string name)
        {
            _character.Name = name;
            return this;
        }

        public ICharacterBuilder SetBodyType(string bodyType)
        {
            _character.BodyType = bodyType;
            return this;
        }

        public ICharacterBuilder SetHairColor(string color)
        {
            _character.HairColor = color;
            return this;
        }

        public ICharacterBuilder SetEyeColor(string color)
        {
            _character.EyeColor = color;
            return this;
        }

        public ICharacterBuilder SetOutfit(string outfit)
        {
            _character.Outfit = outfit;
            return this;
        }

        public ICharacterBuilder AddToInventory(string item)
        {
            _character.Inventory.Add(item);
            return this;
        }

        public ICharacterBuilder AddDeed(string deed)
        {
            _character.Deeds.Add("Good: " + deed);
            return this;
        }

        public Character Build()
        {
            return _character;
        }
    }
}