int TotalJugador=20;
int TotalDealer = 15;
string Message;

// Condicionales para el juego
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