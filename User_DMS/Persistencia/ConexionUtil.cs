using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace User_DMS.Persistencia
{
    public class ConexionUtil
    {
        
        public static string ObtenerCadena()
        {
            return "Data Source=9e17d43a-99de-462e-b847-a5aa00e835f7.sqlserver.sequelizer.com;Initial Catalog=db9e17d43a99de462eb847a5aa00e835f7;User ID=wmlbgsuglyhtwmzm;Password=uH8vmfR2iLzbhKJQCGHyxBsvnMkTyjasmd4zrsUWVG2LsUhXwJrt3FeZqLhG37A8;";
            //return "Data Source=LAPTOPTOSHIBA;Initial Catalog=BD_Prestamo;Integrated Security=SSPI;";
        }
        public static string Cadena
        {
            get
            {
                //return "Data Source=9e17d43a-99de-462e-b847-a5aa00e835f7.sqlserver.sequelizer.com;Initial Catalog=db9e17d43a99de462eb847a5aa00e835f7;User ID=wmlbgsuglyhtwmzm;Password=uH8vmfR2iLzbhKJQCGHyxBsvnMkTyjasmd4zrsUWVG2LsUhXwJrt3FeZqLhG37A8;";
                return "Data Source=localhost;Initial Catalog=BD_Usuarios;Integrated Security=SSPI;";
            }
        }
    }
    
}