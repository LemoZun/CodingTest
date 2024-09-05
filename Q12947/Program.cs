namespace Q12947
{
    public class Program
    {
        /// <summary>
        /// 하샤드 수 Q12947
        /// https://school.programmers.co.kr/learn/courses/30/lessons/12947
        /// </summary>
        public class Solution
        {
            public bool solution(int x)
            {
                //string으로 바꿔서 인덱스로 합해도 되고
                // 나머지 연산으로 해도 됨 

                string y = x.ToString();               
                int sum = 0;
                foreach (char digit in y)
                {
                    sum += (digit - '0');                    
                }                
                if (x % sum == 0)
                    return true;
                else return false;
            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.WriteLine( s.solution(12));
        }
    }
}
