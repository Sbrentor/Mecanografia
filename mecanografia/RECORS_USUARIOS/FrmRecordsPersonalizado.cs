using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MECANOGRAFIA.mecanografia.RECORS_USUARIOS
{
    public partial class FrmRecordsPersonalizado : Form
    {
        clases.helpers h = new clases.helpers();
        clases.db DB = new clases.db();
        public FrmRecordsPersonalizado()
        {
            InitializeComponent();
        }

        private void btnicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listar_datos(string nfile)
        {
            mecanografia.ESCRITURA esc = new mecanografia.ESCRITURA();
            esc = ((mecanografia.ESCRITURA)Owner);
            string prec;
            int ppm, c, i,Lo,LposM,Ladded;
            DateTime fecha;

            if (esc.usuario_sesion != "") {
                DataTable datos = DB.recuperar("RECORDS_PERSONALIZADO", "*", $"NFILE = '{nfile}' AND USUARIO = '{esc.usuario_sesion}'");
                if (datos.Rows.Count > 0)
                {
                    foreach (DataRow r in datos.Rows)
                    {
                        ppm = Convert.ToInt32(r["PPM"]);
                        c = Convert.ToInt32(r["C"]);
                        i = Convert.ToInt32(r["I"]);
                        prec = r["PREC"].ToString();
                        Lo = Convert.ToInt32(r["L_O"]);
                        LposM = Convert.ToInt32(r["L_POS_M"]);
                        Ladded = Convert.ToInt32(r["L_ADDED"]);
                        fecha = Convert.ToDateTime(r["FECHA"]);
                        DGVdatos.Rows.Add(ppm, c, i, prec, Lo, LposM, Ladded, fecha);
                    }
                    datos.Dispose();
                } else h.Warning($"El usuuario {esc.usuario_sesion} no cuenta con registros"); 
            }
        }

        private void FrmRecordsPersonalizado_Load(object sender, EventArgs e)
        {
            mecanografia.ESCRITURA esc = new mecanografia.ESCRITURA();
            esc = ((mecanografia.ESCRITURA)Owner);
            this.Text = " Records Personalizado: " + esc.usuario_sesion;
        }

        private void CMBdificultades_SelectedIndexChanged(object sender, EventArgs e)
        {
            listar_datos(CMBpersonalizado.Text);
        }
    }
}
