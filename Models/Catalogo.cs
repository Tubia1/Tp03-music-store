public static class Catalogo
{
    public static Dictionary<int, Disco> Discos { get; private set; }
    public static Disco OscuroExtasis { get; private set; }
    public static Disco Caravana { get; private set; }
    public static Disco TercerArco { get; private set; }
    public static Disco Descartable { get; private set; }
    public static Disco MalosCantores { get; private set; }
    public static Disco Inmortales { get; private set; }
    public static Disco MDB { get; private set; }
    public static Disco RadioClubHits { get; private set; }
    public static void InicializarDiscos()
    {
     OscuroExtasis = new Disco("Wos","Hip Hop","/Imagenes/OscuroExtasis.png","Evlay Beats",1, new List<string>{"Intrdouccion al extasis","Buitres","Culpa","Pared De Cristal", "Mira Mama", "Gato Negro", "Que Se Mejoren", "Niño Gordo Flaco", "Cambiando La Piel", "Contando Ovejas", "Convoy Jarana", "LLeno de Zafiros","Mugre"});

    }
}