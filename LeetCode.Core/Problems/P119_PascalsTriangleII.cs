namespace LeetCode.Core.Problems;

public class P119_PascalsTriangleII
{
    public IList<int> GetRow(int rowIndex) {
        var result = new List<IList<int>>();
        if (rowIndex == 0)
            return [1];

        result.Add(new List<int> { 1 });

        for (int row = 1; row < rowIndex+1; row++)
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
        
        return result[rowIndex];
    }
    
    public void PrintTriangle(IList<int> triangle)
    {
        foreach (var value in triangle)
        {
            Console.Write(value + " ");
        }
    }
}