using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using User_DMS.Dominio;
using User_DMS.Persistencia;

namespace User_DMS
{
    public class Users : IUsers
    {
        private UserDAO dao = new UserDAO();

        public User CrearUser(User alumnoACrear)
        {
            return dao.Crear(alumnoACrear);
        }

        public void EliminarUser(string codigo)
        {
            dao.Eliminar(codigo);
        }

        public List<User> ListarUsers()
        {
            return dao.ListarTodos();
        }

        public User ModificarUser(User userAModificar)
        {
            return dao.Modificar(userAModificar);
        }

        public User ObtenerUser(string codigo)
        {
            User userObtenido = dao.Obtener(codigo);
            if (userObtenido == null)
            {
                throw new WebFaultException<string>(
                    "Usuario no válido", HttpStatusCode.InternalServerError);
            }
            return userObtenido;
        }
    }
}
