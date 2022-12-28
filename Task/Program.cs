/*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*/
Console.WriteLine("Pls enter Qty of arrey's elements: ");
int size  = int.Parse(Console.ReadLine());
string[] arr1 = new string[size];
for (int i = 0; i < size; i++){
    Console.Write("Pls enter array's element: ");
    string result = Console.ReadLine();
    arr1[i] = result;  
}
Console.WriteLine();
Console.Write("Entered array is: [");
Console.Write(string.Join(",", arr1));
Console.Write("]");

