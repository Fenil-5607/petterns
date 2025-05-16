using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petterns
{
    class RightHalfPyramid
    {
        public void pattern1(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
              
        public void pattern2(int n) 
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i + 1; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }

        public void pattern3(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n-i+1; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

        }

        public void pattern4(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void pattern5(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public void pattern6(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        public void pattern7(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                var character = 'A';
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(character);
                    character++;
                }
                Console.WriteLine();
            }
        }

        public void pattern8(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                var character = 'A';
                for (int j = 1; j <= n - i + 1; j++)
                {
                    Console.Write(character);
                    character++;
                }
                Console.WriteLine();
            }
        }
    }


    class LeftHalfPyramid
    {
        public void pattern1(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void pattern2(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public void pattern3(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        public void pattern8(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                var character = 'A';
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(character);
                    character++;
                }
                Console.WriteLine();
            }
        }

        public void pattern4(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= n - i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void pattern5(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= n - i + 1; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        public void pattern6(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= n - i + 1; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public void pattern7(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }

                var character = 'A';
                for (int j = 1; j <= n - i + 1; j++)
                {
                    Console.Write(character);
                    character++;
                }
                Console.WriteLine();
            }
        }
    }

    class Pyramid
    {
        public void pattern1(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void pattern2(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        public void pattern3(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public void pattern4(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                var character = 'A';
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write(character);
                    character++;
                }
                Console.WriteLine();
            }
        }

    }

    class RevercePyramid 
    {
        public void pattern1(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2 * (n - i + 1) - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void pattern2(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2 * (n - i + 1) - 1; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        public void pattern3(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2 * (n - i + 1) - 1; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public void pattern4(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }

                var character = 'A';
                for (int j = 1; j <= 2 * (n - i) + 1; j++)
                {
                    Console.Write(character);
                    character++;
                }
                Console.WriteLine();
            }
        }
    }

    class RhombusPattern
    {
        public void pattern1(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= n; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public void pattern2(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= n; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        public void pattern3(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= n; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public void pattern4(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }

                var character = 'A';
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(character);
                    character++;
                }
                Console.WriteLine();
            }
        }
    }

    class PyramidWithSpace 
    {
        public void pattern1(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i-1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= n - i + 1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public void pattern2(int n) 
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public void pattern3(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
        }

        public void pattern4(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }

    class TwoSidePyramid 
    {
        public void pattern1(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= n - i + 1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public void pattern2(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= n - i + 1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public void pattern3(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= n - i + 1; j++)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
        }

        public void pattern4(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= n - i + 1; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        public void pattern5(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                var character = 'A';
                for (int j = 1; j <=2 * i-1; j++)
                {
                    Console.Write(character);
                    character++;
                }
                Console.WriteLine();
            }
            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }

                var character = 'A';
                for (int j = 1; j <= 2 * (n - i + 1)-1; j++)
                {
                    Console.Write(character);
                    character++;
                }
                Console.WriteLine();
            }
        }

        public void pattern6(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }

                var character = 'A';
                for (int j = 1; j <= 2 * (n - i + 1) - 1; j++)
                {
                    Console.Write(character);
                    character++;
                }
                Console.WriteLine();
            }
            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                var character = 'A';
                for (int j = 1; j <=2 * i - 1; j++)
                {
                    Console.Write(character);
                    character++;
                }
                Console.WriteLine();
            }
        }

        public void pattern7(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2 * (n - i + 1) - 1; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write((n-i)+1);
                }
                Console.WriteLine();
            }
        }

        public void pattern8(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2 * (n - i + 1) - 1; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
       

    }

    class HollowPattern
    {
        public void pattern1(int n)
        { 
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if(i == 1 || i == n || j == 1 || j == n)
                        Console.Write("*");
                    else
                      Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public void pattern2(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    if(j == 1 || j == 2 * i - 1 || i == n)
                         Console.Write("*");
                    else
                        Console.Write(" ");
                }

               
                Console.WriteLine();
            }
        }
        public void pattern3(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < 2 * (n - i) - 1; j++)
                {
                    if (j == 0 || j == 2 * (n - i) - 2 || i == 0)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }

                Console.WriteLine();
        
            }
        }

    }

    class FloydsTriangle 
    {
        public void pattern1(int n)
        {
            var number = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number+" ");
                    number++;
                }
                Console.WriteLine();
            }
        }
    }

    class PascalsTriangle
    {
        public void pattern1(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int number = 1;

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number + "   ");
                    number = number * (i - j) / j;
                }
                Console.WriteLine();
            }
        }

        public void pattern2(int n)
        {
            int rows = 5;
            int[,] triangle = new int[rows, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                        triangle[i, j] = 1;
                    else
                           triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];

                    Console.Write(triangle[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the rows: ");
            int n=Convert.ToInt32(Console.ReadLine());

            RightHalfPyramid rightHalfPyramid = new RightHalfPyramid();

            Console.WriteLine("pattern1");
            rightHalfPyramid.pattern1(n);
            Console.WriteLine("pattern2");
            rightHalfPyramid.pattern2(n);
            Console.WriteLine("pattern3");
            rightHalfPyramid.pattern3(n);
            Console.WriteLine("pattern8");
            rightHalfPyramid.pattern8(n);
            Console.WriteLine("pattern4");
            rightHalfPyramid.pattern4(n);
            Console.WriteLine("pattern5");
            rightHalfPyramid.pattern5(n);
            Console.WriteLine("pattern6");
            rightHalfPyramid.pattern6(n);
            Console.WriteLine("pattern7");
            rightHalfPyramid.pattern7(n);
            

            LeftHalfPyramid leftHalfPyramid = new LeftHalfPyramid();

            Console.WriteLine("pattern1");
            leftHalfPyramid.pattern1(n);
            Console.WriteLine("pattern2");
            leftHalfPyramid.pattern2(n);
            Console.WriteLine("pattern3");
            leftHalfPyramid.pattern3(n);
            Console.WriteLine("pattern8");
            leftHalfPyramid.pattern8(n);
            Console.WriteLine("pattern4");
            leftHalfPyramid.pattern4(n);
            Console.WriteLine("pattern5");
            leftHalfPyramid.pattern5(n);
            Console.WriteLine("pattern6");
            leftHalfPyramid.pattern6(n);
            Console.WriteLine("pattern7");
            leftHalfPyramid.pattern7(n);


            Pyramid pyramid = new Pyramid();

            Console.WriteLine("pattern1");
            pyramid.pattern1(n);
            Console.WriteLine("pattern2");
            pyramid.pattern2(n);
            Console.WriteLine("pattern3");
            pyramid.pattern3(n);
            Console.WriteLine("pattern4");
            pyramid.pattern4(n);


            RevercePyramid revercePyramid = new RevercePyramid();

            Console.WriteLine("pattern1");
            revercePyramid.pattern1(n);
            Console.WriteLine("pattern2");
            revercePyramid.pattern2(n);
            Console.WriteLine("pattern3");
            revercePyramid.pattern3(n);
            Console.WriteLine("pattern4");
            revercePyramid.pattern4(n);

            RhombusPattern rhombusPattern = new RhombusPattern();

            Console.WriteLine("pattern1");
            rhombusPattern.pattern1(n);
            Console.WriteLine("pattern2");
            rhombusPattern.pattern2(n);
            Console.WriteLine("pattern3");
            rhombusPattern.pattern3(n);
            Console.WriteLine("pattern4");
            rhombusPattern.pattern4(n);

            PyramidWithSpace pyramidWithSpace = new PyramidWithSpace();

            Console.WriteLine("pattern1");
            pyramidWithSpace.pattern1(n);
            Console.WriteLine("pattern2");
            pyramidWithSpace.pattern2(n);
            Console.WriteLine("pattern3");
            pyramidWithSpace.pattern3(n);
            Console.WriteLine("pattern4");
            pyramidWithSpace.pattern4(n);

            TwoSidePyramid twoSidePyramid = new TwoSidePyramid();

            Console.WriteLine("pattern1");
            twoSidePyramid.pattern1(n);
            Console.WriteLine("pattern2");
            twoSidePyramid.pattern2(n);
            Console.WriteLine("pattern3");
            twoSidePyramid.pattern3(n);
            Console.WriteLine("pattern4");
            twoSidePyramid.pattern4(n);
            Console.WriteLine("pattern5");
            twoSidePyramid.pattern5(n);
            Console.WriteLine("pattern6");
            twoSidePyramid.pattern6(n);
            Console.WriteLine("pattern7");
            twoSidePyramid.pattern7(n);
            Console.WriteLine("pattern8");
            twoSidePyramid.pattern8(n);

            HollowPattern hollowPattern = new HollowPattern();

            Console.WriteLine("pattern1");
            hollowPattern.pattern1(n);
            Console.WriteLine("pattern2");
            hollowPattern.pattern2(n);
            Console.WriteLine("pattern3");
            hollowPattern.pattern3(n);

            FloydsTriangle floydsTriangle = new FloydsTriangle();

            Console.WriteLine("pattern1");
            floydsTriangle.pattern1(n);

            PascalsTriangle pascalsTriangle = new PascalsTriangle();

            Console.WriteLine("pattern1");
            pascalsTriangle.pattern1(n);
            Console.WriteLine("pattern2");
            pascalsTriangle.pattern2(n);
        }
    }
}
