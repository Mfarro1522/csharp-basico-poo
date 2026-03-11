Console.WriteLine("Mauricio Farro ID! : ");
int altura = 171;
int edad = 23;
String nombre = "Mauricio Farro";
String informacion = "Nacio en Jaén, es estudiante de Informatica";
var hobby = "Videojuegos";

String tarjetaDeInformacion = $"La informacion de {nombre} \n " +
$"es la siguiente , su edad es {edad} y su altura es {altura} cms \n informacion relevanete {informacion}" +
$", ademas su hobby es {hobby}";

Console.WriteLine(tarjetaDeInformacion);