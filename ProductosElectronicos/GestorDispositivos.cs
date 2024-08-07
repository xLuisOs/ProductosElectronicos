using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductosElectronicos
{
    public class GestorDispositivos
    {
        private List<Dispositivo> dispositivos;

        public GestorDispositivos()
        {
            dispositivos = new List<Dispositivo>();
        }

        public void AgregarDispositivo(Dispositivo dispositivo)
        {
            dispositivos.Add(dispositivo);
        }

        public List<Dispositivo> BuscarPorNombre(string nombre)
        {
            List<Dispositivo> resultados = new List<Dispositivo>();
            foreach (var dispositivo in dispositivos)
            {
                if (dispositivo.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    resultados.Add(dispositivo);
                }
            }
            return resultados;
        }

        public void MostrarTodosDispositivos()
        {
            foreach (var dispositivo in dispositivos)
            {
                dispositivo.MostrarDispositivo();
                Console.WriteLine();
            }
        }
    }
}
