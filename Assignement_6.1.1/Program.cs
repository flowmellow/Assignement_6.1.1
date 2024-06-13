/*
1. Implement a single linked list with each node representing a house. 
You may add data in it like house number, brief address, type of house ( like Ranch, Colonial) . 
each house (node) will be linked to next . Give facility to the user to 
search a house by its number and then display the details. ( Windows / Console)
*/


using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Assignement_6._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList singleLinkedList = new SingleLinkedList();
            singleLinkedList.AddNodeToFront(5);
            singleLinkedList.AddNodeToFront(6);
            singleLinkedList.AddNodeToFront(7);
            singleLinkedList.AddNodeToFront(8);
            singleLinkedList.AddNodeToFront(9);                
            singleLinkedList.AddNodeToFront(10);
            singleLinkedList.PrintList();
            


        }

        internal class Node
        {
            internal int data;
            internal Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        internal class SingleLinkedList
        {
            int count;
            Node head;

            public SingleLinkedList()
            {
                head = null;
                count = 0;
            }

            public void AddNodeToFront(int newData)
            {
                Node node = new Node(newData);
                node.next = head;
                head = node;
                count++;

            }

            public void PrintList()
            {
                Node runner = head;
                while (runner != null)
                {
                    Console.WriteLine(runner.data);
                    runner = runner.next;   
                }
            }

            
        }

       



    }



}
