public class Catalogo
{
    public Dictionary<int,Disco> Discos {get;private set; }
    public Catalogo()
    {
    Discos = new Dictionary<int, Disco>();
    }
}