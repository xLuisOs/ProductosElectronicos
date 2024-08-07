using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductosElectronicos
{
    public class Tablet : Movil
    {
        public bool ConectividadTelefono {  get; set; }
        public bool ConectividadStylus { get; set; }

        public Tablet(string nombre, string marca, string modelo, string sistemaOperativo, string almacenamiento, string puertoCarga, int camara, string pantalla, string bateria, bool conectividadTelefono, bool conectividadStylus)
            : base(nombre, marca, modelo, sistemaOperativo, almacenamiento, puertoCarga, camara, pantalla, bateria)
        {
            ConectividadTelefono = conectividadTelefono;
            ConectividadStylus = conectividadStylus;
        }
        public new void MostrarDispositivo()
        {
            base.MostrarDispositivo();
            Console.WriteLine($"Conectividad con Telefono: {ConectividadTelefono}");
            Console.WriteLine($"Conectividad con Stylus / Lapiz: {ConectividadStylus}");
        }
    }
}
