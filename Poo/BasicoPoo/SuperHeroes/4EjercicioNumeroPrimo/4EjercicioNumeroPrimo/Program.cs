/*
 * Escribe un programa que se encargue de comprobar si un número es o no primo.
 * Hecho esto, imprime los números primos entre 1 y 100.
 */



static bool numEsPrimo(int n)
{
    if (n < 2) return false;
    
        for (int i = 2; i <= Math.Sqrt(n); i++) // una correccion es <= debido a nos daria false en caso no pusieramos el igual en casos como el 4
        {
            if (n % i == 0)
            {
                return false;
            }
        }

    
    return true;
}


Console.WriteLine("Ingrese un numero y comprueba si es primo : ");
if (int.TryParse(Console.ReadLine(), out int n))
{
    bool resultado = numEsPrimo(n);
    Console.WriteLine(resultado);
}
else
{
    Console.WriteLine("Entrada no válida.");
}

//segunda parte de los primos entre 1-100
for (int i = 1; i <= 100; i++)
{
    if (numEsPrimo(i))
    {
        Console.Write(i+" ");
    }
}