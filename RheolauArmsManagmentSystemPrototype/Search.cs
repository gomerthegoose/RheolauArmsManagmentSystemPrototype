namespace RheolauArmsManagmentSystemPrototype
{
    internal class Search
    {
        // simple binary search algorythm
        // Returns index of x if it is present in the array
        // otherwise returns -1
        // this function is run recursively untill the quiery is located 

        public int binarySearch(int[] searchArray, int startOfArray, int lengthOfArray, int quiery)
        {
            if (lengthOfArray >= startOfArray)// if the length of the array is greater than the start of the array then we know that the search quiery is not present in the array 
            {
                int middle = startOfArray + (lengthOfArray - startOfArray) / 2; // calculate the middle of the array to be searched through

                if (searchArray[middle] == quiery) //if the element at the middle of the arrat equals the search quiery then we have found the quiery
                { 
                    return middle; 
                } 
                if (searchArray[middle] > quiery) // if the quiery is smaller that the middle then it must be located in the left of the array
                { 
                    return binarySearch(searchArray, startOfArray, middle - 1, quiery); 
                }  

                return binarySearch(searchArray, middle + 1, lengthOfArray, quiery); // if it was neither of the above option the quiery must be located in the right of the array 
            }

            return -1; // if quiery is not present in array we return -1 to indicate not found 
        }
    }
}
