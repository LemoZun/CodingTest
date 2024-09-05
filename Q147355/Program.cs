namespace Q147355
{
    public class Program
    {
        public class Solution
        {
            public int solution(string t, string p)
            {
                int answer = 0;
                int pLength = p.Length;
                int tLength = t.Length;


                for (int i = 0; i < t.Length - p.Length + 1; i++)
                {
                    for (int j = 0; j < p.Length; j++)
                    {
                        if (t[i + j] > p[j])
                            break;

                        if (t[i + j] == p[j])
                        {
                            if (j == p.Length - 1)
                                answer++;

                        }
                        if (t[i + j] < p[j])
                        {
                            answer++;
                            break;
                        }
                    }
                }
                return answer;
            }
        }
    }
}
