using System;
using System.Collections;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Hashtable arrayArticles = new Hashtable() 
            {
              {1, "The"},
              {2, "A"},
              {3, "An"}
            };

            Hashtable arrayNouns = new Hashtable() 
            {
                {1, "Man"}, {2, "Bear"}, {3, "Butterfly"}, {4, "Sun"}, {5, "Fish"}
            };

            Hashtable arrayVerbs = new Hashtable()
            {
                {1, "Shines"}, {2, "Drinks"}, {3, "Flies"}, {4, "Jumps"}, {5, "Fall"}
            };

            Hashtable arrayAdjectives = new Hashtable() 
            {
                 {1, "High"}, {2, "Abundantly"}, {3, "Bright"}, {4, "Too much"}, {5, "Absolutely"}
            };
         

            
            string randWord(string word)
            {
                switch (word)
                {
                    case "article":
                        return Convert.ToString(arrayArticles[rand.Next(1, 4)]);
                        
                    case "noun":
                        return Convert.ToString(arrayNouns[rand.Next(1, 5)]);
                        
                    case "verb":
                        return Convert.ToString(arrayVerbs[rand.Next(1, 5)]);
                        
                    case "adjective":
                        return Convert.ToString(arrayAdjectives[rand.Next(1, 5)]);
                        
                    default:
                        return word;
                }
            }

            
            string sentenceOne = $"{randWord("article")} {randWord("noun")} {randWord("verb")} {randWord("adjective")}.";
            string sentenceTwo = $"{randWord("article")} {randWord("noun")} {randWord("verb")} {randWord("adjective")}.";
            string sentenceThree = $"{randWord("article")} {randWord("noun")} {randWord("verb")} {randWord("adjective")}.";
            string sentenceFour = $"{randWord("article")} {randWord("noun")} {randWord("verb")} {randWord("adjective")}.";
            
           
            Hashtable sentences = new Hashtable() 
            {
                {1, sentenceOne}, {2, sentenceTwo}, {3, sentenceThree}, {4, sentenceFour}
            };
            

            var randSentence = sentences[rand.Next(1, 5)];
            string randSentence1 = randSentence.ToString();
            
            //random letter to start with
            char beginning = randSentence1[rand.Next(1, 20)];
            
            //index of that letter
            int beginChar = randSentence1.IndexOf(beginning);

            string toChange = randSentence1.Substring(beginChar);

            if (rand.Next(1, 2) == 1) 
                toChange = toChange.ToUpper();
            else
                toChange = toChange.ToLower();
            
            if (beginChar == 0)
                Console.WriteLine(toChange);

            else
            {
                string otherPart = randSentence1.Substring(0, beginChar);

                if (rand.Next(1,5) == 1)
                    otherPart = otherPart.ToUpper();
                else
                    otherPart = otherPart.ToLower();


                string fullString = otherPart + toChange;
                Console.WriteLine(fullString);
            }
            var values = sentences.Values;
            foreach (var sentence in values)
            {
                if (sentence != randSentence)
                    Console.WriteLine(sentence);
            }
        }
    }
}

