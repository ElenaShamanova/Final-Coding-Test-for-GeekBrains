/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
исключительно массивами.
Примеры: 
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> [ ] */

string[] array = new string[] {"1234", "1567", "-2", "computer science"};

string[] result = new string[array.Length];

Console.Write("[");
for (int i = 0; i < array.Length; i++) {
    if (array[i].Length <= 3)
    {
        result[i] = array[i];
    }
    Console.Write(result[i]);
}
Console.Write("]");