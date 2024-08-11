namespace Q120819
{
    internal class Program
    {
        public class Solution
        {
            public int[] solution(int money)
            {
                int[] answer = new int[2];
                answer[0] = money / 5500;
                answer[1] = money % 5500;
                return answer;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
