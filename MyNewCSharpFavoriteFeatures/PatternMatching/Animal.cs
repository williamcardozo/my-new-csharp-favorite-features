using MyNewCSharpFavoriteFeatures.General;

namespace MyNewCSharpFavoriteFeatures.PatternMatching
{
    public class Animal
    {
        public bool Herbivore { get; set; }

        public Classification Classification { get; set; }

        public Animal(bool herbivore, Classification classification)
        {
            Herbivore = herbivore;
            Classification = classification;
        }
    }
}
