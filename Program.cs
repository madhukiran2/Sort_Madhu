// See https://aka.ms/new-console-template for more information
/*
Author: Madhu Kiran Dadisetty
Date: 2/28/2024
Comments: Selection Sort Algorithm
*/

int[] selection_sort_numbers = { 5, 72, 3, 14,7,1 };
Console.WriteLine(" Below is the initial array that will be utilized to implement the Selection Sort Algorithm: ");
for (int i = 0; i < selection_sort_numbers.Length; i++)
{
    Console.Write("  " + selection_sort_numbers[i]);
} // Initializing an array for selection sort algorithm and displaying the initial array elements

Console.WriteLine("");
Console.WriteLine("This is how the array looks after applying the Selection Sort Algorithm: ");
Selection_Sort(selection_sort_numbers);
Console.WriteLine("");
// Printing the array after applying the Selection Sort Algorithm

static void Selection_Sort(int[] ss_arr)
{
    // min_position tracks the position of the element with the current lowest value
    int min_position;
    // 'temp' facilitates the swapping process within the Selection Sort Algorithm
    int temp;

    for (int i = 0; i < ss_arr.Length; i++)
    {
        min_position = i;
        
        for (int x = i + 1; x < ss_arr.Length; x++)
        {
            if (ss_arr[x] < ss_arr[min_position])
            {
                min_position = x;
            }
        } 

        if (min_position != i)
        {
            temp = ss_arr[i];
            ss_arr[i] = ss_arr[min_position];
            ss_arr[min_position] = temp;
        }
        Console.Write("  " + ss_arr[i]);
    }
} // Iterate through the array and find the minimum element's position for each pass, then swap it with the element at the current position if necessary, sorting the array in ascending order.
