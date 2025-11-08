using ProgramacionConHilos.ENTIDADES;
using ProgramacionConHilos.LOGICA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
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

        private void BT_CARGAR_Click(object sender, EventArgs e)
        {
            Leer_Archivo();
            Llenar_DataGrid_P();
        }

        public void Leer_Archivo()
        {
            string DaLine;
            try
            {
                StreamReader Sr_Leer = new StreamReader(@"C:\PADRON\Proyeccion_2025.txt");

                //  Lee la primera línea del archivo
                DaLine = Sr_Leer.ReadLine();

                while (DaLine != null)
                {
                    Obtener_Datos(DaLine);  //  Lee la siguiente línea del archivo
                    DaLine = Sr_Leer.ReadLine();
                }
                Sr_Leer.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error al leer el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Se ha producido un error al leer el archivo: " + ex.Message);
            }
        }
        void Obtener_Datos(String PLinea)
        {
            Array_Personas[Indice_Persona] = new CLASE_POBLACION();
            Array_Personas[Indice_Persona].Edad = int.Parse(PLinea.Substring(0, 3));
            Array_Personas[Indice_Persona].Hombres = int.Parse(PLinea.Substring(3, 6));
            Array_Personas[Indice_Persona].Mujeres = int.Parse(PLinea.Substring(9, 6));

            Console.WriteLine(Array_Personas[Indice_Persona].Edad);
            Console.WriteLine(Array_Personas[Indice_Persona].Hombres);
            Console.WriteLine(Array_Personas[Indice_Persona].Mujeres);

            if (Array_Personas[Indice_Persona].Hombres == 1)
            {
                Can_Hombres += 1;
            }
            else
            {
                Can_Mujeres += 1;
            }
            Indice_Persona += 1;
        }

        private void Llenar_DataGrid_P()
        {
            double Total_Poblacion = 0;
            int Indice_Menor = 0, Indice_Mayor = 0;

            //Dtg_Edades_Sexo.Rows.Clear();
            //Dtg_Escolaridad.Rows.Clear();
            //Dtg_Etareo.Rows.Clear();

            Dtg_Edades_Sexo.Font = new Font("Microsoft Sans Serif", 10);
            Dtg_Edades_Sexo.Columns.Add("EDAD", "EDAD");
            Dtg_Edades_Sexo.Columns.Add("HOMBRES", "HOMBRES");
            Dtg_Edades_Sexo.Columns.Add("MUJERES", "MUJERES");

            Dtg_Edades_Sexo.Columns["EDAD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            for (int i = 0; i < Array_Personas.Length; i++)
            {
                if (Array_Personas[i] != null)
                {
                    Dtg_Edades_Sexo.Rows.Add(Array_Personas[i].Edad, Array_Personas[i].Hombres, Array_Personas[i].Mujeres);
                    if (i == 0)
                    {
                        Indice_Menor = Array_Personas[i].Edad;
                    }
                }
            }
        }
    }
}
