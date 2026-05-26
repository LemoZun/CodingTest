using System.Reflection.Metadata.Ecma335;

namespace Test
{
    internal class Program
    {
        public struct Player
        {
            public string name;
            public int level;

            public Player(string name, int level)
            {
                this.name = name;
                this.level = level;
            }
        }

        List<Player> playerArr = new List<Player>()
        {
            new Player("Dave", 10),
            new Player("Mark", 15),
            new Player("Sarah", 20),
            new Player("Nom", 12),
            new Player("Avan", 18)

        };



        public class Solution1 // 속 빈 사각형 만들기
        {
            public void MakeBox(int weight, int height)
            {
                for(int i=1; i <= height; i++)
                {
                    Console.WriteLine();
                    for(int j=1; j <= weight; j++)
                    {
                        if (i == 1 || i == height)
                        {
                            Console.Write("*");
                            continue;
                        }

                        if(j == 1 || j == weight)
                        {
                            Console.Write("*");
                            continue;
                        }

                        Console.Write(" ");

                        /*
                         *   *****
                         *   *   *
                         *   *   *
                         *   *****
                         */
                        
                    }
                }
            }
        }

        public class Solution2 // 최댓값 최솟값 차이 출력
        {
            public int MakeMaxMin(int n)
            {
                int number = n;
                int max = int.MinValue;
                int min = int.MaxValue;
                int remainNum;

                while(number > 0)
                {
                    remainNum = number % 10;
                    number = number / 10;
                    if(remainNum > max)
                        max = remainNum;
                    if(remainNum < min)
                        min = remainNum;
                    //number = remainNum;
                }

                //Console.WriteLine($"{max - min}");
                return max - min;
            }
        }

        public class Solution3 // 소수찾기
        {
            public int SearchClosedPrime(int a, int b)
            {
                if (a > b)
                {
                    int temp = a;
                    a = b;
                    b = temp;
                }

                List<int> primes = new List<int>();
                for (int n = Math.Max(2, a); n <= b; n++)
                {
                    if(IsPrime(n))
                        primes.Add(n);
                }

                if (primes.Count == 0)
                    return -1;



                double mid = (a + b) / 2.0;

                while(primes.Count > 0)
                {
                    double minDistance = double.MaxValue;
                    foreach(int n in primes)
                    {
                        double d = Math.Abs(n - mid);
                        if(d < minDistance)
                            minDistance = d;
                    }

                    List<int> tied = new List<int>();
                    foreach(int p in primes)
                    {
                        if(Math.Abs(p - mid) == minDistance)
                            tied.Add(p);
                    }

                    if (tied.Count == 1)
                        return tied[0];

                    foreach(int p in  tied)
                        primes.Remove(p);
                }

                return -1;

                /*primes.Sort((p1, p2) =>
                {
                    double n1 = Math.Abs(p1 - mid);
                    double n2 = Math.Abs(p2 - mid);
                    int cmp = n1.CompareTo(n2);

                    if (cmp == 0)
                    {
                        primes.Remove(p1);
                        primes.Remove(p2);
                    }
                        

                    if (cmp != 0)
                        return cmp;

                    return p1.CompareTo(p2);

                });*/
/*
                float distance = float.MaxValue;
                int searchedPrime = 0;


                for(int i =0; i<primes.Count; i++)
                {
                    float tempDistance = MathF.Abs(mid - primes[i]);

                    if(tempDistance == distance)
                    {
                        primes.RemoveAt(i);
                        i = -1;
                        distance = float.MaxValue;
                        searchedPrime = -1;
                        continue;
                    }

                    if (tempDistance < distance)
                    {
                        distance = tempDistance;
                        searchedPrime = primes[i];
                    }
                }

                return searchedPrime;*/
                // 소수의 정의 : 1과 자기 자신만을 약수로 가지는 자연수
            }

            public bool IsPrime(int n)
            {
                if (n < 2)
                    return false;
                if (n % 2 == 0)
                    return n == 2;
                int r = (int)Math.Sqrt(n);
                for(int i = 3; i < r; i+=2)
                {
                    if (n % i == 0)
                        return false;                    
                }
                return true;
            }
        }

        public class Solution4 // 중간값 이진탐색
        {
            // 1 2 3 4 5 
            public int SearchTargetToBinary(int[] array, int target, int start, int end)
            {
                if(start > end)
                    return -1; // 못찾음

                int midIndex = start + (end - start) / 2;
                int mid = array[midIndex];

                if (mid == target)
                    return midIndex;
                else
                {
                    if(target < mid)
                        return SearchTargetToBinary(array, target, start, midIndex);
                    else
                        return SearchTargetToBinary(array, target, midIndex, end);
                }
            }

        }

        public class Solution5
        {

            public void SortArrayByName(List<Player> arr)
            {
                arr.Sort((p1,p2) =>  p1.name.CompareTo(p2.name));
            }
            
        }

        public class Solution6
        {
            public int SearchThree(int[] arr)
            {
                int count = 0;
                foreach (int i in arr)
                {
                    if (i % 10 == 3)
                    {
                        Console.WriteLine(i);
                    }

                    if (i % 3 == 0)
                        count++;
                }

                return count;
            }
        }

        public class Solution7 // 별찍기
        {
            public void PrintStar(int n)
            {
                for(int i = n; i > 0; i--)
                {
                    for(int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }

        public class Solution8
        {
            public int PrintMaxValue(int[] arr)
            {
                Array.Sort(arr);
                return arr[arr.Length - 1];
            }
        }

        public class Solution9
        {
            public float PrintAcc(float m, float s)
            {
                return m / s * s;
            }
        }



        private int Width = 5;
        private int Height = 4;
        private char star = '*';
        private char blank = ' ';
        static void Main(string[] args)
        {
            //Solution1 s = new Solution1();
            //s.MakeBox(5,4);
            //Solution2 s2 = new Solution2();
            //Console.WriteLine($"{s2.MakeMaxMin(35918)}");.

            //Solution3 s3 = new Solution3();
            //Console.WriteLine($"{s3.SearchClosedPrime(5, 20)}");

            //int[] intarr = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            //Solution4 s4 = new Solution4();
            //Console.WriteLine($"{s4.SearchTargetToBinary(intarr, 2, 0, intarr.Length)}");

            Solution7 s7 = new Solution7();
            s7.PrintStar(7);
        }
    }
}
