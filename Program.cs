/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
(Строки и циклы в решении использовать нельзя!)*/

Console.Write("Задача  13");
Console.Write("Введите число K ");
int pp = int.Parse(Console.ReadLine());
double s= pp / 100;
Console.WriteLine(s);
if (s == 0){
 
  Console.WriteLine("-> третьей цифры нет");
}
if(s>100){
    s = s %10;
    Console.WriteLine("третья цифра -> " + s); 
}
