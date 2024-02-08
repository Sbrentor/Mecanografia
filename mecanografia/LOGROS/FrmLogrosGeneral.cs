using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MECANOGRAFIA.mecanografia.LOGROS
{
    public partial class FrmLogrosGeneral : Form
    {
        clases.helpers h = new clases.helpers();
        clases.db DB = new clases.db();
        DataTable datos;
        int ppm,pc;
        string logro;
        public FrmLogrosGeneral()
        {
            InitializeComponent();
        }

        private void disablePBS()
        {
            PBppm10.Visible = false;
            PBppm20.Visible = false;
            PBppm30.Visible = false;
            PBppm40.Visible = false;
            PBppm50.Visible = false;
            PBppm60.Visible = false;
            PBppm70.Visible = false;
            PBppm80.Visible = false;
            PBppm90.Visible = false;
            PBppm100.Visible = false;
            PBppm120.Visible = false;
            PBppm140.Visible = false;
            PBppm150.Visible = false;
        }

        private void disableCPBS() {
            FLPpc.Visible = false;
            PBC10.Visible = false;
            PBC20.Visible = false;
            PBC30.Visible = false;
            PBC40.Visible = false;
            PBC50.Visible = false;
            PBC60.Visible = false;
            PBC70.Visible = false;
            PBC80.Visible = false;
            PBC90.Visible = false;
            PBC100.Visible = false;
        }

        private void show_Correctw()
        {
            mecanografia.ESCRITURA esc = new mecanografia.ESCRITURA();
            esc = ((mecanografia.ESCRITURA)Owner);
            datos = DB.recuperar("LOGROS_USUARIOS", "*", $"USUARIO = '{esc.usuario_sesion}'");
            if (datos.Rows.Count > 0){
                FLPpc.Location = new Point(3, 264);
                foreach (DataRow r in datos.Rows){
                    pc = Convert.ToInt32(r["CANT"]);
                    logro = Convert.ToString(r["LOGRO"]);
                    if      (pc == 10 && logro == "PC")  { PBC10.Visible = true; this.Size = new Size(835, 418); }
                    else if (pc == 20 && logro == "PC")  { PBC20.Visible = true; this.Size = new Size(835, 418); }
                    else if (pc == 30 && logro == "PC")  { PBC30.Visible = true; this.Size = new Size(835, 418); }
                    else if (pc == 40 && logro == "PC")  { PBC40.Visible = true; this.Size = new Size(835, 418); }
                    else if (pc == 50 && logro == "PC")  { PBC50.Visible = true; this.Size = new Size(835, 418); }
                    else if (pc == 60 && logro == "PC")  { PBC60.Visible = true; this.Size = new Size(835, 528); }
                    else if (pc == 70 && logro == "PC")  { PBC70.Visible = true; this.Size = new Size(835, 528); }
                    else if (pc == 80 && logro == "PC")  { PBC80.Visible = true; this.Size = new Size(835, 528); }
                    else if (pc == 90 && logro == "PC")  { PBC90.Visible = true; this.Size = new Size(835, 528); }
                    else if (pc == 100 && logro == "PC") { PBC100.Visible = true; this.Size = new Size(835, 528); }
                }datos.Dispose();
            }
            else{
                disablePBS();
                disableCPBS();
                this.Size = new Size(835, 300);
                h.Warning($"{esc.usuario_sesion} no cuenta con con ningun logro de palabras correctas");
            }
        }

        private void show_achievments()
        {
            mecanografia.ESCRITURA esc = new mecanografia.ESCRITURA();
            esc = ((mecanografia.ESCRITURA)Owner);
            datos = DB.recuperar("LOGROS_USUARIOS", "*", $"USUARIO = '{esc.usuario_sesion}'");
            if (datos.Rows.Count > 0){
                foreach (DataRow r in datos.Rows){
                    ppm = Convert.ToInt32(r["CANT"]);
                    logro = Convert.ToString(r["LOGRO"]);
                    if      (ppm == 10 && logro == "PPM")  { PBppm10.Visible = true; this.Size = new Size(835, 418); }
                    else if (ppm == 20 && logro == "PPM")  { PBppm20.Visible = true; this.Size = new Size(835, 418); }
                    else if (ppm == 30 && logro == "PPM")  { PBppm30.Visible = true; this.Size = new Size(835, 418); }
                    else if (ppm == 40 && logro == "PPM")  { PBppm40.Visible = true; this.Size = new Size(835, 418); }
                    else if (ppm == 50 && logro == "PPM")  { PBppm50.Visible = true; this.Size = new Size(835, 418); }
                    else if (ppm == 60 && logro == "PPM")  { PBppm60.Visible = true; this.Size = new Size(835, 528); }
                    else if (ppm == 70 && logro == "PPM")  { PBppm70.Visible = true; this.Size = new Size(835, 528); }
                    else if (ppm == 80 && logro == "PPM")  { PBppm80.Visible = true; this.Size = new Size(835, 528); }
                    else if (ppm == 90 && logro == "PPM")  { PBppm90.Visible = true; this.Size = new Size(835, 528); }
                    else if (ppm == 100 && logro == "PPM") { PBppm100.Visible = true; this.Size = new Size(835, 528); }
                    else if (ppm == 120 && logro == "PPM") { PBppm120.Visible = true; this.Size = new Size(835, 650); }
                    else if (ppm == 140 && logro == "PPM") { PBppm140.Visible = true; this.Size = new Size(835, 650); }
                    else if (ppm == 150 && logro == "PPM") { PBppm150.Visible = true; this.Size = new Size(835, 650); }
                }datos.Dispose();
            }
            else{
                disablePBS();
                disableCPBS();
                this.Size = new Size(835, 300);
                h.Warning($"{esc.usuario_sesion} no cuenta con logros");
            }
        }

        private void FrmLogrosGeneral_Load(object sender, EventArgs e)
        {
            mecanografia.ESCRITURA esc = new mecanografia.ESCRITURA();
            esc = ((mecanografia.ESCRITURA)Owner);
            if (esc.usuario_sesion != string.Empty){
                disableCPBS();
                disablePBS();
                this.Size = new Size(835, 300);
                PBTittleLogros.Visible = true;
                this.Text = "LOGROS: " + esc.usuario_sesion;
                show_achievments();
            }else{
                //disablePBS();
                //disableCPBS();
                //this.Size = new Size(835, 300);
                this.Close();
                h.Warning("Debe registrarse o inciar sesion para ver sus logros");
            }
        }

        private void PBppm10_MouseHover(object sender, EventArgs e)
        {
            h.Info("Logro por hacer 10 palabras por minuto");
        }

        private void PBppm20_MouseHover(object sender, EventArgs e)
        {
            h.Info("Logro por hacer 20 palabras por minuto");
        }

        private void PBppm30_MouseHover(object sender, EventArgs e)
        {
            h.Info("Logro por hacer 30 palabras por minuto");
        }

        private void PBppm40_MouseHover(object sender, EventArgs e)
        {
            h.Info("Logro por hacer 40 palabras por minuto");
        }

        private void PBppm50_MouseHover(object sender, EventArgs e)
        {
            h.Info("Logro por hacer 50 palabras por minuto");
        }

        private void PBppm60_MouseHover(object sender, EventArgs e)
        {
            h.Info("Logro por hacer 60 palabras por minuto");
        }

        private void PBppm70_MouseHover(object sender, EventArgs e)
        {
            h.Info("Logro por hacer 70 palabras por minuto");
        }

        private void PBppm80_MouseHover(object sender, EventArgs e)
        {
            h.Info("Logro por hacer 80 palabras por minuto");
        }

        private void PBppm90_MouseHover(object sender, EventArgs e)
        {
            h.Info("Logro por hacer 90 palabras por minuto");
        }

        private void PBppm100_MouseHover(object sender, EventArgs e)
        {
            h.Info("Logro por hacer 100 palabras por minuto");
        }

        private void PBppm120_MouseHover(object sender, EventArgs e)
        {
            h.Info("Logro por hacer 120 palabras por minuto");
        }

        private void PBppm140_MouseHover(object sender, EventArgs e)
        {
            h.Info("Logro por hacer 140 palabras por minuto");
        }

        private void PBppm150_MouseHover(object sender, EventArgs e)
        {
            h.Info("Logro por hacer 150 palabras por minuto");
        }

        private void PBC10_MouseHover(object sender, EventArgs e)
        {
            h.Info("Logro por hacer 10 palabras por minuto Correctas");
        }

        private void PBC20_MouseHover(object sender, EventArgs e)
        {
            h.Info("Logro por hacer 20 palabras por minuto Correctas");
        }

        private void PBC30_MouseHover(object sender, EventArgs e)
        {
            h.Info("Logro por hacer 30 palabras por minuto Correctas");
        }

        private void PBC40_MouseHover(object sender, EventArgs e)
        {
            h.Info("Logro por hacer 40 palabras por minuto Correctas");
        }

        private void PBC50_MouseHover(object sender, EventArgs e)
        {
            h.Info("Logro por hacer 50 palabras por minuto Correctas");
        }

        private void PBC60_MouseHover(object sender, EventArgs e)
        {
            h.Info("Logro por hacer 60 palabras por minuto Correctas");
        }

        private void PBC70_MouseHover(object sender, EventArgs e)
        {
            h.Info("Logro por hacer 70 palabras por minuto Correctas");
        }

        private void PBC80_MouseHover(object sender, EventArgs e)
        {
            h.Info("Logro por hacer 80 palabras por minuto Correctas");
        }

        private void PBC90_MouseHover(object sender, EventArgs e)
        {
            h.Info("Logro por hacer 90 palabras por minuto Correctas");
        }

        private void PBC100_MouseHover(object sender, EventArgs e)
        {
            h.Info("Logro por hacer 100 palabras por minuto Correctas");
        }

        private void PBTittleLogros_Click_1(object sender, EventArgs e)
        {
            if (FLPLogrosppm.Visible == true)
            {
                mecanografia.ESCRITURA esc = new mecanografia.ESCRITURA();
                esc = ((mecanografia.ESCRITURA)Owner);

                if (esc.usuario_sesion == string.Empty) h.Info("Debe iniciar sesion para ver sus logros");
                else {
                    FLPLogrosppm.Visible = false;
                    FLPpc.Visible = true;
                    FLPpc.Location = new Point(3, 264);
                    show_Correctw(); 
                }
            }
            else if (FLPpc.Visible == true)
            {
                mecanografia.ESCRITURA esc = new mecanografia.ESCRITURA();
                esc = ((mecanografia.ESCRITURA)Owner);
                if (esc.usuario_sesion == string.Empty) h.Info("Debe iniciar sesion para ver sus logros ");
                else{
                    FLPpc.Visible = false;
                    FLPLogrosppm.Visible = true;
                    FLPLogrosppm.Location = new Point(3, 264);
                    show_achievments(); 
                }
            }
        }
    }
}
