// массов и функции

int[] array = {11, 21, 31, 4, 18, 15, 61, 71, 18};
int n = array.Length; //длина массива
int find = 18;
int index = 0;

while (index < n)
{
if (array[index] == find)
{
    Console.WriteLine (index);
    break;  //если два одинаковых числа, то прерываем поиск, находит только первый элемент
}

    index++;
}
