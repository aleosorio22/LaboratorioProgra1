using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio.clase_heredada
{
    internal class juegoAccion : VideoJuego
    {
        public int NivelDificultad {  get; set; }

        public string ArmaDisponible { get; set; } 
        
        public void Disparar()
        {
            Console.WriteLine("Has disparado.");
        }
        public void CambiarArma(string nuevaArma)
        {
            Console.WriteLine("Has cambiado de arma exitosamente.");
        }

        public override void AccionPrincipal()
        {
            Console.WriteLine("La accion principal es disparar");
        }


        public juegoAccion(int nivelDificultad, string armaDisponible1)
        {
            NivelDificultad = nivelDificultad;
            ArmaDisponible = armaDisponible1;
        }
    }
}
