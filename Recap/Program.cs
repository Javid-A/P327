namespace Recap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("bu TaskI MetHodLA YAZin".Length);
            //Console.WriteLine(ToCapitalized("bu TaskI MetHodLA YAZin").Length);

            //string[] arr = { "bu", "bir", "cumledir" };

            //foreach (var item in " bu bir cumledir".Split())
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine(item.Length);
            //}


            //Console.WriteLine("custom");

            foreach (var item in CustomSplit("tehmasib bir cumledir test soz"))
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Length);
            }
        }

        static string ToCapitalized(string sentence)
        {
            string result = string.Empty;
            string newSentence = sentence.ToLower();// bu taski methodla yazin

            string[] words = newSentence.Split();

            foreach (string word in words)
            {
                result += char.ToUpper(word[0]);

                result += word.Substring(1);
                result += " ";
            }
            return result.TrimEnd();
        }

        static string[] CustomSplit(string sentence)//bu bir cumledir
        {
            //TODO 
            string[] splited = new string[0];
            string find = string.Empty;
            int index = -1;
            int lenght = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    Array.Resize(ref splited, splited.Length+1);
                    find = sentence.Substring(index+1, lenght);
                    index = i;
                    splited[splited.Length - 1] = find;
                    lenght = 0;
                }
                else
                {
                    lenght++;
                }
            }

            return splited;
            
        }
    }
}