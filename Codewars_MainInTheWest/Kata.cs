using System;
using System.Linq;

namespace Codewars_MainInTheWest
{
    public class Kata
    {
        public bool CheckTheBucket(string[] bucket) => bucket.Any(x => x.Contains("gold"));
    }
}
