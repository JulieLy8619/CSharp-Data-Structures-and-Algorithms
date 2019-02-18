using System;
using Xunit;
using insertionSort;

namespace insertionSort_unittesting
{
    public class UnitTest1
    {
        //A randomly generated unsorted array returns the array sorted
        [Fact]
        public void TestHappyCase()
        {
            int[] testArray1 = new int[] { 7, 80, 12, 10, 4 };
            int[] testAnswer1 = new int[] { 4,7,10,12,80};
            int[] testResultArray1 = new int[testArray1.Length];
            testResultArray1 = Program.InsertionSort(testArray1);
            Assert.Equal(testAnswer1, testResultArray1);
        }

        //A sorted array returns the same sorted array
        [Fact]
        public void TestAlreadySorted()
        {
            int[] testArray2 = new int[] { 4, 7, 10, 12, 80 };
            int[] testAnswer2 = new int[] { 4, 7, 10, 12, 80 };
            int[] testResultArray2 = new int[testArray2.Length];
            testResultArray2 = Program.InsertionSort(testArray2);
            Assert.Equal(testAnswer2, testResultArray2);
        }

        //A backwards-sorted array returns the array sorted
        [Fact]
        public void TestReversedSorted()
        {
            int[] testArray3 = new int[] { 80,12,10,7,4 };
            int[] testAnswer3 = new int[] { 4, 7, 10, 12, 80 };
            int[] testResultArray3 = new int[testArray3.Length];
            testResultArray3 = Program.InsertionSort(testArray3);
            Assert.Equal(testAnswer3, testResultArray3);
        }

        //An empty array returns the same empty array
        [Fact]
        public void TestEmptyArray()
        {
            int[] testArray4 = new int[] {};
            int[] testAnswer4 = new int[] {};
            int[] testResultArray4 = new int[testArray4.Length];
            testResultArray4 = Program.InsertionSort(testArray4);
            Assert.Equal(testAnswer4, testResultArray4);
        }

        //An array of one element returns the same single-element array
        [Fact]
        public void TestSoloArray()
        {
            int[] testArray5 = new int[] { 10 };
            int[] testAnswer5 = new int[] {10};
            int[] testResultArray5 = new int[testArray5.Length];
            testResultArray5 = Program.InsertionSort(testArray5);
            Assert.Equal(testAnswer5, testResultArray5);
        }

        //add test for if have neg numbers
        [Fact]
        public void TestNegArray()
        {
            int[] testArray6 = new int[] { -5, 1, 20, -50 };
            int[] testAnswer6 = new int[] { -50,-5,1,20 };
            int[] testResultArray6 = new int[testArray6.Length];
            testResultArray6 = Program.InsertionSort(testArray6);
            Assert.Equal(testAnswer6, testResultArray6);
        }

        //add test for if has duplicate
        [Fact]
        public void TestDuplicateArray()
        {
            int[] testArray7 = new int[] { 1,1,1,1,2};
            int[] testAnswer7 = new int[] { 1, 1, 1, 1, 2 };
            int[] testResultArray7 = new int[testArray7.Length];
            testResultArray7 = Program.InsertionSort(testArray7);
            Assert.Equal(testAnswer7, testResultArray7);
        }

    }
}

