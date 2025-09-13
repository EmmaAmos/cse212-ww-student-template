using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue items and check if Dequeue returns the item with highest priority.
    // Expected Result: Dequeue should return the item with the highest priority.
    // Defect(s) Found: None
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("low", 1);
        priorityQueue.Enqueue("medium", 5);
        priorityQueue.Enqueue("high", 10);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("high", result);
    }

    [TestMethod]
    // Scenario: Dequeue from an empty queue should throw an exception.
    // Expected Result: InvalidOperationException is thrown.
    // Defect(s) Found: None
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.

    [TestMethod] //Emma added this test
    // Scenario: Enqueue multiple items with different priorities and check the order of Dequeue.
    // Expected Result: Dequeue should return items in order of their priority.
    // Defect(s) Found: None
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 5);
        priorityQueue.Enqueue("George", 2);

        Assert.AreEqual("Tim", priorityQueue.Dequeue());
        Assert.AreEqual("Sue", priorityQueue.Dequeue());
        Assert.AreEqual("Bob", priorityQueue.Dequeue());
        Assert.AreEqual("George", priorityQueue.Dequeue());
    }
}
//Emma:
//I've fixed what was wroung in the TakingTurnsQueue and PersonQueue files, so all tests in TakingTurnsQueue_Tests.cs are passing now.
//The problems were in the Dequeue method of PersonQueue.cs, which was implementing a LIFO behavior instead of FIFO, 
//and in the GetNextPerson method of TakingTurnsQueue.cs, which wasn't correctly handling the turns logic.
//All tests in PriorityQueue_Tests.cs are passing as well, and I added an extra test to check the order of Dequeue with multiple items of the same priority.