namespace MECANOGRAFIA.mecanografia.DESAFIOS
{
    partial class FrmPersonalizado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonalizado));
            this.txtpalabrasescritas = new System.Windows.Forms.TextBox();
            this.lvPalabras = new System.Windows.Forms.ListView();
            this.PALABRAS_POR_MINUTO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PCORRECTAS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PINCORRECTAS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLPRECISION = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLletrasomitidas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLLetraPosIncorrecta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLletraAggIncorrecta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BTNsalir = new System.Windows.Forms.ToolStripButton();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtpalabrasmostradas = new System.Windows.Forms.TextBox();
            this.lblSEGUNDOS = new System.Windows.Forms.Label();
            this.RELOJ = new System.Windows.Forms.Timer(this.components);
            this.btnsubirtexto = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnreiniciar = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtpalabrasescritas
            // 
            this.txtpalabrasescritas.BackColor = System.Drawing.Color.SteelBlue;
            this.txtpalabrasescritas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpalabrasescritas.Font = new System.Drawing.Font("Humnst777 Blk BT", 15.75F);
            this.txtpalabrasescritas.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtpalabrasescritas.Location = new System.Drawing.Point(15, 101);
            this.txtpalabrasescritas.MaxLength = 29;
            this.txtpalabrasescritas.Multiline = true;
            this.txtpalabrasescritas.Name = "txtpalabrasescritas";
            this.txtpalabrasescritas.Size = new System.Drawing.Size(394, 33);
            this.txtpalabrasescritas.TabIndex = 32;
            this.txtpalabrasescritas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpalabrasescritas_KeyDown);
            this.txtpalabrasescritas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpalabrasescritas_KeyPress);
            // 
            // lvPalabras
            // 
            this.lvPalabras.BackColor = System.Drawing.Color.SteelBlue;
            this.lvPalabras.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PALABRAS_POR_MINUTO,
            this.PCORRECTAS,
            this.PINCORRECTAS,
            this.CLPRECISION,
            this.CLletrasomitidas,
            this.CLLetraPosIncorrecta,
            this.CLletraAggIncorrecta});
            this.lvPalabras.Enabled = false;
            this.lvPalabras.Font = new System.Drawing.Font("Humnst777 Blk BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPalabras.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPalabras.HideSelection = false;
            this.lvPalabras.LabelWrap = false;
            this.lvPalabras.Location = new System.Drawing.Point(32, 161);
            this.lvPalabras.Name = "lvPalabras";
            this.lvPalabras.Size = new System.Drawing.Size(440, 130);
            this.lvPalabras.TabIndex = 31;
            this.lvPalabras.UseCompatibleStateImageBehavior = false;
            this.lvPalabras.View = System.Windows.Forms.View.Details;
            // 
            // PALABRAS_POR_MINUTO
            // 
            this.PALABRAS_POR_MINUTO.Text = "PPM";
            this.PALABRAS_POR_MINUTO.Width = 37;
            // 
            // PCORRECTAS
            // 
            this.PCORRECTAS.Text = "✔";
            this.PCORRECTAS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PCORRECTAS.Width = 30;
            // 
            // PINCORRECTAS
            // 
            this.PINCORRECTAS.Text = "❌";
            this.PINCORRECTAS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PINCORRECTAS.Width = 30;
            // 
            // CLPRECISION
            // 
            this.CLPRECISION.Text = "PREC";
            this.CLPRECISION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CLPRECISION.Width = 80;
            // 
            // CLletrasomitidas
            // 
            this.CLletrasomitidas.Text = "Letra Omitida";
            this.CLletrasomitidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CLletrasomitidas.Width = 91;
            // 
            // CLLetraPosIncorrecta
            // 
            this.CLLetraPosIncorrecta.Text = "Letra POS ❌";
            this.CLLetraPosIncorrecta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CLLetraPosIncorrecta.Width = 82;
            // 
            // CLletraAggIncorrecta
            // 
            this.CLletraAggIncorrecta.Text = "Letra Agg ❌";
            this.CLletraAggIncorrecta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CLletraAggIncorrecta.Width = 81;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Lavender;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTNsalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(623, 28);
            this.toolStrip1.TabIndex = 30;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BTNsalir
            // 
            this.BTNsalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNsalir.Image = global::MECANOGRAFIA.Properties.Resources.exit_24px;
            this.BTNsalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNsalir.Name = "BTNsalir";
            this.BTNsalir.Size = new System.Drawing.Size(73, 25);
            this.BTNsalir.Text = "SALIR";
            this.BTNsalir.Click += new System.EventHandler(this.BTNsalir_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(436, 127);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(104, 31);
            this.lbl1.TabIndex = 28;
            this.lbl1.Text = "Tiempo";
            // 
            // txtpalabrasmostradas
            // 
            this.txtpalabrasmostradas.BackColor = System.Drawing.Color.SteelBlue;
            this.txtpalabrasmostradas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpalabrasmostradas.Cursor = System.Windows.Forms.Cursors.No;
            this.txtpalabrasmostradas.Enabled = false;
            this.txtpalabrasmostradas.Font = new System.Drawing.Font("Humnst777 Blk BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpalabrasmostradas.Location = new System.Drawing.Point(3, 29);
            this.txtpalabrasmostradas.MaxLength = 1000000000;
            this.txtpalabrasmostradas.Multiline = true;
            this.txtpalabrasmostradas.Name = "txtpalabrasmostradas";
            this.txtpalabrasmostradas.ReadOnly = true;
            this.txtpalabrasmostradas.ShortcutsEnabled = false;
            this.txtpalabrasmostradas.Size = new System.Drawing.Size(617, 66);
            this.txtpalabrasmostradas.TabIndex = 25;
            this.txtpalabrasmostradas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSEGUNDOS
            // 
            this.lblSEGUNDOS.AutoSize = true;
            this.lblSEGUNDOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSEGUNDOS.ForeColor = System.Drawing.Color.White;
            this.lblSEGUNDOS.Location = new System.Drawing.Point(468, 97);
            this.lblSEGUNDOS.Name = "lblSEGUNDOS";
            this.lblSEGUNDOS.Size = new System.Drawing.Size(44, 31);
            this.lblSEGUNDOS.TabIndex = 27;
            this.lblSEGUNDOS.Text = "60";
            // 
            // RELOJ
            // 
            this.RELOJ.Interval = 1000;
            this.RELOJ.Tick += new System.EventHandler(this.RELOJ_Tick);
            // 
            // btnsubirtexto
            // 
            this.btnsubirtexto.FlatAppearance.BorderSize = 0;
            this.btnsubirtexto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubirtexto.ForeColor = System.Drawing.Color.White;
            this.btnsubirtexto.Location = new System.Drawing.Point(460, 337);
            this.btnsubirtexto.Name = "btnsubirtexto";
            this.btnsubirtexto.Size = new System.Drawing.Size(151, 33);
            this.btnsubirtexto.TabIndex = 33;
            this.btnsubirtexto.Text = "CARGAR TEXTO";
            this.btnsubirtexto.UseVisualStyleBackColor = true;
            this.btnsubirtexto.Click += new System.EventHandler(this.btnsubirtexto_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Image = global::MECANOGRAFIA.Properties.Resources.boton_de_play;
            this.btnIniciar.Location = new System.Drawing.Point(541, 100);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(34, 33);
            this.btnIniciar.TabIndex = 29;
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnreiniciar
            // 
            this.btnreiniciar.FlatAppearance.BorderSize = 0;
            this.btnreiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreiniciar.Image = global::MECANOGRAFIA.Properties.Resources.sincronizacion;
            this.btnreiniciar.Location = new System.Drawing.Point(580, 101);
            this.btnreiniciar.Name = "btnreiniciar";
            this.btnreiniciar.Size = new System.Drawing.Size(31, 33);
            this.btnreiniciar.TabIndex = 26;
            this.btnreiniciar.UseVisualStyleBackColor = true;
            this.btnreiniciar.Click += new System.EventHandler(this.btnreiniciar_Click);
            // 
            // FrmPersonalizado
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(623, 372);
            this.Controls.Add(this.btnsubirtexto);
            this.Controls.Add(this.txtpalabrasescritas);
            this.Controls.Add(this.lvPalabras);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtpalabrasmostradas);
            this.Controls.Add(this.btnreiniciar);
            this.Controls.Add(this.lblSEGUNDOS);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPersonalizado";
            this.Text = "Modo Personalizado";
            this.Load += new System.EventHandler(this.FrmPersonalizado_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpalabrasescritas;
        private System.Windows.Forms.ListView lvPalabras;
        private System.Windows.Forms.ColumnHeader PALABRAS_POR_MINUTO;
        private System.Windows.Forms.ColumnHeader PCORRECTAS;
        private System.Windows.Forms.ColumnHeader PINCORRECTAS;
        private System.Windows.Forms.ColumnHeader CLPRECISION;
        private System.Windows.Forms.ColumnHeader CLletrasomitidas;
        private System.Windows.Forms.ColumnHeader CLLetraPosIncorrecta;
        private System.Windows.Forms.ColumnHeader CLletraAggIncorrecta;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BTNsalir;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtpalabrasmostradas;
        private System.Windows.Forms.Button btnreiniciar;
        private System.Windows.Forms.Label lblSEGUNDOS;
        private System.Windows.Forms.Timer RELOJ;
        private System.Windows.Forms.Button btnsubirtexto;
    }
}