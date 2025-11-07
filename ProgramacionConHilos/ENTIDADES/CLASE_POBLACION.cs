using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionConHilos.ENTIDADES
{
    internal class CLASE_POBLACION
    {

        #region ATRIBUTOS
        public int Edad { get; set; }
        public int Hombres { get; set; }
        public int Mujeres { get; set; }

        public int[] Nivel_Educacion = { 0, 0, 0, 0, 0, 0, 0 };
        #endregion

        public void Poblacion(int PEdad, int PHombres, int PMujeres, int[] PNivel_Educacion)
        {
            Edad = PEdad;
            Hombres = PHombres;
            Mujeres = PMujeres;
            Nivel_Educacion = PNivel_Educacion;
        }
    }
}
