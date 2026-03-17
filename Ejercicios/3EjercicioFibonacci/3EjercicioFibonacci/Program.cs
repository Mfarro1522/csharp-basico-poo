
/*
 * Escribe un programa que imprima los 50 primeros números de la sucesión
 * de Fibonacci empezando en 0.
 * - La serie Fibonacci se compone por una sucesión de números en
 *   la que el siguiente siempre es la suma de los dos anteriores.
 *   0, 1, 1, 2, 3, 5, 8, 13...
 */
static void fibonacci (int n)
{
    long a = 0;
    long b = 1;
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine(a);
        long t = b;
        b += a;
        a = t;
        
    }
}

Console.WriteLine("Los 50 Numero fibonacci");
fibonacci(50);
