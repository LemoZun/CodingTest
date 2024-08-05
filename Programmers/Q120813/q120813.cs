namespace Q120813
{
    internal class q120813
    {
        public class Solution
        {
            /// <summary>
            /// 짝수는 싫어요
            /// https://school.programmers.co.kr/learn/courses/30/lessons/120813 
            /// </summary>
            /// <param name="n"> 정수 n </param>
            /// <returns> n 이하의 홀수가 오름차순으로 담긴 배열 </returns>
            public int[] solution(int n)
            {
                int[] temp = new int[(n + 1) / 2];

                int index = 0;
                for (int i = 1; i <= n; i++)
                {
                    if (i % 2 != 0)
                    {
                        temp[index] = i;
                        index++;
                    }
                }
                return temp;
            }
            // (i << 1) 비트연산, i * 2 와 같음
            /* 다른 사람의 풀이(시프트 연산 활용)
            public int[] solution(int n)
            {
                int[] answer = new int[(n + 1) / 2];
                for (int i = 0; i < (n + 1) / 2; i++)
                    answer[i] = (i << 1) + 1;
                return answer;
            }
            */
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int[] answer = s.solution(10);

            foreach (int i in answer)
                Console.WriteLine(i);
        }
    }
}

