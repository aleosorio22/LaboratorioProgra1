using LaboratorioProgra1.EjemploPolimorfismo;
using LaboratorioProgra1.EjemploPolimorfismo.Heredados;
using LaboratorioProgra1.Laboratorio;
using LaboratorioProgra1.Laboratorio.clase_heredada;

static void EjemploPolimorfismo()
{
    Animal[] animales = new Animal[3];
    animales[0] = new Tortuga();
    animales[1] = new Gato();
    animales[2] = new Perro();
    foreach (Animal animal in animales)
    {
        animal.HacerSonido();
    }
}   

static void Laboratorio()
{
    VideoJuego videoJuego = new VideoJuego();
    videoJuego.Titulo = "The Legend of Zelda: Breath of the Wild";
    videoJuego.Desarrolladora = "Nintendo";
    videoJuego.Calificacion = 50;
    videoJuego.AnioLanzamiento = 2017;
    videoJuego.MostrarInformacion();
}

Console.WriteLine("Hola este es el laboratorio");

//Laboratorio();
//VideoJuego.listaDeJuegos();


rol candy = new rol();
candy.Titulo = "Candy Crush";
candy.Desarrolladora = "Soda Sagag";
candy.AnioLanzamiento = 2019;
candy.Calificacion = 50;
candy.MostrarInformacion();

juegoAccion disparos = new juegoAccion();
disparos.ConstructorAccion( 9, ["mp40", "Glock"]);

Console.WriteLine(disparos.ArmasDisponibles);
disparos.Disparar();
Console.WriteLine($"Nivel de dificultad {disparos.NivelDificultad}");