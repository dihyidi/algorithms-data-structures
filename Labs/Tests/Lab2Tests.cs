using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Lab2;
using Xunit;

namespace Tests
{
    public class Lab2Tests
    {
        [Fact]
        public void Top_ReturnsMaxPriorityItem()
        {
            //Arrange
            var pq = SetupQueue();
            var expected = new User(0, "user0");

            //Act
            var actual = pq.Top;

            //Assert
            Assert.Equal(expected, actual);
        }

        private static PriorityQueue<User> SetupQueue()
        {
            var pq = new PriorityQueue<User>(new UserComparer());
            pq.Push(new User(2,"user2"));
            pq.Push(new User(1,"user1"));
            pq.Push(new User(6,"user6"));
            pq.Push(new User(0,"user0"));
            pq.Push(new User(3,"user3"));
            pq.Push(new User(5,"user5"));
            pq.Push(new User(7,"user7"));
            pq.Push(new User(9,"user9"));
            pq.Push(new User(4,"user4"));
            pq.Push(new User(8,"user8"));

            return pq;
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