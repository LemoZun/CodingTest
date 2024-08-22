namespace Q120831
{
    public class Program
    {
        /// <summary>
        /// 짝수의 합 Q120831
        /// https://school.programmers.co.kr/learn/courses/30/lessons/120831
        /// </summary>
        public class Solution
        {
            public int solution(int n)
            {
                int answer;
                if (n%2 == 0)
                {
                    return answer = n *(n + 2) / 4;
                }
                else
                {
                    return answer = (n * n - 1) / 4;
                }

                // return n/2*(n/2+1); // 다른사람의 풀이

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
