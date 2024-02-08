using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MECANOGRAFIA.mecanografia.RECORS_USUARIOS
{
    public partial class FrmRecordsTematicas : Form
    {
        clases.helpers h = new clases.helpers();
        clases.db DB = new clases.db();
        public FrmRecordsTematicas()
        {
            InitializeComponent();
        }

        private void btnicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listar_tematicas(string tema)
        {
            mecanografia.ESCRITURA esc = new mecanografia.ESCRITURA();
            esc = ((mecanografia.ESCRITURA)Owner);
            DataTable d = DB.recuperar("TEMA", "*", $"USUARIO = '{esc.usuario_sesion}' AND TEMA = '{tema}'");
            int ppm, c, i, LO, LPOS, LA;
            string prec;
            DateTime fec;
            DGVdatos.Rows.Clear();
            if (d.Rows.Count > 0)
            {
                if (tema == "Ciencia y Tecnología" || tema == "Cultura y Entretenimiento" || tema == "Ciencias Sociales" || tema == "Historia y Eventos Actuales" || tema == "Salud y Bienestar" || tema == "Medio Ambiente" || tema == "Educación" || tema == "Tendencias en Estilo de Vida" || tema == "Viajes y Culturas" || tema == "Exploración Espacial" || tema == "misiones espaciales y descubrimientos" || tema == "Tecnologías Emergentes" || tema == "Realidad virtual" || tema == "Blockchain y criptomonedas" || tema == "Desarrollos en robótica y automatización" || tema == "Psicología y Bienestar Mental" || tema == "Nutrición y Alimentación" || tema == "Innovación Empresarial" || tema == "Arquitectura y Diseño Urbano" || tema == "Deportes y Rendimiento Físico" || tema == "Arqueología y Descubrimientos Históricos" || tema == "Desarrollo Personal" || tema == "Ciencia de Datos y Analítica" || tema == "Derechos Humanos y Justicia Social" || tema == "Noticias" || tema == "Literatura" || tema == "Programacion")
                {
                    foreach (DataRow r in d.Rows)
                    {
                        ppm = Convert.ToInt32(r["PPM"].ToString());
                        c = Convert.ToInt32(r["C"].ToString());
                        i = Convert.ToInt32(r["I"].ToString());
                        LO = Convert.ToInt32(r["L_O"].ToString());
                        LPOS = Convert.ToInt32(r["L_POS_M"].ToString());
                        LA = Convert.ToInt32(r["L_ADDED_M"].ToString());
                        prec = r["PRECISION"].ToString();
                        fec = Convert.ToDateTime(r["FECHA"].ToString());
                        DGVdatos.Rows.Add(ppm, c, i, prec,LO, LPOS, LA,fec);
                    }
                    d.Dispose();
                }
            } else h.Warning($"{esc.usuario_sesion} no ha jugado en la tematica {CMBtematicas.Text} por lo tanto no tiene datos");
        }

        private void CMBtematicas_SelectedIndexChanged(object sender, EventArgs e)
        {
            listar_tematicas(CMBtematicas.Text);
        }

        private void FrmRecordsTematicas_Load(object sender, EventArgs e)
        {
            mecanografia.ESCRITURA esc = new mecanografia.ESCRITURA();
            esc = ((mecanografia.ESCRITURA)Owner);
            this.Text = " Records Tematicas: " + esc.usuario_sesion;
        }
    }
}
