using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio.clase_heredada
{
    internal class rol : VideoJuego
    {
        public int NivelesCompletados { get; set; }
        public int Puntuacion { get; set; }
        
       public void Mover()
        {
            Console.WriteLine("Moviendo elemento");
        }

        public override void AccionPrincipal()
        {
            Console.WriteLine("La accion principal es mover bloques");
        }
    }
    
}
