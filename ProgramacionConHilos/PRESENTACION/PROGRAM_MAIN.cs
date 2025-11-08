using ProgramacionConHilos.ENTIDADES;
using ProgramacionConHilos.LOGICA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionConHilos
{
    public partial class PROGRAM_MAIN : Form
    {

        static CLASE_POBLACION[] Array_Personas = new CLASE_POBLACION[40];
        static int Indice_Persona = 0;
        static int Can_Hombres = 0;
        static int Can_Mujeres = 0;

        CLASE_UTILIDAD Obj_Util = new CLASE_UTILIDAD();

        Thread Obj_T1; // AGRUPAR LAS MUJERES
        Thread Obj_T2; // AGRUPAR LOS HOMBRES
        Thread Obj_T3; // AGRUPAR LAS EDADES SEGÚN EL SEXO DE LAS PERSONAS
        Thread Obj_T4; // AGRUPAR LOS SEXOS SEGÚN LA EDAD DE LAS PERSONAS
        Thread Obj_T5; // AGRUPAR SEGÚN EL NIVEL DE EDUCACIÓN

        public PROGRAM_MAIN()
        {
            InitializeComponent();
        }

        private void PROGRAM_MAIN_Load(object sender, EventArgs e)
        {

        }

        private void BT_SALIR_Click(object sender, EventArgs e)
        {
            
        }
    }
}
