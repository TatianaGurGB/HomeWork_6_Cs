// Напишите программу, которая будет создавать копию заданного 
// 2-мерного массива с помощью поэлементного копирования.

// void Print(int[,]arr);
// {
//     int size1 = arr.Length;
//     int size2 = arr.Length;
//     for (i = 0; i < size1; i++)
//     {
//            for (j = 0; j < size2; j++)
//            {
//                Console.Write($" {arr[i, j]} ");
//            } 
//             Console.WriteLine();  
//         }
//     Console.WriteLine(); 
// }

// int[,] MassNums(int size1, int size2, int from, int to)
// {
//     int[,] arr = new int[size1, size2];

//     for (int i = 0; i < size1; i++)
//     {   
//         for (int j = 0; j < size2; j++)
//         {
//             arr[i, j] = new Random().Next(from, to);
//         }        
//     }
//     return arr;
// }

// int[,] NewMass(int[,] arr)
// {
//     int size1 = arr.Length;
//     int size2 = arr.Length;
//     int[,] new_arr = new int[size1, size2];
    
//     for (int i = 0; i < size1; i++)
//     {
//         for (int j = 0; j < size2; j++)
//         {
//             new_arr[i, j] = arr[i, j];
//         }        
//     }
//     return new_arr;
// }

// int[,] arr = MassNums(1, 2, 3, 4);
// Print(arr);
// int[,] arr_new = NewMass(arr);
// Print(arr_new);

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j]} ");
        } 
        Console.WriteLine();       
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
    {   
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(from, to);
        }        
    }
    return arr;
}

int[,] CopyMass(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    int[,] new_arr = new int[row_size, column_size];
    
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            new_arr[i, j] = arr[i, j];
        }        
    }
    return new_arr;
}

int[,] arr_1 = MassNums(2, 5, 1, 11);
Print(arr_1);
int[,] arr_1_new = CopyMass(arr_1);
Print(arr_1_new);

int[,] arr_2 = MassNums(3, 6, 10, 21);
Print(arr_2);
int[,] arr_2_new = CopyMass(arr_2);
Print(arr_2_new);


