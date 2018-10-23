using System;
using Xunit;
using StackQueue.Classes;
using QueueWithStacks.Classes;

namespace QueueWithStacksTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests that nodes can be enqueued
        /// </summary>
        [Fact]
        public void CanEnqueueANode()
        {
            Node node1 = new Node(10);
            Node node2 = new Node(20);
            Node node3 = new Node(30);
            Node node4 = new Node(40);
            Node node5 = new Node(50);

            Stack stack1 = new Stack(null);
            Stack stack2 = new Stack(null);

            Cue queue = new Cue(stack1, stack2);

            queue.Enqueue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);
            queue.Enqueue(node4);
            queue.Enqueue(node5);

            Assert.Equal(node1.Value, queue.Dequeue().Value);
        }
        
        /// <summary>
        /// Tests that nodes can be dequeued
        /// </summary>
        [Fact]
        public void CanDequeueANode()
        {
            Node node1 = new Node(10);
            Node node2 = new Node(20);
            Node node3 = new Node(30);
            Node node4 = new Node(40);
            Node node5 = new Node(50);

            Stack stack1 = new Stack(null);
            Stack stack2 = new Stack(null);

            Cue queue = new Cue(stack1, stack2);

            queue.Enqueue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);
            queue.Enqueue(node4);
            queue.Enqueue(node5);

            queue.Dequeue();

            Assert.Equal(node2.Value, queue.Dequeue().Value);
        }
        
        /// <summary>
        /// Tests that code does not throw exception when dequeing a null stack
        /// </summary>
        [Fact]
        public void CanReturnNullFromEmptyStackDequeue()
        {
            Stack stack1 = new Stack(null);
            Stack stack2 = new Stack(null);

            Cue queue = new Cue(stack1, stack2);

            Assert.Null(queue.Dequeue());
        }

        /// <summary>
        /// Tests that node can be dequeued and then enqueued after
        /// </summary>
        [Fact]
        public void CanDequeueEnqueueNode()
        {
            Node node1 = new Node(10);
            Node node2 = new Node(20);
            Node node3 = new Node(30);
            Node node4 = new Node(40);
            Node node5 = new Node(50);

            Stack stack1 = new Stack(null);
            Stack stack2 = new Stack(null);

            Cue queue = new Cue(stack1, stack2);

            queue.Enqueue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);
            queue.Enqueue(node4);
            queue.Enqueue(node5);

            Node temp = queue.Dequeue();

            queue.Enqueue(temp);

            Assert.Equal(node2.Value, queue.Dequeue().Value);
        }
        
        /// <summary>
        /// Tests that only one node can be enqueued and then dequeued
        /// </summary>
        [Fact]
        public void CanDequeueEnqueueOnlyOneNode()
        {
            Node node1 = new Node(10);

            Stack stack1 = new Stack(null);
            Stack stack2 = new Stack(null);

            Cue queue = new Cue(stack1, stack2);

            queue.Enqueue(node1);

            Assert.Equal(node1.Value, queue.Dequeue().Value);
        }
        
        /// <summary>
        /// Tests that the queue can be dequeued twice in a row
        /// </summary>
        [Fact]
        public void CanDequeueTwiceInARow()
        {
            Node node1 = new Node(10);
            Node node2 = new Node(20);
            Node node3 = new Node(30);

            Stack stack1 = new Stack(null);
            Stack stack2 = new Stack(null);

            Cue queue = new Cue(stack1, stack2);

            queue.Enqueue(node1);
            queue.Enqueue(node2);
            queue.Enqueue(node3);

            queue.Dequeue();
            queue.Dequeue();

            Assert.Equal(node3.Value, queue.Dequeue().Value);
        }
    }
}
