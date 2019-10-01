using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace SQAT_Assignment1
{
    public static class TriangleSolver
    {
        public static string Analyze(int integer1, int integer2, int integer3)
        {
            if (integer1 <= 0 || integer2 <= 0 || integer3 <= 0)
                return "Unable to form a triangle";
            else if ((integer1 == integer2 && integer1 != integer3) || (integer1 == integer3 && integer1 != integer2)
                || (integer2 == integer3 && integer2 != integer1))
                return "Isosceles triangle formed";
            else if (integer1 == integer2 && integer2 == integer3)
                return "Equilateral triangle formed";
            else if (integer1 != integer2 && integer2 != integer3 && integer3 != integer1)
                return "Scalene triangle formed";
            else
                return "Unable to form a triangle";
        }
    }

    [TestFixture]
    class TestCase
    {
        [TestCase]
        public void TestCase1()
        {
            Assert.AreEqual("Unable to form a triangle", TriangleSolver.Analyze(0, 0, 0));
        }

        [TestCase]
        public void TestCase2()
        {
            Assert.AreEqual("Isosceles triangle formed", TriangleSolver.Analyze(2, 2, 1));
        }

        [TestCase]
        public void TestCase3()
        {
            Assert.AreEqual("Equilateral triangle formed", TriangleSolver.Analyze(2, 2, 2));
        }

        [TestCase]
        public void TestCase4()
        {
            Assert.AreEqual("Scalene triangle formed", TriangleSolver.Analyze(2, 3, 5));
        }

        [TestCase]
        public void TestCase5()
        {
            Assert.AreEqual("Unable to form a triangle", TriangleSolver.Analyze(-1, -1, -1));
        }

        [TestCase]
        public void TestCase6()
        {
            Assert.AreEqual("Equilateral triangle formed", TriangleSolver.Analyze(5, 5, 5));
        }

        [TestCase]
        public void TestCase7()
        {
            Assert.AreEqual("Isosceles triangle formed", TriangleSolver.Analyze(5, 5, 4));
        }

        [TestCase]
        public void TestCase8()
        {
            Assert.AreEqual("Scalene triangle formed", TriangleSolver.Analyze(5, 6, 4));
        }
    }
}