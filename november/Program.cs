//2////
// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше или равно 3 символа

//Второй вариант решения задачи

string[]array1 = {"hello", "2", "world", ":-)"};
string[]array2 = new string[array1.Length];
int j = 0; int count = 0; 
 Console. Write($"[");
 for ( int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3) 
        
            { 
            array2[j] = array1[i];               
       
Console. Write(array2[count] + " ");}}
Console. Write($"]");
