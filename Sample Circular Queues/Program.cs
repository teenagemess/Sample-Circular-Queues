using System;

namespace CircularQueues_CSharp
{
    class Queues
    {
        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];
        public Queues()
        {
            //Initializing the values of the variables REAR and FRONT to indicate that the queue is initially empty
            FRONT = -1;
            REAR = -1;
        }
        public void insert(int element)
        {
            // This statement cchecks for the overflow condition.
            if ((FRONT == 0 && REAR == max - 1) || (FRONT == REAR + 1))

        }
    }
}