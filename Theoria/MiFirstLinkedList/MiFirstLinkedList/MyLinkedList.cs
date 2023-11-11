using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiFirstLinkedList
{
    class MyLinkedList<T>
    {
        public Node<T> Heade { get; private set; }
        
        public void Add (T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (Heade == null)
                Heade = newNode;
            else
            {

                Node <T> current = Heade.Next;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Value = value;
            }

        }

        public bool Remove (T value)
        {
            Node<T> current = Heade;
            Node<T> previouse = null;
            while (current != null)
            {
                if (Equals(current.Value, value))
                {
                    if (previouse == null)
                    {
                        Heade = Heade.Next;
                    }
                    previouse.Next = current.Next;
                    return true;
                }
                previouse = current;
                current = current.Next;
            }
            return false;
        }

        public bool Contains (T value)
        {
            Node<T> current = Heade;
            while (current != null)
            {
                if (Equals(current.Value, value))
                    return true;
                current = current.Next;
            }

            return false;
        }

        public void InsertAt ( T value, int index)
        {
            Node<T> newNode = new Node<T>(value);
            if (index == 0) 
            {
                newNode.Next = Heade;
                Heade = newNode;
            }
            else
            {

                Node<T> current = Heade;
                Node<T> previouse = null;
            
                for (int i=0; i < index; i++)
                {
                    previouse = current;
                    current = current.Next;
                }

                previouse.Next = newNode;
                newNode.Next = current;
            }

        }

        public void PrintList ()
        {
            Node<T> current = Heade;
            while (current.Next != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }
    }
}
