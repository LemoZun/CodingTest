namespace Q12969
{
    public class Program
    {
        /// <summary>
        /// 직사각형 별찍기 Q12969
        /// https://school.programmers.co.kr/learn/courses/30/lessons/12969
        /// </summary>
        /// <param name="args"></param>
        public class Solution
        {
            public void solution(int n , int m)
            {
                Console.Clear();
                for (int i = 0; i < m; i++)
                {
                    for(int j = 0; j < n; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

            }
        }


        static void Main(string[] args)
        {
            String[] s;
            Console.Clear();
            s = Console.ReadLine().Split(' ');

            int a = Int32.Parse(s[0]);
            int b = Int32.Parse(s[1]);
            Solution solution = new Solution();
            solution.solution(a, b);

        }
    }
}
