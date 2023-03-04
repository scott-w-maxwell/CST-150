//Corrected by Scott Maxwell

//use for IC08
//Lydia's code

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST117_IC08_console { 
    class Program {
        static void Main(string[] args) {
            //make some sets
            Set A = new Set();
            Set B = new Set();

            //put some stuff in the sets
            Random r = new Random();
            for (int i = 0; i < 10; i++) { 
                A.addElement(r.Next(4)); 
                B.addElement(r.Next(12)); 
            }            
            
            //display each set and the union
            Console.WriteLine("A: " + A);           
            Console.WriteLine("B: " + B);            
            Console.WriteLine("A union B: " + A.union(B));            
            
            //display original sets (should be unchanged)
            Console.WriteLine("After union operation");            
            Console.WriteLine("A: " + A);            
            Console.WriteLine("B: " + B);                   
        }    
    }


    //Lydia's code - find the errors!
   
    class Set
    {        
        private List<int> elements;               
        public Set( )        
        {            
            elements = new List<int>( );                    
        }        
        public bool addElement(int val )        
        {            
            if (containsElement( val )) 
                return false;            
            else { 
                elements.Add(val); 
                return true;
            }
        }
        private bool containsElement(int val) { 
            for (int i = 0; i < elements.Count; i++) {
                if (val == elements[i])
                    return true;

                // We should not return false yet, as the next element in the set could be equal to val. (Caused duplicates)
                //else
                   //return false;
            } 
            return false; 
        }
        public override string ToString() 
        { 
            string str = ""; 
            foreach (int i in elements) { 
                str += i + " "; 
            } 
            return str; }
        public void clearSet() 
        { 
            elements.Clear(); 
        }
        public Set union(Set rhs) 
        {

            // Creating a copy of the set so that original is not modified
            Set tempA = new Set();
            foreach(var element in this.elements)
            {
                tempA.addElement(element);
            }

            for (int i = 0; i < rhs.elements.Count; i++) {

                // We shouldn't reference the original set otherwise it will be modified
                // this.addElement(rhs.elements[i]);

                // Referencing temporary object so that original set is not modified
                tempA.addElement(rhs.elements[i]);

            }

            // This should not return rhs, as rhs is not being modified
            // return rhs;

            // Returning tempA which is a copy of Set A that was modified
            return tempA;
        }
    }
}