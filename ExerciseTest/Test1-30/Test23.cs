using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;
using System.Collections.Generic;

namespace ExerciseTest
{
    [TestClass]
    public class Test23
    {
        private ListNode generateList(List<int> nums)
        {
            var root = new ListNode(nums[0]);
            var temp = root;
            for (var i = 1; i < nums.Count; i++)
            {
                temp.next = new ListNode(nums[i]);
                temp = temp.next;
            }
            return root;
        }
        [TestMethod]
        public void Test23_1()
        {
            var sol = new _23MergeKSortedList();
            var root1 = generateList(new List<int> { 1,4,5});
            var root2 = generateList(new List<int> { 1,3,4});
            var root3 = generateList(new List<int> { 2,6});
            var lists = new List<ListNode>() { root1, root2, root3};
            var res = sol.MergeKLists(lists.ToArray());
            Assert.AreEqual(1, res.val);
        }
        [TestMethod]
        public void Test23_2()
        {
            var sol = new _23MergeKSortedList();
            var lists = new List<ListNode>() { };
            var res = sol.MergeKLists(lists.ToArray());
            Assert.AreEqual(0, res.val);
        }
        [TestMethod]
        public void Test23_3()
        {
            var sol = new _23MergeKSortedList();
            var lists = new List<ListNode>() { null, new ListNode(1)};
            var res = sol.MergeKLists(lists.ToArray());
            Assert.AreEqual(1, res.val);
        }
    }
}
