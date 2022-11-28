/*
 Methods needed :
1. Clear
2. IsEmpty
3. PushBack
4. PushFront
5. PopBack
6. PopFront
7. Contains
8. peekFront
9. PeekBack

We will use a Doubly linked list as it will help with the O(1) implementation for push and pop operations both front and back ways

Back -> Ending of a List
Front -> Starting of a List.

 */

using System;

namespace Dequque_User
{
    public sealed class Dequeue
    {
        private DLLNode _head;
        private DLLNode _tail;
        public Dequeue()
        {
            _head = null;
            _tail = null;
        }
        public DLLNode PeekFront()
        {
            return _head;
        }
        public DLLNode PeekBack()
        {
            return _tail;
        }
        public void PushFront(int value)
        {
            DLLNode frontNode = new DLLNode(value);
            if(_head == null)
            {
                _head = _tail = frontNode;
            }
            else
            {
                frontNode.next = _head.next;
                _head.prev = frontNode;
                _head = frontNode;
            }
        }
        public void PushBack(int value)
        {
            DLLNode frontNode = new DLLNode(value);
            if (_tail == null)
            {
                _head = _tail = frontNode;
            }
            else
            {
                _tail.next = frontNode;
                frontNode.prev = _tail;
                _tail = frontNode;
            }
        }
        public void PopFront()
        {
            if (_head == null) return;
            if (_head.next == null)
            {
                _head = null;
                _tail = null;
            }
            else
            {
                var temp = _head.next;
                _head.next = null;
                _head.prev = null;
                _head = temp;
            }
        }
        public void PopBack()
        {
            if (_tail == null) return;
            if (_tail.prev == null)
            {
                _tail = null;
                _head = null;
            }
            else
            {
                var temp = _tail.prev;
                _tail.prev = null;
                _tail.next = null;
                _tail = temp;
            }
        }
        public bool Contains(DLLNode node)
        {
            throw new NotImplementedException();
        }
        public bool IsEmpty()
        {
            return _head == null;
        }
        public void Clear()
        {
            if (_head == null) return;
            
            while(!DLLNode.AreEqual(_head, _tail))
            {
                var temp = _head.next;
                _head.prev = null;
                _head.next = null;
                _head = temp;
            }
            _head = _tail = null;
        }
    }

    public sealed class DLLNode
    {
        public int val;
        public DLLNode next;
        public DLLNode prev;
        public DLLNode(int value)
        {
            val = value;
            next = null;
            prev = null;
        }

        public static bool AreEqual(DLLNode one, DLLNode two)
        {
            if (one == null && two != null) return false;
            if (one != null && two == null) return false;
            if (one == null && two == null) return true;
            if (one.val == two.val && one.next == two.next && one.prev == two.prev) return true;
            return false;
        }
    }
}
