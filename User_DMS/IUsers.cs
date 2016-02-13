using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using User_DMS.Dominio;

namespace User_DMS
{
    [ServiceContract]
    public interface IUsers
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Users", ResponseFormat = WebMessageFormat.Json)]
        User CrearUser(User alumnoACrear);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Users/{codigo}", ResponseFormat = WebMessageFormat.Json)]
        User ObtenerUser(string codigo);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "Users", ResponseFormat = WebMessageFormat.Json)]
        User ModificarUser(User userAModificar);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "Users/{codigo}", ResponseFormat = WebMessageFormat.Json)]
        void EliminarUser(string codigo);

        [OperationContract]
        [WebInvoke(Method = "SELECT", UriTemplate = "Users", ResponseFormat = WebMessageFormat.Json)]
        List<User> ListarUsers();
    }
}
