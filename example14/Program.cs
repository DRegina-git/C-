// функции (метод) с интегратором случайных чисел
void FillArray(int[] collection) // где collection - это название массива
{
    int length = collection.Length;
int index = 0;
while (index < length)
{
     collection[index] = new Random().Next(1, 10);
     index++;
}

}

void PrintArray(int[] col)
{
    int count = col.Length;  //то же самое, что и в первом void, только с другими названиями
    int position = 0;
while (position < count)
{
Console.WriteLine(col[position]);
position++;
}
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;  //если введено число, которого нет, то выдает позицию 0, поэтому пишется -1, чтобы понимать, что такого числа нет
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int [10]; // создай новый массив, в котором будет 10 элементов 
//(по умолчанию новый массив будет заполнен нулями, поэтому задаем сверху параметры)

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 40);
Console.WriteLine(pos);