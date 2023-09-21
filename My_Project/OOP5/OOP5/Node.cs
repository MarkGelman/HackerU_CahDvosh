using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    class Node
    {
        int Data { get; set  }
        Node nodeNext;

        public Node(int data)
        {
            Data = data;
        }
    }
}
