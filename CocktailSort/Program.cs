// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] ints = { 5, 1, 4, 2, 8, 0, 2 };

CocktailSort(ints);

foreach(var i in ints)
{
    Console.WriteLine(i);
}

void CocktailSort(int[] arr)
{
    bool swapped = true;

    int start = 0, end = arr.Length;

    while(swapped is true)
    {
        swapped = false;

        // largest to end as bubble
        for(int i = start; i < end - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                int temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
                swapped = true;
            }
        }

        if (swapped is false)
            break;

        swapped = false;

        for(int i = end - 2; i >= start; i--)
        {
            if (arr[i] > arr[i + 1])
            {
                int temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
                swapped = true;
            }
        }
    }
}