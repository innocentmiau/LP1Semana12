using System.Collections;

namespace HowManyOfThisType
{
    public class Checker
    {

        public static int HowManyOfType<T>(IEnumerable items)
        {
            int count = 0;
            foreach (var item in items)
            {
                if (item is T) count++;
            }

            return count;
        }
        
    }
}