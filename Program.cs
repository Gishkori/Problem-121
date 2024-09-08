public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int buyPrice = prices[0];
        int index = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < buyPrice)
            {
                buyPrice = prices[i];
                index = i;
            }


        }

        int sellPrice = 0;
        for (int j = index + 1; j < prices.Length; j++)
        {
            int tempSell = prices[j] - buyPrice;
            if (tempSell > sellPrice)
            {
                sellPrice = tempSell;
            }
        }
        Console.WriteLine(index + " " + buyPrice + " " + sellPrice);
        return sellPrice;
    }
}


class Program
{
    static void Main()
    {
        Solution profit = new Solution();
        Console.WriteLine(profit.MaxProfit([2, 4, 1]));

    }
}

