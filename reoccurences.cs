using System;

namespace reoccurence_of_the_string
{

    public class DuplicateCharacters
    {
        public static void Main()
        {
            String str = "My country is india i am living in chennai";
            int count;
            char[] string1 = str.ToCharArray();
                Console.WriteLine("The Duplicate characters given in the sentences: ");
            
            for (int i = 0; i < string1.Length; i++)
            {
             count = 1;
              for (int j = i + 1; j < string1.Length; j++)
                {
                  if (string1[i] == string1[j] && string1[i] != ' ')
                    {
                        count++;
                        string1[j] = '0';
                    }
                }
               
                if (count > 1 && string1[i] != '0')
                    Console.WriteLine(string1[i]);
            }
        }
    }
}
