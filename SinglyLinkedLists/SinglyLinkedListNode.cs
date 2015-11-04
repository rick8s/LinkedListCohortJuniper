using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Stretch Goals: Using Generics, which would include implementing GetType() http://msdn.microsoft.com/en-us/library/system.object.gettype(v=vs.110).aspx
namespace SinglyLinkedLists
{
    public class SinglyLinkedListNode : IComparable
    {
        // Used by the visualizer.  Do not change.
        public static List<SinglyLinkedListNode> allNodes = new List<SinglyLinkedListNode>();

        // READ: http://msdn.microsoft.com/en-us/library/aa287786(v=vs.71).aspx
        private SinglyLinkedListNode next;
        public SinglyLinkedListNode Next
        {
       
            get { return next; }
            set {
                if (value == this)
                {
                    throw new ArgumentException();
                }
                next = value; } 
        }
    
        private string value;
        public string Value 
        {
            get { return value; }
            set { this.value = Value; }
        }

        public static bool operator <(SinglyLinkedListNode node1, SinglyLinkedListNode node2)
        {
            // This implementation is provided for your convenience.
            return node1.CompareTo(node2) < 0;
        }

        public static bool operator >(SinglyLinkedListNode node1, SinglyLinkedListNode node2)
        {
            // This implementation is provided for your convenience.
            return node1.CompareTo(node2) > 0;
        }

        public SinglyLinkedListNode(string value)
        {
            this.value = value;
            // Used by the visualizer:
            allNodes.Add(this);
        }

        public override string ToString()
        {
            return value;
        }

        // READ: http://msdn.microsoft.com/en-us/library/system.icomparable.compareto.aspx
        public int CompareTo(Object obj)
        {
            SinglyLinkedListNode nodeObj = obj as SinglyLinkedListNode;
            if (nodeObj == null)
            {
                return 1;
            }
           
            if (nodeObj != null)
            {
                return this.Value.CompareTo(nodeObj.Value);
            }

            throw new ArgumentException();
        }
        
         public override bool Equals(Object obj)
        {
            SinglyLinkedListNode nodeObj = obj as SinglyLinkedListNode;
            if (nodeObj != null)
            {
                return this.value.Equals(nodeObj.value);
           } 
         return false;
        }

        public override int GetHashCode()
        {
            return this.value.GetHashCode();
        }

        public bool IsLast()
        {
            if (this.Next == null)
            {
                return true;
            }
            return false;
        }
    }
}
