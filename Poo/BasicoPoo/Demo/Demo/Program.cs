Atomizador miAtomizador = new Atomizador();
Atomizador miAtomizador2 = new Atomizador();

miAtomizador.Color = "Amarillo";
miAtomizador.Tipo = "Plástico";
miAtomizador.Capacidad = 0.5;
miAtomizador.Altura = 15;
miAtomizador.TipoDeRocío = "Ajustable";
miAtomizador.EsRecargable = true;

class Atomizador
{
    public String Color;
    public String Tipo;
    public double Capacidad;
    public int Altura;
    public String TipoDeRocío;
    public Boolean EsRecargable;
}