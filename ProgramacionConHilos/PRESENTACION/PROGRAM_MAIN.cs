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
            try
            {
                if (Obj_Util.Salir() == 1)
                {
                    if (Obj_T1 != null)
                    {
                        if (Obj_T1.ThreadState == ThreadState.WaitSleepJoin)
                            Obj_Util.Mensaje("El Hilo de Agrupar Mujeres esta en Ejecución, No se puede Salir del Programa");

                        if (Obj_T2 != null)
                            if ((Obj_T2.ThreadState == ThreadState.WaitSleepJoin) && (Obj_T1 != null))
                                Obj_Util.Mensaje("El Hilo de Agrupar Hombres esta en Ejecución, No se puede Salir del Programa");

                        if (Obj_T3 != null)
                            if ((Obj_T3.ThreadState == ThreadState.WaitSleepJoin) && (Obj_T1 != null))
                                Obj_Util.Mensaje("El Hilo de Agrupar las edades según el sexo de las personas esta en Ejecución, No se puede Salir del Programa");

                        if (Obj_T4 != null)
                            if ((Obj_T4.ThreadState == ThreadState.WaitSleepJoin) && (Obj_T1 != null))
                                Obj_Util.Mensaje("El Hilo de Agrupar los sexos según las edades de las personas esta en Ejecución, No se puede Salir del Programa");


                        if (Obj_T5 != null)
                            if ((Obj_T5.ThreadState == ThreadState.WaitSleepJoin) && (Obj_T1 != null))
                                Obj_Util.Mensaje("El Hilo de Agrupar a las personas según su nivel su escolaridad esta en Ejecución, No se puede Salir del Programa");
                            else
                                this.Dispose();
                    }
                    else
                    {
                        this.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error tras intentar cerrar el programa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }
    }
}
