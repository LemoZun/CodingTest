namespace Q12915
{
    public class Program
    {
        public class Solution
        {
            public string[] solution(string[] strings, int n)
            {
                // 커스텀 IComparer를 정의하여 정렬 기준을 설정
                Array.Sort(strings, new CustomComparer(n));
                return strings;
            }
        }

        // IComparer<T>를 구현하여 문자열 비교 방식을 정의
        public class CustomComparer : System.Collections.Generic.IComparer<string>
        {
            private readonly int _n;

            public CustomComparer(int n)
            {
                _n = n;
            }

            public int Compare(string x, string y)
            {
                // n번째 문자를 기준으로 비교
                int comparison = x[_n].CompareTo(y[_n]);

                // n번째 문자가 같을 경우 전체 문자열을 기준으로 비교
                if (comparison == 0)
                {
                    comparison = string.Compare(x, y, StringComparison.Ordinal);
                }

                return comparison;
            }
        }
        //public class Solution
        //{
        //    public string[] solution(string[] strings, int n)
        //    {
        //        //char[] standards = new char[strings.Length];

        //        //for (int i = 0; i < strings.Length; i++)
        //        //{
        //        //    standards[i] = (strings[i])[n];
        //        //} // 뽑아서 써먹을 방법이 애매함 할 수 있다고 해도 괜히 공간복잡도만 늘어남
        //        string temp;
        //        for (int i = 0; i < strings.Length; i++)
        //        {
        //            for (int j = i + 1; j < strings[i].Length; j++) // 앞에건 이미 비교했음
        //            {
        //                if (strings[i][n] > strings[j][n]) // 앞 문자열이 뒤로가야하면 
        //                {
        //                    temp = strings[j];
        //                    strings[j] = strings[i];
        //                    strings[i] = temp;
        //                }
        //                else if (strings[i][n] == strings[j][n]) // 문자열의 n번째가 같은 문자일경우
        //                {
        //                    for (int k = 0; k < strings[i].Length; k++)
        //                    {
        //                        if (strings[i][k] > strings[j][k])
        //                        {
        //                            temp = strings[j];
        //                            strings[j] = strings[i];
        //                            strings[i] = temp;
        //                            break;
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //        return strings;
        //    }
        //}
        static void Main(string[] args)
        {
            string[] temp = new string[] { "sun", "bed", "car" };
            string[] temp3 = { "abce", "abcd", "cdx" };
            Solution s = new Solution();
            string[] temp2 = s.solution(temp3, 2);

            foreach (string c in temp2)
            {
                Console.WriteLine($"{c}");
            }

        }
    }
}
// strings.OrderBy(x => x).OrderBy(x => x[n]); //string의 n번째 문자를 기준으로 정렬
// A.compareTo(B) A가 B보다 작으면 -1, 0이면 같음 B보다 크면 1
// Array.Sort(strings, standards); 이게 아님
//Array.Sort(array, (a,b) => (a>b) ? -1 : 1);
//a>b 이면 -1 아니면 1

