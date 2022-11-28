using System;

namespace Dequque_User
{
    class Program
    {
        static void Main(string[] args)
        {
            Dequeue dequeue = new Dequeue();
            dequeue.IsEmpty();
            dequeue.PushFront(5);
            dequeue.PushBack(10);
            dequeue.PushBack(11);
            dequeue.PushBack(12);
            dequeue.PushFront(6);
            dequeue.PushFront(7);
            dequeue.PushFront(8);
            dequeue.PopBack();
            dequeue.PopFront();
            dequeue.Clear();
        }
    }
}
