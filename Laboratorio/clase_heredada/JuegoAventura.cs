using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.Laboratorio.clase_heredada
{
    internal class JuegoAventura : VideoJuego
    {
        public string Mundo { get; set; }
        public string Misiones { get; set; }

        public void Explorar()
        {
            Console.WriteLine("Explorando nuevo mundo");
        }

        public void CompletarMision()
        {
            Console.WriteLine("Debe completar la mision");
        }

        public override void AccionPrincipal()
        {
            Console.WriteLine("La accion principal es mostrar mapa");
        }
        public JuegoAventura(string mundo, string Misiones)
        {
            Mundo = mundo;
            Misiones = Misiones;
        }
    }
}   
