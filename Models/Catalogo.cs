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
OscuroExtasis = new Disco("Oscuro Extasis", "Wos","Hip Hop"," /Imagenes/OscuroExtasis.png","Evlay Beats",1, new List<string>{"Intrdouccion al extasis","Buitres","Culpa","Pared De Cristal", "Mira Mama", "Gato Negro", "Que Se Mejoren", "Niño Gordo Flaco", "Cambiando La Piel", "Contando Ovejas", "Convoy Jarana", "LLeno de Zafiros","Mugre"});
Caravana = new Disco("Caravana","Wos", "Hip Hop","/Imagenes/Caravana.jpg" ,"Doguito Records", 2, new List<string> {"Púrpura", "Andrómeda", "Canguro","Okupa",  "Luz  Delito", "Melón Vino", "No Va A Bajar"});
TercerArco = new Disco("Tercer Arco","Los Piojos", "Rock","/Imagenes/TercerArco.jpg", "El Farolito Discos", 3, new List<string> { "Esquina Libertad", "Taxi Boy", "El Farolito", "Shup-Shup", "Intro Maradó", "Maradó", "Gris", "Todo Pasa", "Cruel", "Don’t Say Tomorrow", "Muévelo", "Verano del '92" });
Descartable = new Disco("Descartable", "Wos", "Hip Hop","/Imagenes/Descartable.jpg", "Doguito Records", 4, new List<string> { "Nuevas coordenadas", "Descartable", "⅞", "Quemarás", "Cabezas Cromadas", "Morfeo", "Caída libre", "Pausa", "La Cochería", "Melancolía", "Estímulo", "Ermitaño", "Que se haga tarde", "La Niebla", "Sur", "Arrancármelo" });
MalosCantores = new Disco("Malos Cantores","C.R.O", "Trap","/Imagenes/MalosCantores.jpg", "Nocita Music", 5, new List<string> { "Metido en los verdes", "Hustlers", "Del infierno me escapé", "Vida Cara", "Sobredosis en Las Vegas", "Valentino", "Buenos Aires", "Diamante en Bruto" });
Inmortales = new Disco("Inmortales","Bardero$", "Hip Hop","/Imagenes/Inmortales.jpg", "Nocita Music", 6, new List<string> { "Pueblos Caídos", "Aquella Noche", "La Feria", "Ahora Corren", "Don Perignon", "Inmortales" });
MDB = new Disco("MDB","C.R.O & Homer el Mero Mero", "Trap","/Imagenes/MDB.jpg", "Nocita Music", 7, new List<string> { "El Barrio", "La Mafia", "Bajo Fuego", "Jungla", "No Hay Fronteras", "Apuestan", "Real", "Sin Perder", "Muero Por Ti", "Los Indestructibles" });
RadioClubHits = new Disco("Radio Club Hits","YSY A", "Hip Hop","/Imagenes/RadioClubHits.jpg", "ONErpm Latino", 8, new List<string> { "Más Grande Este Año", "Cada Vez Que", "Ya Ni Yo Me Entiendo", "Tony Soprano", "Agua Con Pila", "Más Grande Este Año (Instrumental)", "Cada Vez Que (Instrumental)", "Ya Ni Yo Me Entiendo (Instrumental)", "Tony Soprano (Instrumental)", "Agua Con Pila (Instrumental)" });
Discos = new Dictionary<int, Disco>();
Discos.Add(1,OscuroExtasis);
Discos.Add(2,Caravana);
Discos.Add(3,TercerArco);
Discos.Add(4,Descartable);
Discos.Add(5,MalosCantores);
Discos.Add(6,Inmortales);
Discos.Add(7,MDB);
Discos.Add(8,RadioClubHits);
    }
}