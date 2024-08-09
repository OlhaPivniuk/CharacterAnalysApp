namespace CharacterAnalysApp
{
    public class StringAnalyzer
    {
        public int MaxNumberUnequalConsecutiveChar(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            int maxLength = 1;
            int currentLength = 1;
            char previousChar = input[0];

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != previousChar && !char.IsWhiteSpace(input[i]))
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                    }
                    if (input[i] != ' ')
                    {
                        currentLength = 1;
                    }
                }
                previousChar = input[i];
            }

            return Math.Max(maxLength, currentLength);
        }
        public int MaxNumberConsecutiveIdenticalLetters(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            int maxCount = 0;
            int currentCount = 0;
            char? currentChar = null;

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    if (c == currentChar)
                    {
                        currentCount++;
                    }
                    else
                    {
                        currentChar = c;
                        currentCount = 1;
                    }

                    maxCount = Math.Max(maxCount, currentCount);
                }
                else
                {
                    currentChar = null;
                    currentCount = 0;
                }
            }

            return maxCount;
        }

        public int MaxNumberConsecutiveIdenticalDigits(string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                return 0;
            }
            int maxCount = 0;
            int currentCount = 0;
            char? currentChar = null;

            foreach (char c in input)
            {
                if (char.IsDigit(c) && (currentChar == null || c == currentChar)) 
                {
                    currentCount++;
                    maxCount = Math.Max(maxCount, currentCount);
                    currentChar = c;
                }
                else if(char.IsDigit(c))
                {
                    currentChar= c;
                    currentCount = 1;
                }
                else
                { 
                    currentChar = null;
                    currentCount = 0;
                }
            }
            return maxCount;
        }
    }
}
