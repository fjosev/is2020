using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ControlCalidad.Servidor.Datos;

namespace ControlCalidad.Servidor.Servicio
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ControlCalidadServicio" in both code and config file together.
    public class ControlCalidadServicio : IControlCalidadServicio
    {
        public LineaDto[] GetLineas()
        {
            return Repositorio
                .GetLineas()
                .Select(l => new LineaDto
                {
                    Numero = l.Numero,
                    Descripcion = l.Descripcion
                })
                .ToArray();
        }

        public string[] GetColores()
        {
            throw new NotImplementedException();
        }
    }
}
