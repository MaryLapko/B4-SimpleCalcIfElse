using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAword
{
    public class Practice
    {
        public static void ReverseAwordFirstOption()
        {
            Console.WriteLine("Insert the word to reverse:");
            var someWordToReverse = Console.ReadLine();
            var someWordReversed = someWordToReverse.ToCharArray().Reverse();
            Console.WriteLine("The reversed word is:" + new string(someWordReversed.ToArray()));
        }
        public static void ReverseAwordSecondOption()
        {
            Console.WriteLine("Insert the word to reverse:");
            var someWordToReverse1 = Console.ReadLine();
            var sb = new StringBuilder();
            //В цикле мы начинаем читать элементы строки с конца.
            for (int i = someWordToReverse1.Length - 1; i >= 0; i--)
            {
                sb.Append(someWordToReverse1[i]);
            }
            Console.WriteLine(sb.ToString()); //321cba
        }
    }
}
