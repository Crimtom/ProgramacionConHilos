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
            MessageBox.Show("DataGrid Principal cargado satisfactoriamente", "DataGrid Principal", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Obj_T1 = new Thread(new ThreadStart(Llenar_DataGrid_E));
            Obj_T2 = new Thread(new ThreadStart(Llenar_DataGrid_ET));

            if (!Obj_T1.IsAlive)
            {
                Obj_T1.Start();
            }
            else
            {
                MessageBox.Show("El hilo de agrupar según sexo y grupo estario ya se está ejecutando. ID: " + Obj_T1.ManagedThreadId, "Hilo en Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (!Obj_T2.IsAlive)
            {
                Obj_T2.Start();
            }
            else
            {
                MessageBox.Show("El hilo de agrupar según escolaridad ya se está ejecutando. ID: " + Obj_T2.ManagedThreadId, "Hilo en Ejecución", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            Array_Personas[Indice_Persona].Edad = int.Parse(PLinea.Substring(0, 2));
            Array_Personas[Indice_Persona].Hombres = int.Parse(PLinea.Substring(2, 7));
            Array_Personas[Indice_Persona].Mujeres = int.Parse(PLinea.Substring(9, 7));


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
            double Total_Poblacion_H = 0, Total_Poblacion_M = 0;
            int Indice_Menor = 0, Indice_Mayor = 0;

            //Dtg_Edades_Sexo.Rows.Clear();
            //Dtg_Escolaridad.Rows.Clear();
            //Dtg_Etareo.Rows.Clear();

            Dtg_Edades_Sexo.Font = new Font("Microsoft Sans Serif", 10);
            Dtg_Edades_Sexo.Columns.Add("EDAD", "EDAD");
            Dtg_Edades_Sexo.Columns.Add("HOMBRES", "HOMBRES");
            Dtg_Edades_Sexo.Columns.Add("MUJERES", "MUJERES");

            Dtg_Edades_Sexo.Columns["EDAD"].DefaultCellStyle.Format = "#,##.##";
            Dtg_Edades_Sexo.Columns["EDAD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            for (int i = 0; i < Array_Personas.Length; i++)
            {
                if (Array_Personas[i] != null)
                {
                    if (Array_Personas[i].Edad <= 60)
                    {
                        Dtg_Edades_Sexo.Rows.Add(Array_Personas[i].Edad, Array_Personas[i].Hombres, Array_Personas[i].Mujeres);
                        Total_Poblacion_H += Array_Personas[i].Hombres;
                        Total_Poblacion_M += Array_Personas[i].Mujeres;
                    }
                }
            }
            /*
            Dtg_Edades_Sexo.Rows.Add("", "         ", "");
            Dtg_Edades_Sexo.Rows.Add("",
                          "*** TOTAL DE HOMBRES ***",
                           Total_Poblacion_H);
            Dtg_Edades_Sexo.Refresh();

            Dtg_Edades_Sexo.Rows.Add("", "         ", "");
            Dtg_Edades_Sexo.Rows.Add("",
                          "*** TOTAL DE MUJERES ***",
                           Total_Poblacion_M);
            Dtg_Edades_Sexo.Refresh();
            */
        }

        private void Llenar_DataGrid_E()
        {
            Dtg_Etareo.Invoke(new Action(() =>
            {
                double TotalH = 0, TotalM = 0;
                double h = 0, m = 0;

                Dtg_Etareo.Font = new Font("Microsoft Sans Serif", 10);

               
                Dtg_Etareo.Rows.Clear();
                Dtg_Etareo.Columns.Clear();

                Dtg_Etareo.Columns.Add("Edades", "Edades");
                Dtg_Etareo.Columns.Add("Hombres", "Hombres");
                Dtg_Etareo.Columns.Add("Mujeres", "Mujeres");
                Dtg_Etareo.Columns.Add("Total Grupo", "Total Grupo");

                
                for (int i = 0; i < Array_Personas.Length; i++)
                {
                    if (Array_Personas[i] != null)
                    {
                        TotalH += Array_Personas[i].Hombres;
                        TotalM += Array_Personas[i].Mujeres;
                    }
                }
                Dtg_Etareo.Rows.Add("Total", TotalH, TotalM, (TotalH + TotalM));


               
                h = 0; m = 0;

                for (int i = 0; i < Array_Personas.Length; i++)
                    if (Array_Personas[i] != null)
                        if (Array_Personas[i].Edad >= 0 && Array_Personas[i].Edad <= 4)
                        { h += Array_Personas[i].Hombres; m += Array_Personas[i].Mujeres; }

                Dtg_Etareo.Rows.Add("0-4", h, m, (h + m));

                for (int edad = 0; edad <= 4; edad++)
                {
                    for (int i = 0; i < Array_Personas.Length; i++)
                        if (Array_Personas[i] != null)
                            if (Array_Personas[i].Edad == edad)
                                Dtg_Etareo.Rows.Add(edad, Array_Personas[i].Hombres, Array_Personas[i].Mujeres, (Array_Personas[i].Hombres + Array_Personas[i].Mujeres));
                }


              
                h = 0; m = 0;
                for (int i = 0; i < Array_Personas.Length; i++)
                    if (Array_Personas[i] != null)
                        if (Array_Personas[i].Edad >= 5 && Array_Personas[i].Edad <= 9)
                        { h += Array_Personas[i].Hombres; m += Array_Personas[i].Mujeres; }

                Dtg_Etareo.Rows.Add("5-9", h, m, (h + m));

                for (int edad = 5; edad <= 9; edad++)
                {
                    for (int i = 0; i < Array_Personas.Length; i++)
                        if (Array_Personas[i] != null)
                            if (Array_Personas[i].Edad == edad)
                                Dtg_Etareo.Rows.Add(edad, Array_Personas[i].Hombres, Array_Personas[i].Mujeres, (Array_Personas[i].Hombres + Array_Personas[i].Mujeres));
                }


               
                h = 0; m = 0;
                for (int i = 0; i < Array_Personas.Length; i++)
                    if (Array_Personas[i] != null)
                        if (Array_Personas[i].Edad >= 10 && Array_Personas[i].Edad <= 14)
                        { h += Array_Personas[i].Hombres; m += Array_Personas[i].Mujeres; }

                Dtg_Etareo.Rows.Add("10-14", h, m, (h + m));

                for (int edad = 10; edad <= 14; edad++)
                {
                    for (int i = 0; i < Array_Personas.Length; i++)
                        if (Array_Personas[i] != null)
                            if (Array_Personas[i].Edad == edad)
                                Dtg_Etareo.Rows.Add(edad, Array_Personas[i].Hombres, Array_Personas[i].Mujeres, (Array_Personas[i].Hombres + Array_Personas[i].Mujeres));
                }


               
                h = 0; m = 0;
                for (int i = 0; i < Array_Personas.Length; i++)
                    if (Array_Personas[i] != null)
                        if (Array_Personas[i].Edad >= 15 && Array_Personas[i].Edad <= 19)
                        { h += Array_Personas[i].Hombres; m += Array_Personas[i].Mujeres; }

                Dtg_Etareo.Rows.Add("15-19", h, m, (h + m));

                for (int edad = 15; edad <= 19; edad++)
                {
                    for (int i = 0; i < Array_Personas.Length; i++)
                        if (Array_Personas[i] != null)
                            if (Array_Personas[i].Edad == edad)
                                Dtg_Etareo.Rows.Add(edad, Array_Personas[i].Hombres, Array_Personas[i].Mujeres, (Array_Personas[i].Hombres + Array_Personas[i].Mujeres));
                }


                
                for (int i = 0; i < Array_Personas.Length; i++)
                    if (Array_Personas[i] != null)
                        if (Array_Personas[i].Edad == 20)
                            Dtg_Etareo.Rows.Add("20-49", Array_Personas[i].Hombres, Array_Personas[i].Mujeres, (Array_Personas[i].Hombres + Array_Personas[i].Mujeres));

             
                for (int i = 0; i < Array_Personas.Length; i++)
                    if (Array_Personas[i] != null)
                        if (Array_Personas[i].Edad == 50)
                            Dtg_Etareo.Rows.Add("50-59", Array_Personas[i].Hombres, Array_Personas[i].Mujeres, (Array_Personas[i].Hombres + Array_Personas[i].Mujeres));

               
                for (int i = 0; i < Array_Personas.Length; i++)
                    if (Array_Personas[i] != null)
                        if (Array_Personas[i].Edad == 60)
                            Dtg_Etareo.Rows.Add("60", Array_Personas[i].Hombres, Array_Personas[i].Mujeres, (Array_Personas[i].Hombres + Array_Personas[i].Mujeres));

                Dtg_Etareo.Refresh();
            }));






        }

        private void Llenar_DataGrid_ET()
        {

        }

        private void Dtg_Etareo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
