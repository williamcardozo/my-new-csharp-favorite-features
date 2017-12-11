using System;
using System.Collections.Generic;
using System.Text;

namespace MyNewCSharpFavoriteFeatures.Tuples
{
    class TuplesSample
    {
        public Tuple<int, string> GetSerieDataWithOldTuples()
        {
            return new Tuple<int, string>(1, "Courage, the cowardly dog");
        }

        public (int id, string name) GetSerieDataWithNewTuples()
        {
            return (2, "The Adventures of Billy and Mandy");
        }

        public void MethodUsingTuples()
        {
            var courage = GetSerieDataWithOldTuples();
            var adventuresOfBillyAndMandy = GetSerieDataWithNewTuples();

            Console.WriteLine($"Id:{courage.Item1} Serie name:{courage.Item2}");
            Console.WriteLine($"Id:{adventuresOfBillyAndMandy.id} Serie name:{adventuresOfBillyAndMandy.name}");
        }
    }
}
