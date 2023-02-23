using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RheolauArmsManagmentSystemPrototype
{
    internal class Search
    {

        // simple linear search to find where id's are equal to desierd id
        public bool[] id(int target, int[] searchArray)
        {
            bool[] result = new bool[searchArray.Length];

            if (target != -1) // if no search quiery is enterd -1 signifies to show all results
            {
                for (int i = 0; i < searchArray.Length; i++)
                {
                    if (searchArray[i] == target)
                    {
                        result[i] = true;
                    }
                    else
                    {
                        result[i] = false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < searchArray.Length; i++)
                {
                    result[i] = true;
                }
            }


            return result;
        }
    }
}
