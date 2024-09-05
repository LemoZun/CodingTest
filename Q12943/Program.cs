namespace Q12943
{
    public class Program
    {
        /// <summary>
        /// 콜라츠 추측 Q12943
        /// https://school.programmers.co.kr/learn/courses/30/lessons/12943
        /// </summary>
        public class Solution
        {
            int count = 0;
            public int solution(long num)
            {

                if (num == 1)
                    return count;
                else if (count == 500)
                    return -1;

                if (num % 2 == 0)
                {
                    count++;
                    return solution(num / 2);
                }
                else
                {
                    count++;
                    return solution(num * 3 + 1);
                }
            }
        } 

        static void Main()
        {
            Solution solution = new Solution();

            Console.WriteLine(solution.solution(626331));
        }
    }
}

// 3번 테스트케이스에서 오류
// int num을 long num으로 바꿔 해결
// int 타입 정수값 범위 오류?

