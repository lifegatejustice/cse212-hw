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

        // Plan for MultiplesOf:
        // 1. Create a new double array of size 'length'.
        // 2. Loop from 1 to length (inclusive), for each i, set array[i-1] = number * i.
        // 3. Return the array.

        double[] result = new double[length];
        for (int i = 1; i <= length; i++)
        {
            result[i - 1] = number * i;
        }
        return result;
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
    int n = data.Count;

    // Normalize amount in case it's equal to list size
    amount = amount % n;

    if (amount == 0)
        return;

    // Take last 'amount' elements
    List<int> tail = data.GetRange(n - amount, amount);

    // Remove them from the end
    data.RemoveRange(n - amount, amount);

    // Insert them at the beginning
    data.InsertRange(0, tail);
}
}
