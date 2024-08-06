namespace Q120816
{
    internal class Program
    {
        /// <summary>
        /// 피자 나눠먹기 (3)
        /// https://school.programmers.co.kr/learn/courses/30/lessons/120816
        /// </summary>
        public class Solution
        {
            public int solution(int slice, int n)
            {
                int answer = 0;
                while(answer*slice < n)
                {
                    answer++;
                }
                return answer;
            }
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
