using System;
using Humanizer;

Console.WriteLine("Por favor ingrese su nombre:");
string nombre = Console.ReadLine();

Console.WriteLine("Por favor ingrese su cargo:");
string cargo = Console.ReadLine();

Console.WriteLine("Por favor ingrese su edad:");
int edad = int.Parse(Console.ReadLine());

Console.WriteLine($"Mi nombre es {nombre}, tengo {edad.ToWords(new System.Globalization.CultureInfo("es"))} años y soy {cargo}.");