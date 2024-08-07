using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProductosElectronicos
{
    public class Dispositivo
    {
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public int Modelo { get; set; }
        public string SistemaOperativo { get; set; }
        public string Almacenamiento { get; set; }
        public string PuertoCarga { get; set; }

        public Dispositivo(string nombre, string marca, int modelo, string sistemaOperativo, string almacenamiento, string puertoCarga)
        {
            Nombre = nombre;
            Marca = marca;
            Modelo = modelo;
            SistemaOperativo = sistemaOperativo;
            Almacenamiento = almacenamiento;
            PuertoCarga = puertoCarga;
        }
        public virtual void MostrarDispositivo()
        {
            Console.WriteLine($"{Nombre}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Sistema Operativo: {SistemaOperativo}");
            Console.WriteLine($"Almacenamiento: {Almacenamiento}");
            Console.WriteLine($"Puerto de Carga: {PuertoCarga}");
        }
    }
}
