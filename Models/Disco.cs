public class Disco
{
    public string Nombre{get;private set;}
    public List<string >canciones { get; private set; }
    public string artista { get; private set; }
    public string genero { get; private set; }
    public string foto { get; private set; }
    public string productor { get; private set; }
    public int id { get; private set; }
    public Disco(string PNombre ,string PArtista, string Pgenero, string Pfoto, string Pproductor, int Pid, List<string> Pcanciones)
    {
        Nombre = PNombre;
        artista = PArtista;
        genero = Pgenero;
        foto = Pfoto;
        productor = Pproductor;
        id = Pid; 
        canciones = Pcanciones;
    }
}