namespace Q120823
{
    public class Program
    {
        /// <summary>
        /// 직각 삼각형 출력하기 Q120823
        /// https://school.programmers.co.kr/learn/courses/30/lessons/120823
        /// 
        /// </summary>
        public class Example
        {

        }

        public static void Main()
        {
            String[] s;

            Console.Clear();
            s = Console.ReadLine().Split(' ');
            Console.Clear();
            int n = Int32.Parse(s[0]);

            for(int i = 1; i <= n; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                
            }

        }
    }
}
