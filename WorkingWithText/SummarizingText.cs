﻿using System;
using System.Collections.Generic;

namespace WorkingWithText
{
    public class SummarizingText
    {
        public string SummarizeText(string sentence, int maxLength = 20)
        {
            if (sentence.Length < maxLength)
            {
                return sentence;
            }

            var words = sentence.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                {
                    break;
                }
            }

            return String.Concat(String.Join(" ", summaryWords), "...");
        }
    }
}
