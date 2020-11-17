using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ControlCalidad.Servidor.Servicio
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IControlCalidadServicio" in both code and config file together.
    [ServiceContract]
    public interface IControlCalidadServicio
    {
        [OperationContract]
        LineaDto[] GetLineas();

        [OperationContract]
        string[] GetColores();

        [OperationContract]
        bool CrearOp(OpDto op);
    }
}
