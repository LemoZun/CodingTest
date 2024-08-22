using System.Text;

namespace Q120826
{
    public class Program
    {
        /// <summary> 
        /// 특정 문자 제거하기 Q120826
        /// https://school.programmers.co.kr/learn/courses/30/lessons/120826
        /// 
        /// </summary>
        public class Solution
        {
            public string solution(string my_string, string letter)
            {
                StringBuilder sb = new StringBuilder();
                string answer = "";
                for (int i = 0; i< my_string.Length; i++)
                {
                    if (!(my_string[i].Equals(letter[0])))
                    {
                        sb.Append(my_string[i]);
                    }

                }
                answer = sb.ToString();
                return answer;
                //  answer = my_string.Replace(letter, ""); // 다른사람의 풀이
            }
        }
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            
            Console.WriteLine(solution.solution("BCBdbe", "B"));
        }
    }
}
