using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using semana4progra1MELVIN.entidades;

namespace semana4progra1MELVIN.negocio

{
    public class negociocontador
    {

      public int ContarLetras(entidadcontador entidad)
      {
        return entidad.Texto.Length;
      }  
    }
}