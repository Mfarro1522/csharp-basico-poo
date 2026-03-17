


using System.Text;

var poderVolar =  new SuperPoder();
poderVolar.Nombre = "Volar";
poderVolar.Descripcion = "Capacidad de moverse por el aire";
poderVolar.Nivel = NivelPoder.NivelDos;

var superFuerza = new SuperPoder();
superFuerza.Nombre = "Super fuerza";
superFuerza.Descripcion = "Capacidad de tener una fuerza sobrehumana";
superFuerza.Nivel = NivelPoder.NivelTres;

var superVision = new SuperPoder();
superVision.Nombre = "Super Vision";
superVision.Descripcion = "Capacidad de ver a grandes distancias y a través de objetos";
superVision.Nivel = NivelPoder.NivelDos;

var superman = new SuperHeroe();
superman.Id = 1;
superman.Nombre = "Superman";
superman.IdentidadSecreta = "Clark kent";
superman.Ciudad = "Metropolis";
superman.PuedeVolar = true;

List<SuperPoder> poderesSuperman= new List<SuperPoder>();
poderesSuperman.Add(superFuerza);
poderesSuperman.Add(poderVolar);
poderesSuperman.Add(superVision);

superman.SuperPoderes = poderesSuperman;


Console.WriteLine(superman.UsarSuperPoderes()); ;

class SuperHeroe
{
    public int Id;
    public string Nombre;
    public string IdentidadSecreta;
    public string Ciudad;
    public List<SuperPoder> SuperPoderes ;
    public Boolean PuedeVolar;

    public SuperHeroe()
    {
        Id = 1;
        SuperPoderes = new List<SuperPoder>();
        PuedeVolar = false;

    }

    public string UsarSuperPoderes ()
    {
        StringBuilder sb = new StringBuilder();
        foreach(var item  in SuperPoderes)
        {
            sb.AppendLine($"{Nombre} esta usando el super poder {item.Nombre}!");

        }
        return sb.ToString();
    }

}

class SuperPoder
{
    public string Nombre;
    public string Descripcion;
    public NivelPoder Nivel;

    public SuperPoder()
    {
        Nivel = NivelPoder.NivelUno;
        
    }
}

enum NivelPoder
{
    NivelUno,
    NivelDos,
    NivelTres
}