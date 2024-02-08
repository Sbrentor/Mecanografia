using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MECANOGRAFIA.mecanografia.DESAFIOS
{
    public partial class FrmPersonalizado : Form
    {
        clases.helpers h = new clases.helpers();
        clases.db DB = new clases.db();
        int correctas = 0, incorrectas = 0, pcompletadas = 0, L_omitidas = 0, L_PosM = 0, L_added = 0, i, j;
        string p, p_escrita,content = "",filePath = "";
        public FrmPersonalizado()
        {
            InitializeComponent();
        }

        private void LetterAddedWrongly()
        {
            List<string> palabras = new List<string>(txtpalabrasmostradas.Text.Trim().Split(' '));
            p = palabras.Count > 0 ? palabras[0] : string.Empty;

            List<string> palabras_escritas = new List<string>(txtpalabrasescritas.Text.Trim().Split(' '));
            p_escrita = palabras_escritas.Count > 0 ? palabras_escritas[0] : string.Empty;

            i = p.Length;
            j = p_escrita.Length;

            while (j > i) { L_added++; j--; }
        }

        private int WrongLetterPosition()
        {
            string[] textshowed = txtpalabrasmostradas.Text.Split();
            string[] TextTyped = txtpalabrasescritas.Text.Split();

            int minLength = Math.Min(textshowed.Length, TextTyped.Length);

            for (i = 0; i < minLength; i++)
            {
                p = textshowed[i];
                p_escrita = TextTyped[i];

                for (j = 0; j < Math.Min(p.Length, p_escrita.Length); j++) { if (p[j] != p_escrita[j]) { L_PosM++; } }
            }
            return L_PosM;
        }

        private void SkippedLetters()
        {
            List<string> palabras = new List<string>(txtpalabrasmostradas.Text.Trim().Split(' '));
            p = palabras.Count > 0 ? palabras[0] : string.Empty;

            List<string> palabras_escritas = new List<string>(txtpalabrasescritas.Text.Trim().Split(' '));
            p_escrita = palabras_escritas.Count > 0 ? palabras_escritas[0] : string.Empty;

            i = p.Length;
            j = p_escrita.Length;

            while (i > j) { L_omitidas++; i--; }
        }

        private void verificar_palabras()
        {
            List<string> palabras = new List<string>(txtpalabrasmostradas.Text.Trim().Split(' '));
            string palabra_mostrada = palabras[0],
            palabra_escrita = txtpalabrasescritas.Text.Trim();

            if (palabra_escrita.Length == palabra_mostrada.Length || palabra_escrita.Length != palabra_mostrada.Length)
            {
                if (palabra_escrita == palabra_mostrada) correctas++;
                else incorrectas++;

                pcompletadas++;
                palabras.RemoveAt(0);
                txtpalabrasmostradas.Text = string.Join(" ", palabras);
            }
        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarfrm()
        {
            txtpalabrasescritas.Enabled = false;
            mecanografia.ESCRITURA esc = new mecanografia.ESCRITURA();
            esc = ((mecanografia.ESCRITURA)Owner);
            this.Text = "Modo Personalizado " + esc.usuario_sesion;
            btnreiniciar.Enabled = false;
        }

        private void FrmPersonalizado_Load(object sender, EventArgs e)
        {
            cargarfrm();
        }

        private void RELOJ_Tick(object sender, EventArgs e)
        {
            int conteo = Convert.ToInt32(lblSEGUNDOS.Text);
            conteo--;
            lblSEGUNDOS.Text = conteo.ToString();
            if (conteo == 0)
            {
                RELOJ.Stop();
                MessageBox.Show("!Se ha agotado el tiempo!");

                ListViewItem item = item = lvPalabras.Items.Add(pcompletadas.ToString());
                item.SubItems.Add(correctas.ToString());
                item.SubItems.Add(incorrectas.ToString());
                item.SubItems.Add(Math.Round(((float)correctas / pcompletadas) * 100, 3).ToString() + "%");
                item.SubItems.Add(L_omitidas.ToString());
                item.SubItems.Add(L_PosM.ToString());
                item.SubItems.Add(L_added.ToString());

                txtpalabrasescritas.Clear();
                lblSEGUNDOS.Text = "60";
                btnIniciar.Enabled = false;
                btnreiniciar.Enabled = true;
                txtpalabrasescritas.Enabled = false;

                string ppm = "", pc = "", pi = "", Lomitida = "", LPosM = "", LAddedM = "";
                foreach (ListViewItem datosLV in lvPalabras.Items)
                {
                    ppm = datosLV.SubItems[0].Text;
                    pc = datosLV.SubItems[1].Text;
                    pi = datosLV.SubItems[2].Text;
                    Lomitida = datosLV.SubItems[4].Text;
                    LPosM = datosLV.SubItems[5].Text;
                    LAddedM = datosLV.SubItems[6].Text;
                }

                mecanografia.ESCRITURA esc = new mecanografia.ESCRITURA();
                esc = ((mecanografia.ESCRITURA)Owner);
                if (esc.usuario_sesion != string.Empty)DB.guardar("RECORDS_PERSONALIZADO", "USUARIO,NFILE,PPM,C,I,PREC,L_O,L_POS_M,L_ADDED",$"'{esc.usuario_sesion}','{Path.GetFileName(filePath)}',{Convert.ToInt32(ppm)},{Convert.ToInt32(pc)},{Convert.ToInt32(pi)},'{Math.Round(((float)correctas / pcompletadas) * 100, 3).ToString() + "%"}',{Convert.ToInt32(Lomitida)},{Convert.ToInt32(LPosM)},{Convert.ToInt32(LAddedM)}");
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (content != "")
            {
                btnIniciar.Enabled = false;
                btnreiniciar.Enabled = false;
                txtpalabrasescritas.Enabled = true;
                txtpalabrasescritas.Focus();
                RELOJ.Start();
                txtpalabrasescritas.Clear();
                correctas = 0;
                incorrectas = 0;
                pcompletadas = 0;
                L_omitidas = 0; L_PosM = 0; L_added = 0;
                lvPalabras.Items.Clear();
            }
            else h.Warning("Presione el boton de buscar texto y seleccione algun texto que tenga");
        }

        private void btnreiniciar_Click(object sender, EventArgs e)
        {
            lblSEGUNDOS.Text = "60";
            btnreiniciar.Enabled = false;
            txtpalabrasescritas.Enabled = true;
            txtpalabrasescritas.Focus();
            txtpalabrasescritas.Clear();
            correctas = 0; incorrectas = 0; pcompletadas = 0; L_omitidas = 0; L_PosM = 0; L_added = 0;
            content = File.ReadAllText(filePath);
            txtpalabrasmostradas.Text = content;
            RELOJ.Start();
        }

        private void txtpalabrasescritas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                WrongLetterPosition();
                SkippedLetters();
                LetterAddedWrongly();
                verificar_palabras();
                txtpalabrasescritas.Clear();
            }
        }

        private void txtpalabrasescritas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = h.goodtyped(e) ? false : true;
        }

        private bool ContienePalabras(string filePath)
        {
            try
            {
                string content = File.ReadAllText(filePath);
                return !string.IsNullOrWhiteSpace(content);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo: {ex.Message}");
                return false;
            }
        }

        private void MostrarPalabrasEnTextBox(string filePath)
        {
            try
            {
                 content = File.ReadAllText(filePath);
                txtpalabrasmostradas.Text = content;
            }
            catch (Exception ex) { h.Warning($"Error al leer el archivo: {ex.Message}"); }
        }

        private void btnsubirtexto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Archivos PDF (*.pdf)|*.pdf|Archivos Word (*.docx)|*.docx";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;

                if (ContienePalabras(filePath)) MostrarPalabrasEnTextBox(filePath);
                else h.Warning("El archivo no contiene palabras.");
            }
        }
    }
}
