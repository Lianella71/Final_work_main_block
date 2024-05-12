﻿﻿using System;
class Programm
{
    static void Main()
    {
        Console.WriteLine("Введите элементы массива через запятую:");
        string input = Console.ReadLine();
        string[] FirstArray = input.Split(',');
        string[] resArray = SortingArray(FirstArray);
        Console.WriteLine("Новый массив:");
        foreach (string item in resArray)
        {
            Console.Write(item + ", " );
        }
    }
    static string[] SortingArray(string[] FirstArray)
    {
        int count = 0;
        foreach (string item in FirstArray)
        {
            if (item.Length <= 3)
            {
                count++;    
            }

        }
        string[] resArray = new string[count];
        int index = 0;
        foreach (string item in FirstArray)
        {
            if (item.Length <= 3)
            {
                resArray[index] = item;
                index++;
            }
        }
        return resArray;
    }
        
       
    
}
    
    

