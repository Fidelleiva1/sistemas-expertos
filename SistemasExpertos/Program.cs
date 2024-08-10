namespace SistemasExpertos2
{

    public class Program
    {
           static void Main(string[] args)
            {
                RedSemantica red = new RedSemantica();


                Nodo animal = red.CrearNodo("Animal");
                Nodo ave = red.CrearNodo("Ave");
                Nodo mamifero = red.CrearNodo("Mamífero");


                Nodo avestruz = red.CrearNodo("Avestruz");
                Nodo albatros = red.CrearNodo("Albatros");
                Nodo ballena = red.CrearNodo("Ballena");
                Nodo tigre = red.CrearNodo("Tigre");


                Nodo vida = red.CrearNodo("Vida");
                Nodo sentir = red.CrearNodo("Sentir");
                Nodo moverse = red.CrearNodo("Moverse");

                Nodo plumas = red.CrearNodo("Plumas");
                Nodo huevos = red.CrearNodo("Huevos");
                Nodo bien = red.CrearNodo("Bien");

                Nodo largas = red.CrearNodo("Largas");
                Nodo no_puede_volar = red.CrearNodo("No puede volar");

                Nodo muy_bien = red.CrearNodo("Muy bien");

                Nodo leche = red.CrearNodo("Leche");
                Nodo pelo = red.CrearNodo("Pelo");

                Nodo piel = red.CrearNodo("Piel");
                Nodo mar = red.CrearNodo("Mar");

                Nodo carne = red.CrearNodo("Carne");


                animal.AgregarArco(vida, "tiene");
                animal.AgregarArco(sentir, "puede");
                animal.AgregarArco(moverse, "puede");

                animal.AgregarArco(ave, "tipo de");
                animal.AgregarArco(mamifero, "tipo de");


                ave.AgregarArco(plumas, "tiene");
                ave.AgregarArco(huevos, "pone");
                ave.AgregarArco(bien, "vuela");

                ave.AgregarArco(avestruz, "tipo de");
                ave.AgregarArco(albatros, "tipo de");

                avestruz.AgregarArco(largas, "patas");
                avestruz.AgregarArco(no_puede_volar, "vuela");

                albatros.AgregarArco(muy_bien, "vuela");


                mamifero.AgregarArco(leche, "da");
                mamifero.AgregarArco(pelo, "tiene");

                mamifero.AgregarArco(ballena, "tipo de");
                mamifero.AgregarArco(tigre, "tipo de");

                ballena.AgregarArco(piel, "tiene");
                ballena.AgregarArco(mar, "vive en");

                tigre.AgregarArco(carne, "come");


                red.MostrarRed();
            }

    }

    public class Nodo
    {
        public string Etiqueta { get; set; }
        public List<Arco> Arcos { get; set; }

        public Nodo(string etiqueta)
        {
            Etiqueta = etiqueta;
            Arcos = new List<Arco>();
        }

        public void AgregarArco(Nodo destino, string etiquetaArco)
        {
            Arcos.Add(new Arco(this, destino, etiquetaArco));
        }
    }


    public class Arco
    {
        public Nodo Origen { get; set; }
        public Nodo Destino { get; set; }
        public string Etiqueta { get; set; }

        public Arco(Nodo origen, Nodo destino, string etiqueta)
        {
            Origen = origen;
            Destino = destino;
            Etiqueta = etiqueta;
        }

        public override string ToString()
        {
            return $"{Origen.Etiqueta} -- {Etiqueta} --> {Destino.Etiqueta}";
        }
    }


    public class RedSemantica
    {
        public List<Nodo> Nodos { get; set; }

        public RedSemantica()
        {
            Nodos = new List<Nodo>();
        }

        public Nodo CrearNodo(string etiqueta)
        {
            var nodo = new Nodo(etiqueta);
            Nodos.Add(nodo);
            return nodo;
        }

        public void MostrarRed()
        {
            foreach (Nodo nodo in Nodos)
            {
                foreach (var arco in nodo.Arcos)
                {
                    Console.WriteLine(arco);
                }
            }
        }
    }
}
