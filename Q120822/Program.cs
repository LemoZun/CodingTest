using System.Text;
using System.Collections.Generic;

namespace Q120822
{
    public class Program
    {
        /// <summary>
        /// 문자열 뒤집기 Q120822
        /// https://school.programmers.co.kr/learn/courses/30/lessons/120822
        /// 
        /// </summary>
        public class Solution
        {
            public string solution(string my_string)
            {
                string answer = "";
                Stack<char> stack = new Stack<char>();
                for (int i = 0; i < my_string.Length; i++)
                {
                    stack.Push(my_string[i]);
                }
                StringBuilder sb = new StringBuilder(my_string.Length);

                while(stack.Count > 0)
                {
                    sb.Append(stack.Pop());
                }

                answer = sb.ToString();
                
                
                return answer;

                return new string(my_string.Reverse().ToArray()); // 다른 사람의 풀이
            }
        }
        

        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine(s.solution("jaron"));
            
        }
    }
}
