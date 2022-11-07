// See https://aka.ms/new-console-template for more information

using ProjetTests;

var calculatrice = new Calculatrice();
var result = calculatrice.Addition(1, 2);

var result2 = calculatrice.Addition(1, 2, 3, 4,5 ,6,7 ,8,9,10);
var result3 = calculatrice.Division(6,0);

Console.WriteLine(result);
Console.WriteLine(result2);
Console.WriteLine(result3);
Console.WriteLine("Hello, World!");
