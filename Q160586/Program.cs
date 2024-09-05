namespace Q160586
{
    internal class Program
    {
        /// <summary>
        /// 대충 만든 자판 Q160586
        /// https://school.programmers.co.kr/learn/courses/30/lessons/160586
        /// </summary>
        /// <param name="args"></param>
        /// 
        public class Solution
        {
            public int[] solution(string[] keymap, string[] targets)
            {
                int[] answer = new int[] { };

                int count = 0;

                for (int i=0; i < targets.Length; i++)
                {
                    for(int j=0; j < keymap.Length; j++)
                    {
                        if(keymap[j] == targets[i])
                        {

                            count++;
                            break;
                        }
                        else
                        {
                            count++;
                            if (j == keymap.Length)
                            {
                                answer[i] = -1;
                            }
                                
                        }

                    }
                }

                return answer;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
