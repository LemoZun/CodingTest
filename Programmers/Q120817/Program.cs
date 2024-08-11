namespace Q120817
{
    internal class Program
    {
        public class Solution
        {
            public double solution(int[] numbers)
            {
                // return numbers.Average(); // 다른사람 한줄 코드

                int count = 0;
                double answer = 0;
                for(int i=0; i<numbers.Length;i++)
                {
                    answer += numbers[i];
                    count++;
                }

                answer = answer / count;

                return answer;
            }
        }

            static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
