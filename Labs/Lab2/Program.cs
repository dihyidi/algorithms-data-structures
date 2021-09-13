using System;
using System.Collections.Generic;

namespace Lab2
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var pq = new PriorityQueue<User>(new UserComparer());
            pq.Push(new User(2,"user1"));
            pq.Push(new User(1,"user1"));
            pq.Push(new User(6,"user1"));
            pq.Push(new User(0,"user1"));
            pq.Push(new User(3,"user1"));
            pq.Push(new User(5,"user1"));
            pq.Push(new User(7,"user1"));
            pq.Push(new User(9,"user1"));
            pq.Push(new User(4,"user1"));
            pq.Push(new User(8,"user1"));
            
            pq.Pop();

            var top = pq.Top;
        }
        
        public class User
        {
            public User(int priority, string name)
            {
                Priority = priority;
                Name = name;
            }

            public int Priority { get; }
            public string Name { get; }
        }

        public class UserComparer : IComparer<User>
        {
            public int Compare(User x, User y)
            {
                if (x == null) return 0;
                return y != null 
                    ? x.Priority.CompareTo(y.Priority) 
                    : 0;
            }
        }
    }
}