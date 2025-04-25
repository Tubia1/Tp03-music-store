public class Disco
{
    public Dictionary<int, string> canciones { get; private set; }
    public string artista { get; private set; }
    public string genero { get; private set; }
    public string foto { get; private set; }
    public string productor { get; private set; }
    public int id { get; private set; }
    public Disco(string PArtista, string Pgenero, string Pfoto, string Pproductor, int Pid)
    {
        artista = PArtista;
        genero = Pgenero;
        foto = Pfoto;
        productor = Pproductor;
        id = Pid; 
        canciones = new Dictionary<int, string>();
    }


}