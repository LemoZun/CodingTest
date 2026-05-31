namespace Q120824
{
    public class Program
    {
        /// <summary>
        /// 짝수 홀수 개수 Q120824
        /// https://school.programmers.co.kr/learn/courses/30/lessons/120824
        /// </summary>
        public class Solution
        {

            public int[] solution(int[] num_list)
            {
                int[] answer = new int[2];
                foreach (int i in num_list)
                {
                    if (i % 2 == 0) answer[0]++;
                    else answer[1]++;
                }
                
                return answer;
            }
        }
        
    }
}
