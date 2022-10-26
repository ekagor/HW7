// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

PrintInfo();
Console.Write("Введите кол-во строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int n = int.Parse(Console.ReadLine());
double [,] arr = new double [m,n];
GetArray(arr);
PrintArray(arr);

void PrintInfo(){
    
    Console.WriteLine("Программа создает двумерный массив размером m x n");
    Console.WriteLine("заполненный случайными вещественными числами");
} 

void GetArray(double[,] arr){
    var random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            arr [i,j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }   
    }
}

void PrintArray ( double [,] arr){
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}