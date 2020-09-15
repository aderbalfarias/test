//Given an input sequence of several integer value modelling the price of a stock in a given day (quotes), write a method / function that calculates the maximum profit
//that could be done by date by buying 1 unit of the stock at a point in time that day and selling the same stock at a later point in time the same day.
//If no buy and sell combination returns a profit, we can think of the case where the stock is bought and sold fast enough that the price did not change, hence 0 profit.

using System;

namespace MaxProfit
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var quotes = new[] { 1, 2, 3, 4, 5, 6, 7 };

            var quotes2 = new[] { 7, 6, 5, 4, 3, 2, 1 };

            var quotes3 = new[] { 5, 6, 4, 6, 8, 1 };

            var maxProfit1 = MaxProfit(quotes);
            var maxProfit2 = MaxProfit(quotes2);
            var maxProfit3 = MaxProfit(quotes3);

            if (maxProfit1 != 6) throw new System.Exception("Error");
            if (maxProfit2 != 0) throw new System.Exception("Error");
            if (maxProfit3 != 4) throw new System.Exception("Error");
            if (MaxProfit(new int[0]) != 0) throw new System.Exception("Error");
            Console.WriteLine("All good");
        }

        private static int MaxProfit(int[] quotes)
        {
            int target = 0;
            int sum = 0;
            int profit = 0;
            int high = 0;

            for (int i = 0; i < quotes.Length; i++)
            {
                sum += quotes[i - 1];
                target += i;
                //if ()
            }
            //Console.WriteLine(quotes[i]);
            //int[] aux = new int[quotes.Length];
            //Array.Copy(quotes, aux, quotes.Length);
            //MergeSort(quotes, aux, 0, quotes.Length - 1);
            //int min = quotes[0];
            //int max = quotes[quotes.Length - 1];
            //for(int i = 0; i < quotes.Length; i++)
            // Console.WriteLine(quotes[i]);
            //return max - min;
            //return profit;
        }
        public static void Merge(int[] quotes, int[] aux, int low, int mid, int high)
        {
            int x = low;
            int i = low;
            int z = mid + 1;

            while (x <= mid && z <= high)
            {
                if (quotes[i] < aux[z])
                    aux[x++] = quotes[i++];
                else
                    aux[x++] = quotes[z++];
            }

            while (i <= mid)
                aux[x++] = quotes[i++];

            for (i = low; i <= high; i++)
                quotes[i] = aux[i];
        }
        public static void MergeSort(int[] quotes, int[] aux, int low, int high)
        {
            if (high == low)
                return;

            int mid = (low + ((high - low) >> 1));

            MergeSort(quotes, aux, low, mid);
            MergeSort(quotes, aux, mid + 1, high);

            Merge(quotes, aux, low, mid, high);
        }
    }
}