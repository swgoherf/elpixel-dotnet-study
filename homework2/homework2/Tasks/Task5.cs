using System;
using System.Collections.Generic;
using System.Text;

namespace homework2.Tasks
{
    public class Task5
    {
        public static void Run(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Текст пуст.");
                return;
            }

            char[] separators = { ' ', ',', '.', '!', '?', ';', ':', '-', '\r', '\n' };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> frequencyMap = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            foreach (string word in words)
            {
                if (frequencyMap.ContainsKey(word))
                    frequencyMap[word]++;
                else
                    frequencyMap[word] = 1;
            }

            List<KeyValuePair<string, int>> wordList = new List<KeyValuePair<string, int>>(frequencyMap);

            wordList.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));

            Console.WriteLine("Топ 3 частых слова:");
            int count = Math.Min(3, wordList.Count);
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}. \"{wordList[i].Key}\" — {wordList[i].Value} раз(а)");
            }
        }
    }
}