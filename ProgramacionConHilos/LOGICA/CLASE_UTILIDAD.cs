using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionConHilos.LOGICA
{
    internal class CLASE_UTILIDAD
    {
        public int Salir()
        {
            if (MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Application.Exit();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Grabar()
        {
            if (MessageBox.Show("¿Desea grabar el registro?", "Grabar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int Borrar()
        {
            if (MessageBox.Show("¿Desea borrar el registro?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void Mensaje(string Mensaje)
        {
            MessageBox.Show(Mensaje, "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
