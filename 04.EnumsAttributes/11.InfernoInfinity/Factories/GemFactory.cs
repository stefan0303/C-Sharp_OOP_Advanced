using System;
using InfernoInfinity.Enum;
using InfernoInfinity.Interfaces.Factories;
using InfernoInfinity.Interfaces.Jewelery;
using InfernoInfinity.Models.Jewelery.Amethysts;
using InfernoInfinity.Models.Jewelery.Emeralds;
using InfernoInfinity.Models.Jewelery.Rubies;

namespace InfernoInfinity.Factories.GemFactory
{
    public class GemFactory : IGemFactory
    {
        public IGem CreateGem(string input)
        {
            IGem gem = null;

            string[] gemParams = input.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            string gemClarity = gemParams[0];
            string getType = gemParams[1];

            Clarity clarity;

            bool isValidGemClarity = System.Enum.TryParse(gemClarity, out clarity);

            if (!isValidGemClarity)
            {
                throw new ArgumentException("Invalid gem clarity!");
            }

            Gems theGem;

            bool isValidGem = System.Enum.TryParse(getType, out theGem);

            if (!isValidGem)
            {
                throw new ArgumentException("Invalid gem type!");
            }

            if (theGem == Gems.Ruby)
            {
                switch (clarity)
                {
                        case Clarity.Chipped:
                            gem = new ChippedRuby();
                        break;
                        case Clarity.Regular:
                            gem = new RegularRuby();
                        break;
                        case Clarity.Perfect:
                            gem = new PerfectRubby();
                        break;
                        case Clarity.Flawless:
                            gem = new FlawlessRuby();
                        break;
                }
            } else if (theGem == Gems.Emerald)
            {
                switch (clarity)
                {
                    case Clarity.Chipped:
                        gem = new ChippedEmerald();
                        break;
                    case Clarity.Regular:
                        gem = new RegularEmerald();
                        break;
                    case Clarity.Perfect:
                        gem = new PerfectEmerald();
                        break;
                    case Clarity.Flawless:
                        gem = new FlawlessEmerald();
                        break;
                }
            } else if (theGem == Gems.Amethyst)
            {
                switch (clarity)
                {
                    case Clarity.Chipped:
                        gem = new ChippedAmethyst();
                        break;
                    case Clarity.Regular:
                        gem = new RegularAmethyst();
                        break;
                    case Clarity.Perfect:
                        gem = new PerfectAmethyst();
                        break;
                    case Clarity.Flawless:
                        gem = new FlawlessAmethyst();
                        break;
                }
            }
            return gem;
        }
    }
}
