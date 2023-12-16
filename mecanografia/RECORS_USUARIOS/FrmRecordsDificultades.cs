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
    public partial class FrmRecordsDificultades : Form
    {
        clases.helpers h = new clases.helpers();
        clases.db DB = new clases.db();
        public FrmRecordsDificultades()
        {
            InitializeComponent();
        }

        private void listar_datos(string datos = "")
        {
            mecanografia.ESCRITURA esc = new mecanografia.ESCRITURA();
            esc = ((mecanografia.ESCRITURA)Owner);
            DataTable dF = DB.recuperar("RECORDS_DIFICULTADES","*",$"DIFICULTAD = '{datos}' AND USUARIO = '{esc.usuario_sesion}'");
            int ppm, C, IC, LO, LPOS, LA; 
            string prec;
            DateTime fec;
            DGVdatos.Rows.Clear();
            if (esc.usuario_sesion != "")
            {
                if (dF.Rows.Count > 0)
                {
                    if (datos == "FACIL" || datos == "INTERMEDIO" || datos == "DIFICIL")
                    {
                        foreach (DataRow r in dF.Rows)
                        {
                            ppm = Convert.ToInt32(r["PPM"].ToString());
                            C = Convert.ToInt32(r["C"].ToString());
                            IC = Convert.ToInt32(r["I"].ToString());
                            prec = r["PRECISION"].ToString();
                            LO = Convert.ToInt32(r["L_O"].ToString());
                            LPOS = Convert.ToInt32(r["L_POS_M"].ToString());
                            LA = Convert.ToInt32(r["L_ADDED_M"].ToString());
                            fec = Convert.ToDateTime(r["FECHA_JUEGO"].ToString());
                            DGVdatos.Rows.Add(ppm, C, IC, prec, LO, LPOS, LA, fec);
                        }
                        dF.Dispose();
                    }
                }else h.Warning($"{esc.usuario_sesion} no ha jugado en la dificultad {CMBdificultades.Text} por lo tanto no cuenta con registros");
            }else h.Warning("No se ha registrado o iniciado sesion");
        }

        private void FrmRecordsDificultades_Load(object sender, EventArgs e)
        {
            mecanografia.ESCRITURA esc = new mecanografia.ESCRITURA();
            esc = ((mecanografia.ESCRITURA)Owner);
            this.Text = " Records Dificultades: " + esc.usuario_sesion;
            if (esc.usuario_sesion != "") listar_datos(CMBdificultades.Text = "FACIL");
        }

        private void CMBdificultades_SelectedIndexChanged(object sender, EventArgs e)
        {
            listar_datos(CMBdificultades.Text);
        }

        private void btnicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
