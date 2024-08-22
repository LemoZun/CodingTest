using System.Text;

namespace Q120825
{
    public class Program
    {
        /// <summary>
        /// 문자 반복 출력하기 Q120825
        /// https://school.programmers.co.kr/learn/courses/30/lessons/120825
        /// </summary>
        public class Solution
        {
            public string solution(string my_string, int n)
            {
                string answer = "";
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < my_string.Length; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        sb.Append(my_string[i]);
                    }
                }
                answer = sb.ToString();

                return answer;
            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            
            Console.WriteLine(s.solution("hello", 3));
        }
    }
}
