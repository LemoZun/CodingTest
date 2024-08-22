namespace Q120830
{
    public class Program
    {
        /// <summary>
        /// 양꼬치 Q120830
        /// https://school.programmers.co.kr/learn/courses/30/lessons/120830
        /// </summary>
        public class Solution
        {
            public int solution(int n, int k)
            {
                int answer = 12000 * n + 2000 * (k - n / 10);
                return answer;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
