namespace TestCustomList
{
    using System;
    using CustomLinkedList;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DynamicListTest
    {
        [TestMethod]
        public void TestGetter_SingleElement_ElementsAreEqual()
        {
            DynamicList<int> customList = new DynamicList<int>();
            customList.Add(50);
            int firstElement = customList[0];

            Assert.AreEqual(50, firstElement, "Getter failed: The element should be 50.");
        }

        [TestMethod]
        public void TestSetter_SingleElement_ElementsAreEqual()
        {
            DynamicList<int> customList = new DynamicList<int>();
            customList.Add(50);
            customList[0] = 25;
            int firstElement = customList[0];

            Assert.AreEqual(25, firstElement, "Setter failed: The element should be 25.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGetter_SingleElement_ArgumentOutOfRangeException()
        {
            DynamicList<int> customList = new DynamicList<int>();
            int element = customList[0];
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSetter_SingleElement_ArgumentOutOfRangeException()
        {
            DynamicList<int> customList = new DynamicList<int> {[0] = 20};
        }

        [TestMethod]
        public void TestAddMethod_SingleElement_ElementsAreEqual()
        {
            DynamicList<int> customList = new DynamicList<int>();
            customList.Add(200);
            int element = customList[0];

            Assert.AreEqual(200, element, "Adding failed: The element should be 200.");
        }

        [TestMethod]
        public void TestRemoveAtMethod_SingleElement_ElementsAreEqual()
        {
            DynamicList<int> customList = new DynamicList<int>();
            customList.Add(500);
            int element = customList.RemoveAt(0);

            Assert.AreEqual(500, element, "Returning the removed element failed: The removed element should be 500.");
        }

        [TestMethod]
        public void TestRemoveAtMethod_SingleElement_TheCountHasChanged()
        {
            DynamicList<int> customList = new DynamicList<int>();
            customList.Add(500);
            customList.RemoveAt(0);
            int count = customList.Count;

            Assert.AreEqual(0, count, "Removing failed: The count should be zero.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRemoveAtMethod_SingleElement_ArgumentOutOfRangeException()
        {
            DynamicList<int> customList = new DynamicList<int>();
            customList.RemoveAt(50);
        }

        [TestMethod]
        public void TestRemoveMethod_SingleElement_TheItemHasBeenRemoved()
        {
            DynamicList<int> customList = new DynamicList<int>();
            customList.Add(33);
            int index = customList.Remove(33);

            Assert.AreEqual(0, index, "Removing failed: The index should be zero.");
        }

        [TestMethod]
        public void TestRemoveMethod_NoElements_TheItemWasNotFound()
        {
            DynamicList<int> customList = new DynamicList<int>();
            int index = customList.Remove(6);

            Assert.AreEqual(-1, index,"Removing failed: The index should be -1.");
        }

        [TestMethod]
        public void TestIndexOfMethod_SeveralElements_TheIndexHasBeenFound()
        {
            DynamicList<int> customList = new DynamicList<int>();
            for (int num = 0; num <= 50; num++)
            {
                customList.Add(num);
            }

            int index = customList.IndexOf(49);

            Assert.AreEqual(49, index, "Index of failed: The index should be 49.");
        }

        [TestMethod]
        public void TestIndexOfMethod_NoElements_TheIndexWasNotFound()
        {
            DynamicList<int> customList = new DynamicList<int>();
            int index = customList.IndexOf(50);

            Assert.AreEqual(-1, index, "Index of failed: The index should be -1.");
        }

        [TestMethod]
        public void TestContainsElement_SingleElement_TheListContainsTheElement()
        {
            DynamicList<int> customList = new DynamicList<int>();
            customList.Add(50);
            bool containsElement = customList.Contains(50);

            Assert.IsTrue(containsElement, "Contains method failed: It should be true.");
        }
    }
}
