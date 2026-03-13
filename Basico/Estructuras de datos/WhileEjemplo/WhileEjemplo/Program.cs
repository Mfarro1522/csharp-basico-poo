using System.Runtime.ExceptionServices;

int totalJugador = 0;
int totalDealer = 0;
int num = 0;
int fichas = 0;
String mensaje = "";
String controlOtraCarta = "";
String switchControl = "menu";
System.Random random = new System.Random();

while (true)
{
    Console.WriteLine("Bienvenido al Casino");
    Console.WriteLine("Cuantas fichas desea? \n(recuerda que necesitas una por ronda) ");
    fichas = int.Parse(Console.ReadLine());
    for (int i = 0; i < fichas; i++)
    {

        totalJugador = 0;
        totalDealer = 0;
        switch (switchControl)
        {
            case "menu":

                Console.WriteLine("Escribe 21 para jugar al '21' ");
                switchControl = Console.ReadLine();
                i--;
                break;

            case "21":

                do
                {

                    num = random.Next(1, 12);
                    totalJugador += num;
                    Console.WriteLine($"Tu carta es: {num}. Total: {totalJugador}");
                    Console.WriteLine("Deseas otra carta?");
                    controlOtraCarta = Console.ReadLine().ToLower();

                }
                while (controlOtraCarta == "si" || controlOtraCarta == "yes");
                totalDealer = random.Next(14, 23);
                Console.WriteLine($"El total del dealer es: {totalDealer}");
                if (totalJugador > totalDealer && totalJugador <= 21)
                {
                    mensaje = "Venciste al dealer!";
                    switchControl = "menu";
                }
                else if (totalJugador >= 22)
                {
                    mensaje = "Perdiste! Te pasaste de 21.";
                    switchControl = "menu";
                }
                else
                {
                    mensaje = "Perdiste! El dealer venció tu total.";
                    switchControl = "menu";
                }

                Console.WriteLine(mensaje + "\n");
                break;

            default:
                Console.WriteLine("Estado desconocido. Volviendo al menú.");
                switchControl = "menu";
                break;
        }
    }
}