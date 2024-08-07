using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductosElectronicos
{
    public class Ordenador: Dispositivo
    {
        public string Ram {  get; set; }
        public string Procesador { get; set; }
        public string TarjetaGrafica { get; set; }

        public Ordenador(string nombre, string marca, string modelo, string sistemaOperativo, string almacenamiento, string puertoCarga, string ram, string procesador, string tarjetaGrafica)
       : base(nombre, marca, modelo, sistemaOperativo, almacenamiento, puertoCarga)
        {
            Ram = ram;
            Procesador = procesador;
            TarjetaGrafica = tarjetaGrafica;
        }
        public override void MostrarDispositivo()
        {
            base.MostrarDispositivo();
            Console.WriteLine($"RAM: {Ram}");
            Console.WriteLine($"Procesador: {Procesador}");
            Console.WriteLine($"Tarjeta Grafica: {TarjetaGrafica}");
        }
    }
}
