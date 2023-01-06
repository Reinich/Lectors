//                         строки, столбцы
// string[,] table = new string[2, 3];

// String.Empty; - заполнение массива нулями

// table[0 , 0] table[0 , 1] table[0 , 2] table[0 , 3] table[0 , 4]
// table[1 , 0] table[1 , 1] table[1 , 2] table[1 , 3] table[1 , 4]



 string[,] table = new string[2, 5];
 table[1, 2] = "слово";
 for (int rows = 0; rows < 2; rows++)
 {
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
 }

//                      [0, 1] в GetLength;
// int[,] matr = new int[5, 4]; [0, 0]



