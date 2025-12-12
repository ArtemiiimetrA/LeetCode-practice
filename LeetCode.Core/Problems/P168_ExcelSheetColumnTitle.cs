using System.Text;

namespace LeetCode.Core.Problems;

public class P168_ExcelSheetColumnTitle
{
    public string ConvertToTitle(int columnNumber)
    {
        StringBuilder result = new();

        while (columnNumber > 0)
        {
            columnNumber--;
            char letter = (char)('A' + columnNumber % 26);
            result.Insert(0, letter);
            columnNumber /= 26;
        }
        
        return result.ToString();
    }
}