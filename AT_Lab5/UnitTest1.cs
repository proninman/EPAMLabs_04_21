using NUnit.Framework;
using System;

namespace AT_Lab5
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_S2_Rect()
        {
            for (int i = 0; i < 21; i++)
            {
                for (int j=0; j<21; j++)
                {
                   Warn.If((i * j) != GeometricFigures.Rectangle.GetArea(i, j), $" Исключение при i={i} j={j}");
                    ;
                }
            }
            
        }
        [Test]
        public void Test_L_Rect()
        {
            for (double i = 0; i < 21; i++)
            {
                for (double j = 0; j < 21; j++)
                {
                 Warn.If(2*((i + j)) != GeometricFigures.Rectangle.GetLength(i, j), $" Исключение при i={i} j={j}");
                }
            }
            
        }
        [Test]
        public void Test_S2_Tria()
        {
            for (double k = 0; k < 21; k++)
            {
                for (double i = 0; i < 21; i++)
                {
                    for (double j = 0; j < 21; j++)
                    {
                        if ((k > (i + j)) | (i > (k + j)) | (j > (i + k)))
                        {
                            continue;
                        }
                        double pper = (j + i + k) * 0.5;
                        Warn.If( Math.Sqrt ( pper*(pper-j)*(pper - i) * (pper - k)) != GeometricFigures.Triangle.GetArea(i,j,k), $" Исключение при i={i} j={j} k={k }");
                        
                    }
                }
            }
        }

        [Test]
        
        public void Test1TriaTrue()
        {
            Assert.Ignore();
            double k = 1;
            double i = 4;
            double j = 3;
            double pper = (j + i + k) * 0.5;
            Warn.If(Math.Sqrt(pper * (pper - j) * (pper - i) * (pper - k)) != GeometricFigures.Triangle.GetArea(i, j, k), $" Исключение при i={i} j={j} k={k }");
            Assert.AreEqual(Math.Sqrt(pper * (pper - j) * (pper - i) * (pper - k)) , GeometricFigures.Triangle.GetArea(i, j, k), $" Исключение при i={i} j={j} k={k }");
        }

        [Test]
        public void Test_L_Tria()
        {
            for (double k = 0; k < 21; k++)
            {
                for (double i = 0; i < 21; i++)
                {
                    for (double j = 0; j < 21; j++)
                    {
                        if ((k > (i + j)) | (i > (k + j ))|( j > (i + k)))
                        {
                            continue;
                        }
                        double per = (j + i + k);
                        Warn.If(per!= GeometricFigures.Triangle.GetLength(i, j, k), $" Исключение при i={i} j={j} k={k }");
                        
                    }
                }
            }
        }

        [Test]
        public void Test_S2_Sqr()
        {
            for (int i = 0; i < 21; i++)
            {
              Warn.If((i * i) != GeometricFigures.Square.GetArea(i), $" Исключение при i={i}");
            }
            
        }
        [Test]
        public void Test_L_Sqr()
        {
            for (double i = 0; i < 21; i++)
            {
                Warn.If((i * 4) != GeometricFigures.Square.GetLength(i), $" Исключение при i={i}");
            }

        }

    }
}