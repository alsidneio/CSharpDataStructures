using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structures_and_algorithms
{
    // This class represents a single node for the linked list class 
    public class Node
    {
        // make the fields public so that they can be accessed
        // inside of the linkedlist class. This isnt technically correct
        // programming because you are supposed to create a property that 
        //exposes the field. 

        public object data = null;
        public Node next = null;
    }
}
