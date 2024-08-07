namespace Q120815
{
    internal class Program
    {
        /// <summary>
        /// 피자 나눠먹기 (2)
        /// https://school.programmers.co.kr/learn/courses/30/lessons/120815
        /// </summary>
        public class Solution
        {
            public int solution(int n)
            {
                int answer = 1;
                while((6*answer) % n != 0)
                {
                    answer++;
                }

                return answer;
            }
        }

        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine($"{s.solution(1)}");
        }
    }
}
