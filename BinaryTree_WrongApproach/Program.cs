int[] arr = [1,2,3,4,5,6,7,8,9,10,11,12,13,14,15];

var capacity = int.MaxValue - 56;

arr = new int[capacity];  

Console.WriteLine("Loop started");

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = i;
}

Console.WriteLine("Loop finished");

var index = BinarySearch(arr, 0, arr.Length - 1, capacity - 100);

Console.WriteLine("Index: {0}", index);
static int BinarySearch(int[] arr, int start,int end,int key)
{
    while (start <= end)
    {
        //int mid = (start + end) / 2;
        
        //int mid = start+((end - start) / 2); // true approach

        int mid = start + ((end - start) >> 1); // binary shifting

        if (arr[mid] == key) { return mid; } // out of range due to int

        if (arr[mid] > key) { end = mid - 1; }

        else
            start = mid + 1;
    }
    return -1;
}