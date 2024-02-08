using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace MECANOGRAFIA.mecanografia.PALABRAS_MAL_ESCRITAS
{
    public partial class FrmP_M_E : Form
    {
        clases.db DB = new clases.db();
        clases.helpers h = new clases.helpers();
        public FrmP_M_E()
        {
            InitializeComponent();
        }

        private void cargardatos()
        {
            mecanografia.ESCRITURA esc = new mecanografia.ESCRITURA();
            esc = ((mecanografia.ESCRITURA)Owner);
            DataTable d = DB.recuperar("LISTA_P_M_E", "*",$"USUARIO = '{esc.usuario_sesion}' AND FECHA = '{DTPfecha.Value}' OR USUARIO = '{esc.usuario_sesion}' OR FECHA = '{DTPfecha.Value}'");
            string p,fec;
            DGVdatos.Rows.Clear();
            if (d.Rows.Count > 0)
            {
                foreach (DataRow r in d.Rows)
                {
                    p = r["P_MAL_E"].ToString();
                    fec = Convert.ToDateTime(r["FECHA"]).ToShortDateString();
                    DGVdatos.Rows.Add(p, fec);
                }
            }else { h.Succes(esc.usuario_sesion + " NO cuenta con palabras mal escritas"); this.Close(); }
        }

        private void FrmP_M_E_Load(object sender, EventArgs e)
        {
            mecanografia.ESCRITURA esc = new mecanografia.ESCRITURA();
            esc = ((mecanografia.ESCRITURA)Owner);
            if (esc.usuario_sesion != string.Empty)
            {
                this.Text = "LISTADO DE PALABRAS MAL ESCRITAS - USUARIO: " + esc.usuario_sesion;
                cargardatos();
            }
            else{ h.Info("Debe Inicar sesion o registrarse"); this.Close();}
        }
    }
}
