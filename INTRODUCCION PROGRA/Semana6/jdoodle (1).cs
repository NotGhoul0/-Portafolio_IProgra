using System;



class Program

{

    double sueldo;

    double abono;

    

    Console.WriteLine("Ingrese su sueldo");

    Sueldo = Convert.ToDouble(Console.ReadLine());

    

    if (sueldo > 3000){

        

        abono = sueldo * 0.05;

        

        Console.WriteLine("su impuesto a abonar es de " + abono + "en impuestos");

    }

    else {

        Console.WriteLine("No debe abonar impuesto");

     }