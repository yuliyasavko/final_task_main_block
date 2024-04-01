string[] FilterArray(string[] array, int k){
   int count = 0;
   for (int i = 0; i < array.Length; i++)
   {
    if (array[i].Length <= k)
    {
        count++;
    }
   }
   int n = 0;
   string[] result = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= k)
        {
            result[n] = array[i];
            n++;
        }
    }
    return result;
}

string[] arr = {"Hello", "2", "world", ":-)"};
string[] result = FilterArray(arr, 3);

Console.WriteLine($"[{string.Join(", ", result)}]");
