using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.task5
{
    public interface ICharacterBuilder<TBuilder>
    {
        TBuilder SetHeight(string height);
        TBuilder SetBodyType(string bodyType);
        TBuilder SetHairColor(string hairColor);
        TBuilder SetEyeColor(string eyeColor);
        TBuilder SetClothes(string clothes);
        TBuilder AddInventoryItem(string item);
        Character Build();
    }
    public abstract class BaseCharacterBuilder<TBuilder> : ICharacterBuilder<TBuilder>
    where TBuilder : BaseCharacterBuilder<TBuilder>
    {
        protected Character _character = new Character();

        public TBuilder SetName(string name)
        {
            _character.Name = name;
            return (TBuilder)this;
        }

        public TBuilder SetHeight(string height)
        {
            _character.Height = height;
            return (TBuilder)this;
        }

        public TBuilder SetBodyType(string bodyType)
        {
            _character.BodyType = bodyType;
            return (TBuilder)this;
        }

        public TBuilder SetHairColor(string hairColor)
        {
            _character.HairColor = hairColor;
            return (TBuilder)this;
        }

        public TBuilder SetEyeColor(string eyeColor)
        {
            _character.EyeColor = eyeColor;
            return (TBuilder)this;
        }

        public TBuilder SetClothes(string clothes)
        {
            _character.Clothes = clothes;
            return (TBuilder)this;
        }

        public TBuilder AddInventoryItem(string item)
        {
            _character.Inventory.Add(item);
            return (TBuilder)this;
        }

        public Character Build()
        {
            return _character;
        }
    }

    public class Character
    {
        public string Name { get; set; }
        public string Height { get; set; }
        public string BodyType { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Clothes { get; set; }
        public List<string> Inventory { get; set; } = new List<string>();
        public List<string> GoodDeeds { get; set; } = new List<string>();
        public List<string> EvilDeeds { get; set; } = new List<string>();

        public void DisplayInfo()
        {
            Console.WriteLine($"--- {Name} ---");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Body Type: {BodyType}");
            Console.WriteLine($"Hair Color: {HairColor}");
            Console.WriteLine($"Eye Color: {EyeColor}");
            Console.WriteLine($"Clothes: {Clothes}");
            Console.WriteLine($"Inventory: {string.Join(", ", Inventory)}");
            if (GoodDeeds.Count > 0)
                Console.WriteLine($"Good Deeds: {string.Join(", ", GoodDeeds)}");
            if (EvilDeeds.Count > 0)
                Console.WriteLine($"Evil Deeds: {string.Join(", ", EvilDeeds)}");
            Console.WriteLine();
        }
    }

    public class HeroBuilder : BaseCharacterBuilder<HeroBuilder>
    {
        public HeroBuilder AddGoodDeed(string deed)
        {
            _character.GoodDeeds.Add(deed);
            return this;
        }
    }

    public class EnemyBuilder : BaseCharacterBuilder<EnemyBuilder>
    {
        public EnemyBuilder AddEvilDeed(string deed)
        {
            _character.EvilDeeds.Add(deed);
            return this;
        }
    }


    public class CharacterDirector
    {
        public Character CreateDreamHero()
        {
            return new HeroBuilder()
                .SetName("Елора Сяйлива")
                .SetHeight("170 см")
                .SetBodyType("Струнка")
                .SetHairColor("Золоте")
                .SetEyeColor("Смарагдові")
                .SetClothes("Магічна мантія")
                .AddInventoryItem("Книга заклинань")
                .AddInventoryItem("Еліксир зцілення")
                .AddGoodDeed("Врятувала село від дракона")
                .AddGoodDeed("Вилікувала поранених")
                .Build();
        }

        public Character CreateEvilEnemy()
        {
            return new EnemyBuilder()
                .SetName("Тінегрим")
                .SetHeight("190 см")
                .SetBodyType("Міцний")
                .SetHairColor("Чорне як ніч")
                .SetEyeColor("Червоні")
                .SetClothes("Обладунки з темної сталі")
                .AddInventoryItem("Меч пітьми")
                .AddEvilDeed("Спалив місто")
                .AddEvilDeed("Отруїв річку")
                .Build();
        }
    }
}
