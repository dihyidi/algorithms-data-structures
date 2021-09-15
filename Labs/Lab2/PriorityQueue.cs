using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab2
{
    public class PriorityQueue<T> : IEnumerable<T>
    {
        public PriorityQueue(IComparer<T> comparer, int capacity = DefaultCapacity)
        {
            _heap = new T[capacity];
            _count = 0;
            _comparer = comparer;
        }
        
        public int Count => _count;

        public T Top
        {
            get
            {
                if (!_isHeap)
                {
                    Heapify();
                }
 
                return _heap[0];
            }
        }
 
        public void Push(T value)
        {
            if (_count == _heap.Length)
            {
                Array.Resize(ref _heap, _count * 2);
            }
 
            if (_isHeap)
            {
                SiftUp(_count, ref value, 0);
            }
            else
            {
                _heap[_count] = value;
            }
 
            _count++;
        }
 
        public void Pop()
        {
            if (!_isHeap)
            {
                Heapify();
            }

            if (_count <= 0) return;
            --_count;

            var x = _heap[_count];   
            var index = SiftDown(0); 
            SiftUp(index, ref x, 0); 
            _heap[_count] = default;
        }
 
        private int SiftDown(int index)
        {
            var parent = index;
            var leftChild = HeapLeftChild(parent);
 
            while (leftChild < _count)
            {
                var rightChild = HeapRightFromLeft(leftChild);
                var bestChild =
                    rightChild < _count && _comparer.Compare(_heap[rightChild], _heap[leftChild]) < 0 
                        ? rightChild 
                        : leftChild;
 
                _heap[parent] = _heap[bestChild];
 
                parent = bestChild;
                leftChild = HeapLeftChild(parent);
            }
 
            return parent;
        }
 
        private void SiftUp(int index, ref T x, int boundary)
        {
            while (index > boundary)
            {
                var parent = HeapParent(index);
                if (_comparer.Compare(_heap[parent], x) > 0)
                {
                    _heap[index] = _heap[parent];
                    index = parent;
                }
                else
                {
                    break;
                }
            }
            _heap[index] = x;
        }
        private void Heapify()
        {
            if (_isHeap) return;
            for (var i = _count/2 - 1; i >= 0; --i)
            {
                var x = _heap[i];
                var index = SiftDown(i);
                SiftUp(index, ref x, i);
            }
            _isHeap = true;
        }
 
        private static int HeapParent(int i)
        {
            return (i - 1) / 2;
        }
 
        private static int HeapLeftChild(int i)
        {
            return (i * 2) + 1;
        }
 
        private static int HeapRightFromLeft(int i)
        {
            return i + 1;
        }
 
        private T[] _heap;
        private int _count;
        private readonly IComparer<T> _comparer;
        private bool _isHeap;
        private const int DefaultCapacity = 6;

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)_heap).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}