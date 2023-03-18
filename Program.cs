// See https://aka.ms/new-console-template for more information
using POO;

Console.WriteLine("Hello, World!");

Fecha f = new Fecha();
f.setDia(2);
f.setMes(10);
f.setAnio(1970);

Console.WriteLine("Dia = " + f.getDia());
Console.WriteLine("Mes = " + f.getMes());
Console.WriteLine("Año = " + f.getAnio());
Console.WriteLine(f);