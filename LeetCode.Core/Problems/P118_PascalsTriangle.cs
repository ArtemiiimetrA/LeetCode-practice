namespace LeetCode.Core.Problems;

/*
 * Given an integer numRows, return the first numRows of Pascal's triangle.
In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:

Example 1:
Input: numRows = 5
Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]

Example 2:
Input: numRows = 1
Output: [[1]]
 */

public class P118_PascalsTriangle
{
    public IList<IList<int>> Generate(int numRows) 
    {
        var result = new List<IList<int>>();
        if (numRows <= 0)
            return result;

        result.Add(new List<int> { 1 });

        for (int row = 1; row < numRows; row++)
        {
            var prevList = result[row - 1];
            var current = new List<int>(row + 1);
            
            current.Add(1);

            for (int col = 1; col < row; col++)
            {
                current.Add(prevList[col - 1] + prevList[col]);
            }
            current.Add(1);
            result.Add(current);
        }
        
        return result;
    }
    
    public void PrintTriangle(IList<IList<int>> triangle)
    {
        foreach (var row in triangle)
        {
            foreach (var value in row)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
}