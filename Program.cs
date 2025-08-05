namespace Assignment_5._2._1
{
    //Given a string s consisting of words and spaces, return the length of the last word
    //in the string. A word is a maximal substring consisting of non-space characters only.
    //Status: Complete
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintOutput("Fly me to the moon");
            PrintOutput("It's a beautiful day today");

            Console.ReadKey();
        }
        
        //Find the last space in the sentence, add 1 to that and use in substring for last word
        static string GetLastWordInString(string sentence)
        {            
            int lastSpaceLocation = sentence.LastIndexOf(' ');
            string lastWord = sentence.Substring(lastSpaceLocation + 1);
            
            return lastWord;
        }

        static void PrintOutput(string input)
        {
            string lastWord = GetLastWordInString(input);
            Console.WriteLine(input);
            Console.WriteLine($"The last word is '{lastWord}' with length of {lastWord.Length}");
            Console.WriteLine();
        }
    }
}
