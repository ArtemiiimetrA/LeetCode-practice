namespace LeetCode.Core.Problems;

public class P3136_ValidWord
{
    public bool IsValid(string word)
    {
        if (word.Length < 3)
        {
            return false;
        }
        
        bool hasVowel = false;
        bool hasConsonant = false;

        foreach (var c in word)
        {
            if (!char.IsLetterOrDigit(c))
            {
                return false;
            }

            if (char.IsLetter(c))
            {
                if (IsVowel(c))
                {
                    hasVowel = true;
                }
                else
                {
                    hasConsonant = true;
                }
            }
        }
        
        return hasVowel && hasConsonant;
    }
    
    private bool IsVowel(char c)
    {
        c = char.ToLower(c);
        return c is 'a' or 'e' or 'i' or 'o' or 'u';
    }
}