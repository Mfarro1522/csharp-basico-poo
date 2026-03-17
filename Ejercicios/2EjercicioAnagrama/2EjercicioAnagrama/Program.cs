/*
 * Escribe una función que reciba dos palabras (String) y retorne
 * verdadero o falso (Bool) según sean o no anagramas.
 * - Un Anagrama consiste en formar una palabra reordenando TODAS
 *   las letras de otra palabra inicial.
 * - NO hace falta comprobar que ambas palabras existan.
 * - Dos palabras exactamente iguales no son anagrama.
 */

Console.WriteLine("Descubre si creaste un Anagrama ingresa dos palabras : ");
Console.WriteLine("Palabra 1 : ");
String pal1 = Console.ReadLine();
Console.WriteLine("Palabra 2 : ");
String pal2 = Console.ReadLine();

Console.WriteLine(EsAnagrama(pal1, pal2));
static bool EsAnagrama(string pal1, string pal2)
{

    if (pal1 == null || pal2 == null) return false
    //correccion 
    pal1 = pal1.Trim().ToLower();
    pal2 = pal2.Trim().ToLower();

    if (pal1.Length != pal2.Length) return false;
    if (pal1 == pal2) return false;

    char[] letras1 = pal1.ToCharArray();
    char[] letras2 = pal2.ToCharArray();
    Array.Sort(letras1);
    Array.Sort(letras2);

    return new string(letras1) == new string(letras2);


}