using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductosElectronicos
{
    public class Telefono : Movil
    {
        public string Company { get; set; }
        public int RanuraSim { get; set; }
        public int RanuraSD { get; set; }

        public Telefono(string nombre, string marca, int modelo, string sistemaOperativo, string almacenamiento, string puertoCarga, int camara, string pantalla, string bateria, string company, int ranuraSim, int ranuraSD)
            : base(nombre, marca, modelo, sistemaOperativo, almacenamiento, puertoCarga, camara, pantalla, bateria)
        {
            Company = company;
            RanuraSim = ranuraSim;
            RanuraSD = ranuraSD;
        }

        public override void MostrarDispositivo()
        {
            base.MostrarDispositivo();
            Console.WriteLine($"Compañía Telefónica: {Company}");
            Console.WriteLine($"Ranuras SIM: {RanuraSim}");
            Console.WriteLine($"Ranuras SD: {RanuraSD}");
        }
    }

}
