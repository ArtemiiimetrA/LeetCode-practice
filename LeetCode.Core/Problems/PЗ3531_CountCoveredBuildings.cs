namespace LeetCode.Core.Problems;

public class PЗ3531_CountCoveredBuildings
{
    public int CountCoveredBuildings(int n, int[][] buildings) 
    {
        var rowMinMax = new (int Min, int Max)[n + 1];
        var colMinMax = new (int Min, int Max)[n + 1];

        for (int i = 0; i <= n; i++)
        {
            rowMinMax[i] = (int.MaxValue, int.MinValue);
            colMinMax[i] = (int.MaxValue, int.MinValue);
        }

        foreach (var building in buildings)
        {
            int x = building[0];
            int y = building[1];
            
            rowMinMax[x].Min = Math.Min(rowMinMax[x].Min, y);
            rowMinMax[x].Max = Math.Max(rowMinMax[x].Max, y);
            colMinMax[y].Min = Math.Min(colMinMax[y].Min, x);
            colMinMax[y].Max = Math.Max(colMinMax[y].Max, x);
        }

        int result = 0;
        foreach (var building in buildings)
        {
            int x = building[0];
            int y = building[1];

            bool hasLeft  = rowMinMax[x].Min < y;
            bool hasRight = rowMinMax[x].Max > y;
            bool hasUp    = colMinMax[y].Min < x;
            bool hasDown  = colMinMax[y].Max > x;

            if (hasLeft && hasRight && hasUp && hasDown)
                result++;
        }
        
        return result;
    }
}