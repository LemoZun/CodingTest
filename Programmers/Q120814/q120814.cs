namespace Q120814
{
    internal class q120814
    {
        /// <summary>
        /// 피자 나눠먹기(1) 
        /// https://school.programmers.co.kr/learn/courses/30/lessons/120814
        /// </summary>
        public class Solution
        {
            public int solution(int n)
            {
                int pizza = n / 7;
                if (n % 7 != 0) pizza++;
                {
                    if (pizza == 0) pizza = 1;
                }                
                return pizza;
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
