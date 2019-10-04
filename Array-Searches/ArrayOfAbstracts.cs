using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Searches
{
    class ArrayOfAbstracts 
    {
        private Nodes[] arrayOfNodes;
        public ArrayOfAbstracts()
        {


        }

        public Nodes[] arrayWithNodes()
        {
            for(int a = 0; a < arrayOfNodes.Length; a++)
            {
                Nodes temp = new Nodes();

                Console.WriteLine();
                temp.firstName = Console.ReadLine();

                arrayOfNodes[a] = temp;
            }

            return arrayOfNodes;
        }

        public void numberOfElements()
        {
            int count = 0;

            for (int a = 0; a < arrayOfNodes.Length; a++)
            {
                count++;

            }
        }

        public void displayValues()
        {
            for (int a = 0; a < arrayOfNodes.Length; a++)
            {
                Console.WriteLine(arrayOfNodes[a]);
            }
        }

        public void searhForWord(Nodes searchNumber)
        {
            for (int a = 0; a < arrayOfNodes.Length; a++)
            {
                if (searchNumber == arrayOfNodes[a])
                {
                    Console.WriteLine(searchNumber + " is in the list of arrayOfNodes");
                    return;
                }
            }

            Console.WriteLine(searchNumber + " is not in this list");
        }
    }
}
