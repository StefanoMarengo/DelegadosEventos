using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventosDelegados
{
    public class NombreEventArgs : EventArgs
    {
        public string NombreAntiguo { get; set; }
        public string NombreNuevo { get; set; }
        public NombreEventArgs(string nombreAntiguo, string nombreNuevo)
        {
            NombreAntiguo = nombreAntiguo;
            NombreNuevo = nombreNuevo;
        }
    }
    public class Persona
    {
        private string Nombre { get; set; }
        public EventHandler<NombreEventArgs> NombreModificado;
        public bool ActualizacionNombre(string nuevoNombre)
        {
            string nombreAntiguo = this.Nombre;
            Nombre = nuevoNombre;
            this.NombreModificado(this, new NombreEventArgs(nombreAntiguo, Nombre));
            return true;
        }

        public void setNombre(string nombre)
        {
            this.Nombre = nombre;
        }

    }
}
