namespace Q120821
{
    internal class Program
    {
        public class Solution
        {
            public int[] solution(int[] num_list)
            {
                int size = num_list.Length;
                int[] answer = new int[size];

                for (int i = 0; i < num_list.Length; i++)
                {
                    answer[i] = num_list[num_list.Length-i-1];
                }

                return answer;
            }
        }

        static void Main(string[] args)
        {
            int[] temp = new int[] { 5, 4, 3, 2, 1 };

            Solution solution = new Solution();
            solution.solution(temp);

            foreach (int i in temp)
            {

                Console.WriteLine(i);
            }
            
        }
    }
}
