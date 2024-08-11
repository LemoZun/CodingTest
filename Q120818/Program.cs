namespace Q120818
{
    internal class Program
    {
        public class Solution
        {
            public int solution(int price)
            {
                int answer = 0;

                if (price >= 500000)
                {

                    return answer = (int)(price * 0.8);
                }
                else if (price >= 300000)
                    return answer = (int)(price * 0.9);
                else if (price >= 100000)
                    return answer = (int)(price * 0.95);
                else
                {
                    return answer = price;
                }
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
