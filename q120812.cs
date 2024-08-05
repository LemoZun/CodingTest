namespace CodingTest
{
    public class q120812
    {
        public class Solution
        {

            /// <summary>
            /// 최빈값 구하기
            /// https://school.programmers.co.kr/learn/courses/30/lessons/120812
            /// </summary>
            /// <param name="array"></param>
            /// <returns></returns>
            public int solution(int[] array)
            {
                

                
                if (array.Length == 0) return -1;
                Array.Sort(array);

                int maxCount = 1;
                int mode = array[0];
                int currentCount = 1;
                bool duplication = false;

                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] == array[i - 1])
                    {
                        currentCount++;
                    }
                    else
                    {
                        if(currentCount >maxCount)
                        {
                            maxCount = currentCount;
                            mode = array[i-1];
                            duplication = false;
                        }
                        else if(currentCount == maxCount)
                        {
                            duplication = true;
                        }
                        currentCount = 1;
                    }
                }

                if(currentCount > maxCount)
                {
                    maxCount = currentCount;
                    mode = array[array.Length - 1];
                    duplication = false;
                }
                else if(currentCount == maxCount)
                    duplication = true;

                return duplication ? -1 : mode;

                /*
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] == array[j])
                        {
                            currentCount++;
                        }
                        else break;


                    }
                    i += currentCount;
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        mode = array[i];
                        currentCount = 0;
                    }
                }
                if (currentCount == maxCount) return -1;
                else return mode;
                */
            }

        }



        static void Main()
        {
            int[] array = {1};
            Solution solution = new Solution();
            Console.WriteLine(solution.solution(array));
        }
    }
    
}
