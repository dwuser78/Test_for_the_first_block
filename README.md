# Итоговая контрольная работа по основному блоку
## Задание
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

*Примеры:*

    [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
    [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
    [“Russia”, “Denmark”, “Kazan”] → []

### В рамках решения задачи необходимо:
1. Создать репозиторий на GitHub.
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод).
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md).
4. Написать программу, решающую поставленную задачу.
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах).

## Решение
- [Репозиторий](https://github.com/dwuser78/Test_for_the_first_block "Репозиторий")
- [Блок-схема](https://github.com/dwuser78/Test_for_the_first_block/blob/main/Diagram.drawio "Блок-схема")
- [Программа](https://github.com/dwuser78/Test_for_the_first_block/tree/main/App "Программа")

Программа написана на C# .NET, и состоит из трёх процедур:

*Заполнение первого массива вручную пользователем:*

[![N](https://github.com/dwuser78/Test_for_the_first_block/blob/main/Img/diag_part_1.png?raw=true)]()
```C#
    void FillArray(string[] array)
    {
        for (int word = 0; word < array.Length; word++)
        {
            Console.Write($"Enter the word [{word + 1}] = ");
            array[word] = Console.ReadLine();
        }
    }
```

*Заполнение нового массива, согласно условию (определено в условии задачи):*

[![N](https://github.com/dwuser78/Test_for_the_first_block/blob/main/Img/diag_part_2.png?raw=true)]()
```C#
    void PrintArray(string[] array)
    {
        Console.Write("[");
    
        for (int word = 0; word < array.Length; word++)
        {
            if (word == array.Length - 1)
                Console.WriteLine("\"{0}\"]", array[word]);
            else
                Console.Write("\"{0}\", ", array[word]);
        }
    }
```

*Печать нового массива:*

[![N](https://github.com/dwuser78/Test_for_the_first_block/blob/main/Img/diag_part_3.png?raw=true)]()
```C#
    string[] CreateNewArray(string[] oldArray)
    {
        int words = 0;
    
        for (int i = 0; i < oldArray.Length; i++)
        {
            if (oldArray[i].Length <= LimitsConst.charLimit)
                words++;
        }
    
        string[] newArray = new string[words];
        int n = 0;
    
        for (int i = 0; i < oldArray.Length; i++)
        {
            if (oldArray[i].Length <= LimitsConst.charLimit)
            {
                newArray[n] = oldArray[i];
                n++;
            }
        }
    
        return newArray;
    }
```