using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structures_and_algorithms
{
    public class LinkedList
    {
        //The start of the Linked list chain
        Node head = null;
        
        //Node foot = null; unciomment this line for the O(1) complexity

        public void AddToEnd(object data) {
            // create the node for the data to go into  
            Node node = new Node();
            //place the "data" into the node 
            node.data = data;

            if (head == null){
                //set head equal to the node
                head = node;
                //foot = head;
                Console.WriteLine($"New head of list is {head.data}");
            }
            else
            {
                //The following lines of code is the traditional way we add to the end of list
                // The time complexity of this is O(N)-Linear
                Node current = head;
                
                //use the following loop to find the end of the list
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = node;
                Console.WriteLine($"New node addeed to end of list has a value of {node.data}");
                
                // The following lines uses O(1) time complexity because
                // it has a pointer to the end of the list
                //foot.next=node;
                //foot = foot.next;
            }
        }
        public void AddToFront(object data) {
            // create the node for the data to go into  
            Node node = new Node();
            //place the "data" into the node 
            node.data = data;

            //VERY IMPORTANT
            node.next = head;
            head = node;
        }
        public void ListAll(){
            // This function loops through the entire list and return 
            // the data object in the node;

            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
    }
}
