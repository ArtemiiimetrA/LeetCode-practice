namespace LeetCode.Core.Problems;

public class P190_ReverseBits
{
    public int ReverseBits(int n) {
        var result = 0;
        for (int i = 0; i < 32; i++)
        {
            result <<= 1;        // освобождаем место справа
            result |= (n & 1);   // добавляем последний бит n
            n >>= 1;             // сдвигаем n
        }
        
        return result;
    }
}