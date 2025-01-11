public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Declare an array to hold the multiples
        // We create an array 'multiples' of type double with the size 'length'
        // The array will store the multiples of the base number.
        double[] multiples = new double[length];

        // Step 2: Use a for-loop to calculate and store the multiples of 'number'
        // The loop will run 'length' times, once for each multiple we want to generate.
        for (int i = 0; i < length; i++)
        {
            // Step 2a: Calculate the (i+1)-th multiple of 'number'
            // We multiply 'number' by (i + 1) because we want multiples starting from 'number * 1' (not 'number * 0')
            multiples[i] = number * (i + 1);
        }

        // Step 3: Return the populated array with the multiples
        // Once the array is filled with the calculated multiples, we return it to the caller.
        return multiples;
    }


    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Handle the edge case when the list is empty
        if (data.Count == 0)
        {
            return; // No rotation needed for an empty list
        }

        // Step 2: Normalize the 'amount' to ensure we do not rotate more than necessary
        amount = amount % data.Count; // Ensure that amount is within the bounds of the list length

        // Step 3: If amount is 0, no need to rotate
        if (amount == 0)
        {
            return; // No rotation needed if the amount is 0 or a multiple of the list length
        }

        // Step 4: Create the two parts of the rotated list using GetRange
        // Get the last 'amount' elements
        var lastPart = data.GetRange(data.Count - amount, amount);

        // Get the first 'data.Count - amount' elements
        var firstPart = data.GetRange(0, data.Count - amount);

        // Step 5: Modify the original list to be the concatenation of lastPart and firstPart
        data.Clear(); // Clear the original list before adding the new elements
        data.AddRange(lastPart); // Add the last 'amount' elements to the beginning
        data.AddRange(firstPart); // Add the first part to the end
   
    }
}
