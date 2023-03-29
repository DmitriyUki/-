// Написать программу, которая из имеющегося массива строк формирует массив строк, длина которого меньше либо равна 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении 
//не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] ArrayItemNumDegree(string[] array, int countOfDigits) 
{
    int[] itemNumDegreeId = new int[array.Length];
    int countOfItems = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= countOfDigits)
        {
            itemNumDegreeId[countOfItems] = i;
            countOfItems++;
        }
    }
    string[] resultArray = new string[countOfItems];
    for(int i = 0; i < countOfItems; i++)
    {
        resultArray[i] = array[itemNumDegreeId[i]];
    }
    return resultArray;
}

string[] array1 = new string[4] {"goodbye", "3", "land", ":-("};
string[] array2 = new string[4] {"1111", "1236", "-1", "computer science"};
string[] array3 = new string[3] {"Pakistan", "Poland", "Georgia"};

Console.WriteLine("ArrayItemNumDegree");
Console.WriteLine($"[{string.Join(",",array1)}]->[{string.Join(",", ArrayItemNumDegree(array1, 3))}]");
Console.WriteLine($"[{string.Join(",",array2)}]->[{string.Join(",", ArrayItemNumDegree(array2, 3))}]");
Console.WriteLine($"[{string.Join(",",array3)}]->[{string.Join(",", ArrayItemNumDegree(array3, 3))}]");