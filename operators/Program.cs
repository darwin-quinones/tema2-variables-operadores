//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


// operadores aritmeticos

/* suma  +
 * resta - 
 * multiplicacion *
 * divicion /
 * modulo %
 * auto incremento ++
 * auto decremento --
 */

int i = 7;
Console.WriteLine("modulo "+ i%2);
int t = 0;
Console.WriteLine($"autoincremento {++t}");
Console.WriteLine($"autodecremento {--t}");
Console.WriteLine($"Entero {t}");

// operadores de asignacion

/* * asignacion =
 * https://www.w3schools.com/cs/cs_operators_assignment.php
 * 
 * 
 * !
 */
int j = 10;
int p = 2;

//Console.WriteLine("Suma " + (j += 2));
//Console.WriteLine("resta " + (j -= 2));
//Console.WriteLine("multiplicacion " + (j *= 2));
//Console.WriteLine("division " + (j /= 2));
//Console.WriteLine("modulo " + (j %= 2));


/* operadores de comparacion o relacionales
Console.WriteLine($"{j} es igual a {p} : {j == p}");
Console.WriteLine($"{j} es menor que {p} : {j < p}");
Console.WriteLine($"{j} es mayor que {p} : {j > p}");
Console.WriteLine($"{j} es mayor o igual que {p} : {j >= p}");
*/

// operadores logicos

/**
 * logico y && 
 * logico o || 
 * logico no !   	!(x < 5 && x < 10) Invierte el resultado, devuelve False si el resultado es verdadero
 */

int a = 9;
int b = 11;

Console.WriteLine("AND - Y");
Console.WriteLine("True True " + (a < 10 && b > 10));
Console.WriteLine("True False " + (a < 10 && b < 10));
Console.WriteLine("False True " + (a > 10 && b > 10));
Console.WriteLine("False False " + (a > 10 && b < 10));

Console.WriteLine("OR - O");
Console.WriteLine("True True " + (a < 10 || b > 10));
Console.WriteLine("True False " + (a < 10 || b < 10));
Console.WriteLine("False True " + (a > 10 || b > 10));
Console.WriteLine("False False " + (a > 10 ||  b < 10));

Console.WriteLine("NOT - NO");
Console.WriteLine("True " + !(a < 10));
Console.WriteLine("False " + !(a > 10));



