Console.WriteLine("Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] getArray = new string[size];
string[] newArray = new string[getArray.Length];
for (int i = 0; i < getArray.Length; i++)
    {
        Console.WriteLine("Введите элемент: ");
        getArray[i] = Console.ReadLine();
        if (getArray[i].Length <= 3)
        {
        newArray[i] = getArray[i];       
        }
    }

Console.WriteLine($"Исходный массив: ");
Console.WriteLine(String.Join(" ", getArray));

Console.WriteLine("Обработанный массив: ");
Console.WriteLine(String.Join(" ", newArray));

