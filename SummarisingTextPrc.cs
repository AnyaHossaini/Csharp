using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SummText 
{
    class SummarisingTextPrc 
    {
        static void Main (string[] args) 
        {
            var sentence = "This is going to be a really really really really really long text.";
            var summary = SummerizeText(sentence,25);
            Console.WriteLine(summary);
        }

        static string SummerizeText (string text, int maxLength = 20) 
        {
            if (text.Length < maxLength) 
            {
                return text;
            }
            var words = text.Split (' ');
            var totalCharaters = 0;
            var summaryWords = new List<string> ();

            foreach (var word in words) 
            {
                summaryWords.Add(word);
                
                totalCharaters += word.Length + 1;
                if (totalCharaters > maxLength) 
                {
                    break;
                }
            }
            return String.Join(" ",summaryWords) + "...";
        }
    }
}
