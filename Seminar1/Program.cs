﻿// int number = 5;
// double number2 = 12,4;
// string word = "my word!";
// char symbol = 't';
// bool chek = false; 

// int num1 = 5;
// int num2 = 7;

// Console.WriteLine($"My numbers are {num1} and {num2} and it is good!");


// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Your namber is " + num);


//Seminar 2. 

//Task 1. 

//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// int CutNumber(int num)
// {
//     int hundreds = num / 100;
//     int units = num % 10;

//     int result = hundreds * 10 + units;
//     return result;
// }

// int randnmber = new Random().Next(100, 1000);
// int  newnumber = CutNumber(randnmber);

// Console.WriteLine($"New version of {randnmber} is {newnumber}");


//Task 2. 

//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// int Comparison(int num)
// {
//     int desyatky = num / 10;
//     int units = num % 10;
//     if(desyatky > units)
//     {
//         return desyatky;
//     }
//     else
//     {
//         return units;
//     }
// }

// int randnumber = new Random().Next(10, 100);
// int  newnumber = Comparison(randnumber);

// Console.WriteLine($"Наибольшая цифра числа {randnumber} это {newnumber}");




//Task 3. 
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.

// bool Multiply (int number, int div1, int div2)
// {
//         if(number % div1 == 0 && number % div2 == 0);
//         {
//             return true;
//         }
//         else
//         {
//             return false;
//         }
// }

// Console.WriteLine("Введите число: ");
// Console.WriteLine("Введите число a: ");
// Console.WriteLine("Введите число b: ")
// int 





//return true;
//&& - логическое и;
//|| - логическое или





//Task 4. 
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// bool TestNum(int num1, int num2)
// {
//     if(num1 == num2 * num2 || num2 == num1 * num1)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(TestNum(num1, num2));



// Seminar 3.
// Задача1. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// void ShowRange(int quadrant)
// {
//     if(quadrant == 1) Console.WriteLine("x > 0 and y > 0"); 
//     else if(quadrant == 2) Console.WriteLine("x < 0 and y > 0");
//     else if(quadrant == 3) Console.WriteLine("x < 0 and y < 0");
//     else if(quadrant == 4) Console.WriteLine("x > 0 and x < 0");
//     else Console.WriteLine("Quadrant doesnt exist");
// }

// Console.WriteLine("Input a number of quadrant: ");
// int quadNum = Convert.ToInt32(Console.ReadLine());

// ShowRange(quadNum);



// Задача 2. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
// выдаёт номер четверти плоскости, в которой находится эта точка.

// int Div (int x, int y)
// {
//     if (x > 0 && y > 0) return 1;
//     if (x < 0 && y > 0) return 2;
//     if (x < 0 && y < 0) return 3;
//     if (x > 0 && y < 0) return 4;
    
//     return -1;
// }

// Console.Write("Введите координату X: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Div(x, y));


// Задача 3.Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// double Div (double x1, double y1, double x2, double y2)
// {
//     double len_x = x2 - x1;
//     double len_y = y2 - y1;

//     double len_xy = Math.Sqrt(len_x * len_x + len_y * len_y);

//     return len_xy;
// }

// Console.Write("Введите координату X1: ");
// double x1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату Y1: ");
// double y1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату X2: ");
// double x2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату Y2: ");
// double y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Math.Round(Div(x1, y1, x2, y2), 2));


// Задача 4. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

// void Div(int num)
// {
//     for(int i = 1; i <= num; i++) Console.WriteLine($"{i} - {i*i}");
// }

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Div(num);




