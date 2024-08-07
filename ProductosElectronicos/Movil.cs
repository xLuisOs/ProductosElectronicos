using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductosElectronicos
{
    public class Movil : Dispositivo
    {
        public int Camara { get; set; }
        public string Pantalla { get; set; }
        public string Bateria { get; set; }

        public Movil(string nombre, string marca, int modelo, string sistemaOperativo, string almacenamiento, string puertoCarga, int camara, string pantalla, string bateria)
            : base(nombre, marca, modelo, sistemaOperativo, almacenamiento, puertoCarga)
        {
            Camara = camara;
            Pantalla = pantalla;
            Bateria = bateria;
        }

        public override void MostrarDispositivo()
        {
            base.MostrarDispositivo();
            Console.WriteLine($"Camara: {Camara} MegaPixeles");
            Console.WriteLine($"Pantalla: {Pantalla}");
            Console.WriteLine($"Bateria: {Bateria} mAh");
        }
    }

}
