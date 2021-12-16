using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsExercise
{
    public class Kata
    {
        //"this is a test" -> "test a is this"
        //solution: 
        // 1.make an array of words -> ["this", "is", "a", "test"] (SPLIT)
        // 2. reverse the array's elements position -> ["test", "a", "is", "this"] (REVERSE)
        // 3. create final string using reversed elements from the array (JOIN)
        
        public static List<string> Split(string input, char separator)
        {
            var result = new List<string>();
            var currentIndex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] == separator)
                {
                    var word = input.Substring(currentIndex, i - currentIndex);
                    result.Add(word);
                    currentIndex = i + 1; //to jump white space index
                } else if (i == input.Length - 1) //checking if its last word that haven't white sign at the end
                {
                    var word = input.Substring(currentIndex, input.Length - currentIndex);
                    result.Add(word);
                }

            }

            return result;
        }
        public static List<string> Reverse(List<string> list)
        {
            var result = new List<string>();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                result.Add(list[i]);
            }

            return result;
        }

        public static string Join(List<string> list, char separator)
        {   
            //using string builder
            var sb = new StringBuilder();
            for (int i = 0;i < list.Count; i++)
            {
                sb.Append(list[i]);
                if(i != list.Count - 1)
                {
                    sb.Append(separator);
                }
            }
            return sb.ToString();
        }

        //final implementation
        public static string ReverseWords(string str)
        {
            var splitWords = Split(str, ' ');
            var reversedWords = Reverse(splitWords);
            var result = Join(reversedWords, ' ');
            return result;
        }
    }
}
