// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;

//Give Array = [1, 3, 42, 20, 97, 65, 88, 43, 64, 20, 12, 48, 24, 38]

int[] new_array = new int[] { 1, 3, 42, 20, 97, 65, 88, 43, 64, 20, 12, 48, 24, 38 };


//Find the sum of all the integers in the array.
//method 1
int sum = 0;
for (int i = 0; i < new_array.Length; i++)
{
    sum += new_array[i];
}
Console.WriteLine("Sum of all integers: " + sum);
//method 2
//int sum = 0; 
//foreach (int num in new_array) 
//{ sum += num; } 
//Console.WriteLine("Sum of all integers: " + sum); 

//Find the maximum and minimum values in the array.
//max value
int max = new_array.Max();
Console.WriteLine("max value:" + max);
//min value
int min = new_array.Min();
Console.WriteLine("max value:" + min);

//Count the number of even and odd integers in the array.
int evenCount = 0;
int oddCount = 0; 
foreach (int num in new_array) 
{ if (num % 2 == 0) 
    { evenCount++; }
    else { oddCount++; } } 
Console.WriteLine("Number of even integers: " + evenCount); 
Console.WriteLine("Number of odd integers: " + oddCount);
//Calculate the average of all the integers in the array.
double avg = (double)sum / new_array.Length;
Console.WriteLine("average of all integers:" + avg);
//Check if a specific integer is present in the array.
int specificInteger = 97;
bool present = new_array.Contains(specificInteger);
Console.WriteLine(specificInteger + "is present" + present);
//Create two dimensional Array.
int[,] array2D = new int[3, 3]
{
    { 2,4,5 },
    { 3,4,5 },
    { 6,7,9 },
};
int row1 = array2D.GetLength(0);
int col = array2D.GetLength(1);

for (int i = 0; i < row1; i++)
{
    for (int j = 0; j < col; j++)
    {
        Console.WriteLine($"index {i}). {array2D[i, j]}");
    }
    Console.WriteLine();
}
//Create a program that finds the sum of all elements in a two-dimensional array (matrix).
 int summ = 0;
for (int i = 0; i < array2D.GetLength(0); i++) 
{ for (int j = 0; j < array2D.GetLength(1); j++) 
    { summ += array2D[i, j]; } } 
Console.WriteLine("Sum of all integers: " + summ);
Console.WriteLine("Sum of all elements in array2d: " + summ);

//Write a function to calculate the area of a rectangle the length of the rectangle is 20cm and the width is 12cm.

int length = 20;
int width = 12;
int Area = length * width;
Console.WriteLine($"Area of Rectangle is {Area}");

