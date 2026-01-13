using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.LinkedList
{
    class UserNode
    {
        public int UserId;
        public string Name;
        public int Age;


        public int[] FriendIds = new int[20]; 
        public int FriendCount = 0;

        public UserNode Next;

        public UserNode(int id, string name, int age)
        {
            UserId = id;
            Name = name;
            Age = age;
            Next = null;
        }
    }

    class SocialMediaLinkedList
    {
        private UserNode head;

        // Add new user
        public void AddUser(int id, string name, int age)
        {
            UserNode newUser = new UserNode(id, name, age);
            newUser.Next = head;
            head = newUser;
        }

        private UserNode FindUserById(int id)
        {
            UserNode temporaryTransversal = head;
            while (temporaryTransversal != null)
            {
                if (temporaryTransversal.UserId == id)
                    return temporaryTransversal;
                temporaryTransversal = temporaryTransversal.Next;
            }
            return null;
        }

        public void AddFriendConnection(int id1, int id2)
        {
            UserNode user1 = FindUserById(id1);
            UserNode user2 = FindUserById(id2);

            if (user1 == null || user2 == null)
            {
                Console.WriteLine("User not found.");
                return;
            }

            user1.FriendIds[user1.FriendCount++] = id2;
            user2.FriendIds[user2.FriendCount++] = id1;

            Console.WriteLine("Friend connection added.");
        }

        public void RemoveFriendConnection(int id1, int id2)
        {
            UserNode user1 = FindUserById(id1);
            UserNode user2 = FindUserById(id2);

            if (user1 == null || user2 == null)
            {
                Console.WriteLine("User not found.");
                return;
            }

            RemoveFriend(user1, id2);
            RemoveFriend(user2, id1);

            Console.WriteLine("Friend connection removed.");
        }

        private void RemoveFriend(UserNode user, int friendId)
        {
            for (int i = 0; i < user.FriendCount; i++)
            {
                if (user.FriendIds[i] == friendId)
                {
                    for (int j = i; j < user.FriendCount - 1; j++)
                        user.FriendIds[j] = user.FriendIds[j + 1];

                    user.FriendCount--;
                    return;
                }
            }
        }

        public void FindMutualFriends(int id1, int id2)
        {
            UserNode user1 = FindUserById(id1);
            UserNode user2 = FindUserById(id2);

            if (user1 == null || user2 == null)
            {
                Console.WriteLine("User not found.");
                return;
            }

            Console.WriteLine("Mutual Friends:");
            bool found = false;

            for (int i = 0; i < user1.FriendCount; i++)
            {
                for (int j = 0; j < user2.FriendCount; j++)
                {
                    if (user1.FriendIds[i] == user2.FriendIds[j])
                    {
                        Console.WriteLine("User ID: " + user1.FriendIds[i]);
                        found = true;
                    }
                }
            }

            if (!found)
                Console.WriteLine("No mutual friends.");
        }

        public void DisplayFriends(int id)
        {
            UserNode user = FindUserById(id);

            if (user == null)
            {
                Console.WriteLine("User not found.");
                return;
            }

            Console.WriteLine($"Friends of {user.Name}:");

            if (user.FriendCount == 0)
            {
                Console.WriteLine("No friends.");
                return;
            }

            for (int i = 0; i < user.FriendCount; i++)
                Console.WriteLine("Friend ID: " + user.FriendIds[i]);
        }

        public void SearchByUserId(int id)
        {
            UserNode user = FindUserById(id);

            if (user == null)
            {
                Console.WriteLine("User not found.");
                return;
            }

            DisplayUser(user);
        }

        public void SearchByName(string name)
        {
            UserNode temp = head;
            bool found = false;

            while (temp != null)
            {
                if (temp.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayUser(temp);
                    found = true;
                }
                temp = temp.Next;
            }

            if (!found)
                Console.WriteLine("User not found.");
        }

        public void CountFriendsForAllUsers()
        {
            UserNode temp = head;

            while (temp != null)
            {
                Console.WriteLine($"{temp.Name} has {temp.FriendCount} friends.");
                temp = temp.Next;
            }
        }

        private void DisplayUser(UserNode user)
        {
            Console.WriteLine(
                $"{user.UserId} | {user.Name} | Age: {user.Age} | Friends: {user.FriendCount}");
        }
    }

    class SocialMediaFriendsConnection
    {
        static void Main(string[] args)
        {
            SocialMediaLinkedList social = new SocialMediaLinkedList();

            social.AddUser(1, "Rama", 22);
            social.AddUser(2, "Priyanshu", 24);
            social.AddUser(3, "Gavendra", 23);
            social.AddUser(4, "Dev", 21);

            social.AddFriendConnection(1, 2);
            social.AddFriendConnection(1, 3);
            social.AddFriendConnection(2, 3);
            social.AddFriendConnection(3, 4);

            Console.WriteLine("Friends of User 1:");
            social.DisplayFriends(1);

            Console.WriteLine("Mutual Friends of 1 and 2:");
            social.FindMutualFriends(1, 2);

            Console.WriteLine("Search by Name:");
            social.SearchByName("Charlie");

            Console.WriteLine("Friend Count:");
            social.CountFriendsForAllUsers();

            Console.WriteLine("Removing Friend Connection (1 & 2):");
            social.RemoveFriendConnection(1, 2);

            social.DisplayFriends(1);
        }
    }
}
