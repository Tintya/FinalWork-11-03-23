void NewArray(string[] arr1, string[] arr2)
{
    int count = 0;
for (int i = 0; i < arr1.Length; i++)
{
    if(arr1[i].Length<4)
    {
        arr2[count] = arr1[i];
        count++;
    }
}
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}


string[] array = {"Russia", "1234", "2", ":-)", "hello", "new"};
string[] finalArray = new string[array.Length];
NewArray(array, finalArray);
PrintArray(finalArray);
