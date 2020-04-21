//Esta Clase se crea para quitar la responsabilidad a Program de resolver el Formato del Resultado.
//Se utiliza en Patron Expert 

using System;

namespace Library
{
    public class Formato
    {
        
        public static String ChangeFormat(String year)
        {   
            year = QuitaEspacios(year);
            return year.Substring(0, 2)+ "-"  + year.Substring(3, 2) + "-" +year.Substring(6)  ;
        }
//Se agrega Metodo que permite validar el Test creado mediante TDD - TestTextoConEspacios.cs 

        public static string QuitaEspacios(String year)
        { 
            return year.Trim();
            
        }

           
    }
}

