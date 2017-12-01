using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewCSharpFavoriteFeatures.PatternMatching
{
    public class AnimalActions
    {
        public void AnimalActionBeforePatternMatching(Animal animal)
        {
            if (animal is Panda)
            {
                var panda = animal as Panda;
                panda.EatBamboo();
            }
            else if(animal is Seal)
            {
                var seal = animal as Seal;
                seal.DoTheBallTrick();
            }
        }

        public void AnimalActionAfterPatternMatching(Animal animal)
        {
            if (animal is Panda panda)
                panda.EatBamboo();
            else if (animal is Seal seal)
                seal.DoTheBallTrick();
        }

        public void NullAnimalValidation()
        {
            Animal animal = null;

            if (animal is null)
                throw new Exception("Animal can't be null");
        }
    }
}
