using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following people and priority: Bob (2), Tim (1), Sue (4), Randy (5), Gina (3) and
    // run 2 times
    // Expected Result: "Sue"
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        //Assert.Fail("Implement the test case and then remove this.");



        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 1);
        priorityQueue.Enqueue("Sue", 4);
        priorityQueue.Enqueue("Randy", 5);
        priorityQueue.Enqueue("Gina", 3);

        string firstPerson = priorityQueue.Dequeue();

        string secondPerson = priorityQueue.Dequeue();


        Assert.AreEqual("Sue", secondPerson);

    }



    [TestMethod]
    // Scenario: Create a queue with the following people and priority: Bob (2), Tim (1), Sue (4), Randy (5), Gina (4) and
    // run 2 times
    // Expected Result: "Sue"
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        //Assert.Fail("Implement the test case and then remove this.");



        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 1);
        priorityQueue.Enqueue("Sue", 4);
        priorityQueue.Enqueue("Randy", 5);
        priorityQueue.Enqueue("Gina", 4);

        string firstPerson = priorityQueue.Dequeue();

        string secondPerson = priorityQueue.Dequeue();


        Assert.AreEqual("Sue", secondPerson);


    }




    // Add more test cases as needed below.


    [TestMethod]
    // Scenario: Don't add people to the queue. Test error message
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        //Assert.Fail("Implement the test case and then remove this.");
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
}