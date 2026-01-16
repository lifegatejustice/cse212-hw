using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue one item and dequeue it.
    // Expected Result: Returns the enqueued item.
    // Defect(s) Found: No defects, test passes.
    public void TestPriorityQueue_SingleItem()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        var result = priorityQueue.Dequeue();
        Assert.AreEqual("A", result);
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with different priorities, dequeue should return the highest priority.
    // Expected Result: "C" (priority 3) is dequeued first.
    // Defect(s) Found: No defects, test passes.
    public void TestPriorityQueue_DifferentPriorities()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 3);
        var result = priorityQueue.Dequeue();
        Assert.AreEqual("C", result);
    }

    [TestMethod]
    // Scenario: Enqueue multiple items with same priority, dequeue should return the first enqueued.
    // Expected Result: "A" is dequeued first.
    // Defect(s) Found: No defects, test passes.
    public void TestPriorityQueue_SamePriority()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 1);
        priorityQueue.Enqueue("C", 1);
        var result = priorityQueue.Dequeue();
        Assert.AreEqual("A", result);
    }

    [TestMethod]
    // Scenario: Dequeue from empty queue.
    // Expected Result: InvalidOperationException with message "The queue is empty."
    // Defect(s) Found: 
    public void TestPriorityQueue_EmptyQueue()
    {
        var priorityQueue = new PriorityQueue();
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }

    [TestMethod]
    // Scenario: Enqueue items, dequeue multiple times.
    // Expected Result: Dequeue in priority order, with FIFO for same priority.
    // Defect(s) Found: No defects, test passes.
    public void TestPriorityQueue_MultipleDequeues()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("High", 3);
        priorityQueue.Enqueue("Medium", 2);
        priorityQueue.Enqueue("AnotherHigh", 3);

        // First dequeue: highest priority "High" or "AnotherHigh", but since same priority, first enqueued "High"
        var result1 = priorityQueue.Dequeue();
        Assert.AreEqual("High", result1);

        // Second: "AnotherHigh"
        var result2 = priorityQueue.Dequeue();
        Assert.AreEqual("AnotherHigh", result2);

        // Third: "Medium"
        var result3 = priorityQueue.Dequeue();
        Assert.AreEqual("Medium", result3);

        // Fourth: "Low"
        var result4 = priorityQueue.Dequeue();
        Assert.AreEqual("Low", result4);
    }

    // Add more test cases as needed below.
}