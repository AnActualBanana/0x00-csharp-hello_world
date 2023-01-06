public class Line
{
    public static void PrintDiagonal(int length)
    {
        // Loop through the number of times specified by length
        for (int i = 0; i < length; i++)
        {
            // Print a space for each iteration, except for the first one
            for (int j = 0; j < i; j++)
            {
                Console.Write(" ");
            }
            // Print the diagonal character
            Console.Write("\\");
            // Move to the next line
            Console.WriteLine();
        }
    }
}
