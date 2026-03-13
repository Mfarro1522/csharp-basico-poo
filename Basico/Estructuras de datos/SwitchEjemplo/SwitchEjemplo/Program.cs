int TotalJugador = 20;
int TotalDealer = 15;
String SwitchControl = "menu";
string Message;

// Condicionales para el juego
switch (SwitchControl)
{
    case "menu":
        Message = "Bienvenido al juego de Blackjack";

        if (TotalJugador > TotalDealer && TotalJugador <= 21)
        {
            Message = "Venciste al dealer. Felicidades.";
        }
        else if (TotalJugador > 21)
        {
            Message = "Perdiste versus el dealer. Te pasaste de 21.";
        }
        else if (TotalJugador <= TotalDealer)
        {
            Message = "Perdiste versus el dealer. Lo siento.";
        }
        else
        {
            Message = "Condición no válida.";
        }

        Console.WriteLine(Message);

        break;
    case "jugador":
        Message = $"El total del jugador es: {TotalJugador}";
        break;
    case "dealer":
        Message = $"El total del dealer es: {TotalDealer}";
        break;
    default:
        Message = "Opción no válida";
        break;
}