namespace CodingTestNoob

{
    internal class Program

    {
        static int Solution1(int num1, int num2)
        {
            int answer = num1 + num2;
            return answer;
        }
        static int Solution2(int num1, int num2)
        {
            int answer = num1 - num2;
            return answer;
        }
        static int Solution3(int num1, int num2)
        {
            int answer = num1 * num2;
            return answer;
        }
        static int Solution4(int num1, int num2)
        {
            int answer = num1 / num2;
            return answer;
        }
        static decimal Solution5(int num1, int num2)
        {
            return (int)((float)num1 / num2 * 1000);
            //return 1000*num1/num2;
        }
        static int solution6(int num1, int num2)
        {
            int answer;
            if (num1 == num2) return answer = 1;
            else return answer = -1;
        }
        /*
        static int[] solution(int numer1, int denom1, int numer2, int denom2)
        {
            int min = gcd(denom1, denom2);
            int max = (denom1 * denom2) / min;

            int[] answer = new int[2];
            if(denom1 != max)
            {
                denom1 = max;
                numer1 = numer1 * (max / denom1);
            }
            if (denom2 != max)
            {
                denom2 = max;
                numer2 = numer2 * (max/denom2);
            }
            answer = [ min * (numer1 + numer2),max];
            //{numer1 * denom2 + numer2 * denom1, denom1 * denom2};

            static int gcd(int x, int y)
            {
                return (x % y == 0 ? y : gcd(y, x % y));
            }


            return answer;
        }
        */

        public int[] solution7(int numer1, int denom1, int numer2, int denom2)
        {

            // 두 분모의 최소공배수 계산
            int lcm = Lcm(denom1, denom2);

            // 두 분수를 공통 분모로 변환
            int newNumer1 = numer1 * (lcm / denom1);
            int newNumer2 = numer2 * (lcm / denom2);

            // 새로운 분자로 덧셈
            int finalNumerator = newNumer1 + newNumer2;
            int finalDenominator = lcm;

            // 결과를 기약분수로 변환
            int gcd = Gcd(finalNumerator, finalDenominator);
            finalNumerator /= gcd;
            finalDenominator /= gcd;

            return new int[] { finalNumerator, finalDenominator };


        }
        private int Gcd(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        private int Lcm(int a, int b)
        {
            return (a * b) / Gcd(a, b);
        }
        /// <summary>
        /// 배열 두배 만들기
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        static int[] solution8(int[] numbers)
        {
            int[] answer = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                answer[i] = numbers[i] * 2;
            }
            return answer;
        }
        /// <summary>
        /// 나머지 구하기
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        static int solution9(int num1, int num2)
        {
            int answer = num1 % num2;
            return answer;
        }
        /// <summary>
        /// 중앙값 구하기
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int solution10(int[] array)
        {
            int answer;
            Array.Sort(array);
            int middle = array.Length / 2;
            return answer = array[middle]; ;
        }

        static void Main(string[] args)
        {

        }
    }
}
