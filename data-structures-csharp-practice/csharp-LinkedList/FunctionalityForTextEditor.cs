using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.LinkedList
{
    class TextStateNode
    {
        public string Content;
        public TextStateNode Prev;
        public TextStateNode Next;

        public TextStateNode(string content)
        {
            Content = content;
            Prev = null;
            Next = null;
        }
    }

    class TextEditor
    {
        private TextStateNode head;
        private TextStateNode tail;
        private TextStateNode current;

        private int maxHistory = 10;
        private int count = 0;

        public void AddNewState(string text)
        {
            TextStateNode newState = new TextStateNode(text);

            if (head == null)
            {
                head = tail = current = newState;
                count = 1;
                return;
            }

            if (current.Next != null)
            {
                current.Next.Prev = null;
                current.Next = null;
                tail = current;
            }

            tail.Next = newState;
            newState.Prev = tail;
            tail = newState;
            current = newState;
            count++;

            if (count > maxHistory)
            {
                head = head.Next;
                head.Prev = null;
                count--;
            }
        }

        public void Undo()
        {
            if (current == null || current.Prev == null)
            {
                Console.WriteLine("Nothing to undo.");
                return;
            }

            current = current.Prev;
        }

        public void Redo()
        {
            if (current == null || current.Next == null)
            {
                Console.WriteLine("Nothing left ");
                return;
            }

            current = current.Next;
        }

        // Display current text
        public void DisplayCurrentState()
        {
            if (current == null)
            {
                Console.WriteLine("empty.");
                return;
            }

            Console.WriteLine("Current Text: " + current.Content);
        }
    }

    class FunctionalityForTextEditor
    {
        static void Main(string[] args)
        {
            TextEditor editor = new TextEditor();

            editor.AddNewState("Hello");
            editor.AddNewState("Hello World");
            editor.AddNewState("Hello World!");
            editor.DisplayCurrentState();

            Console.WriteLine("Undo:");
            editor.Undo();
            editor.DisplayCurrentState();

            Console.WriteLine("Undo:");
            editor.Undo();
            editor.DisplayCurrentState();

            Console.WriteLine("Redo:");
            editor.Redo();
            editor.DisplayCurrentState();

            Console.WriteLine("Typing new text:");
            editor.AddNewState("Hello Everyone");
            editor.DisplayCurrentState();

            Console.WriteLine("Redo attempt:");
            editor.Redo();   
        }
    }
}
