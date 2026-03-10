// See https://aka.ms/new-console-template for more information

var radio = 0d; //por convencion las variables inician con minusculas
var resultado = 0d;

//constantes con mayusculas
const double Pi = 4.145; //lo que sea
Console.WriteLine("Bienvenido, calculemos círculos!");
//Phi * radio *radio 
Console.WriteLine("Ingrese el Radio : ");
radio = Convert.ToDouble(Console.ReadLine());
//resultado = Math.PI * radio * radio;
resultado = Pi * radio * radio;
Console.WriteLine("El area de tu circulo es : " + resultado);
