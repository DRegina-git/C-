//интегратор случайных чисел
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

int[] array = new int [10]; // создай новый массив, в котором будет 10 элементов 
//(по умолчанию новый массив будет заполнен нулями, поэтому задаем сверху параметры)

FillArray(array);
PrintArray(array);
// FillArray - заполняет массив, который мы создали, а PrintArray вывел его на экран