using System.Collections.Immutable;

namespace Q120899
{
    internal class Program
    {
        /// <summary>
        /// 가장 큰 수 찾기
        /// Q120899
        /// https://school.programmers.co.kr/learn/courses/30/lessons/120899
        /// </summary>
        public class Solution
        {            
            public int[] solution(int[] array)
            {
                int[] answer = new int[2];

                int maxValue = 0;
                int maxValueIndex = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if(maxValue < array[i])
                    {
                        maxValue = array[i];
                        maxValueIndex = i;
                    }
                }
                answer[0] = maxValue;
                answer[1] = maxValueIndex;
                return answer;
            }
        }
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3,8,7 };
            Solution solution = new Solution();
            
            foreach (int i in solution.solution(array))
            {
                Console.WriteLine(i);
            }

        }
    }
}
//for 반복문으로 max값을 계속 갱신하면 되겠지만.. 이방법도 써보고 싶었음
//근데 이게 더 안좋은거같다
//int[] temp = array;
//Array.Sort(array);                
//answer[0] = array[array.Length - 1];
//answer[1] = Array.IndexOf(temp, answer[0]-1); // 뭐가 틀렸는지 나중에 봐보기

//return answer;