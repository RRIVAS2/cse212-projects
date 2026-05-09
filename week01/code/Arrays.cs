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
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.


        // Implementation:
        // 1.Create an empty array of size equal to length, of type double, this array will store the multiples
        // 2.Create a for loop that iterates over the size of length, starting at index 0, at each iteration
        // 2.Inside the for loop, multiply number by the current iteration value + 1, so that in the first iteration we don't multiply by 0.
        // 3.Add the value to the array
        // 4.return the array

        double[] multiples = new double[length];

        for (int i = 0; i < length; i++)
        {
            var multiple = number * (i + 1);
            multiples[i] = multiple;
        }

        return multiples; // replace this return statement with your own
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.


        //Implementation:
        //1.Extract the values to the right, using the GetRange method, and store them in a temporal list. Count the number of values in the array and substract the amount of values to rearrange to get the starting position
        //2.Remove the vlaues to the right, using the RemoveRange method
        //3.Insert the temporal list at index 0, using the InsertRange method.

        var temporal = data.GetRange(data.Count - amount, amount);
        data.RemoveRange(data.Count - amount, amount);
        data.InsertRange(0, temporal);


    }
}
