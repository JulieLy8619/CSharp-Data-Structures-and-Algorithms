using System;
using Xunit;
using BinarySearch;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestBinarySearchWorks()
        {
            int[] arr1 = new int[] { 1, 2, 3, 4 };
            Assert.Equal(1, Program.BinarySearch(arr1,3));
        }
        [Fact]
        public void TestBinarySearchNotWorks()
        {
            int[] arr2 = new int[] {2,4,6,8};
            Assert.NotEqual(10, Program.BinarySearch(arr2, 3));
        }
    }
}
