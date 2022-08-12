//1/////
// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше или равно 3 символам;
string[]array1 = {"hello", "2", "world", ":-)"};
string[]array2 = new string[array1.Length];
int j = 0;  
 Console. Write($"[");
 for ( int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3) 
        
            { 
            array2[j] = array1[i]; 
           
          Console. Write(array2[j] + " ");
           j++;
           }
    }
Console. Write($"]");
