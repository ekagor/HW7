// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

PrintInfo();
Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columns = int.Parse(Console.ReadLine());
int  [,] arr1001 = new int  [rows,columns];
GetArray(arr1001);
PrintArray(arr1001);
PrintResult(arr1001);

void PrintInfo(){
    Console.WriteLine("Программа задает двумерный массив из целых чисел");
    Console.WriteLine("и находит среднее арифметическое элементов в каждом столбце");
} 

void PrintResult(int[,] arr1001){
    for (int j = 0; j < arr1001.GetLength(1); j++){
        double sum = 0;
        for (int i = 0; i < arr1001.GetLength(0); i++){
            sum += arr1001[i, j];
        }
            Console.WriteLine($"Среднее арифметическое {j} столбца [{ sum / arr1001.GetLength(0)}] ");
    }
}

void GetArray(int [,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array [i,j] = new Random().Next(1,10);
        }   
    }
}

void PrintArray ( int  [,] arrray){
    for (int i = 0; i < arr1001.GetLength(0); i++){
        for (int j = 0; j < arr1001.GetLength(1); j++){
            Console.Write($"{arr1001[i,j]} ");
        }
        Console.WriteLine();
    }
}