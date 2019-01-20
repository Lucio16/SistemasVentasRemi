﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClases
{
    class CArqueoCaja:CEntidad
    {
        //===============ATRIBUTOS ====================
        //---   Todos heredados de CEntidad        ----
        //=============================================
        //--------constructores -----------------------
        public CArqueoCaja() : base("TArqueoCaja")
        {
        }
        //-------Implementacion de Metodos Abstractos--
        public override string[] NombresAtributos()
        {
            return new string[] { "CodArqueoCaja", "Fecha", "TotalSolesInicio", "TotalSolesFinal","CodUsuario"};
        }
        public override int NroDeClaves()
        {
            return 1;///Falta mejores 
        }
    }
}
