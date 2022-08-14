показывает вторую цифру этого числа.*/
Console.WriteLine("Задача  10");
Console.WriteLine("Введите число K ");
int numberk = int.Parse(Console.ReadLine());
string numberTxt = Convert.ToString(numberk);
if (numberTxt.Length > 2){
  Console.WriteLine("вторая цифра -> " + numberTxt[1]);
}
else {
  Console.WriteLine("-> второй цифры нет");
}

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

/**Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.*/
Console.Write("Введите число  ");
int day = int.Parse(Console.ReadLine());
if (day>5 & day<=7){
   Console.WriteLine("Выходной день-> ");
}
else if (day>7 || day <=0){
   Console.WriteLine("Введено неккоректное значение-> ");
}
else {
  Console.WriteLine("-> Будний день");
}
