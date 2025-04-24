using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    public interface IHero
    {
        string GetDescription();
        int GetPower();
    }

    public class Warrior : IHero
    {
        public string GetDescription() => "Warrior";
        public int GetPower() => 10;
    }

    public class Mage : IHero
    {
        public string GetDescription() => "Mage";
        public int GetPower() => 8;
    }

    public class Paladin : IHero
    {
        public string GetDescription() => "Paladin";
        public int GetPower() => 9;
    }

    public abstract class HeroDecorator : IHero
    {
        protected IHero hero;

        public HeroDecorator(IHero hero)
        {
            this.hero = hero;
        }

        public virtual string GetDescription() => hero.GetDescription();
        public virtual int GetPower() => hero.GetPower();
    }

    public class Sword : HeroDecorator
    {
        public Sword(IHero hero) : base(hero) { }

        public override string GetDescription() => hero.GetDescription() + " with Sword";
        public override int GetPower() => hero.GetPower() + 5;
    }

    public class Armor : HeroDecorator
    {
        public Armor(IHero hero) : base(hero) { }

        public override string GetDescription() => hero.GetDescription() + " wearing Armor";
        public override int GetPower() => hero.GetPower() + 3;
    }

    public class Artifact : HeroDecorator
    {
        public Artifact(IHero hero) : base(hero) { }

        public override string GetDescription() => hero.GetDescription() + " holding Artifact";
        public override int GetPower() => hero.GetPower() + 7;
    }
}

