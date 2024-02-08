namespace MECANOGRAFIA.mecanografia.DESAFIOS
{
    partial class FrmTematicasV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTematicasV));
            this.label1 = new System.Windows.Forms.Label();
            this.CMBtematicas = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BTNsalir = new System.Windows.Forms.ToolStripButton();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtpalabrasescritas = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtpalabrasmostradas = new System.Windows.Forms.TextBox();
            this.btnreiniciar = new System.Windows.Forms.Button();
            this.lblSEGUNDOS = new System.Windows.Forms.Label();
            this.RELOJ = new System.Windows.Forms.Timer(this.components);
            this.lvPalabras = new System.Windows.Forms.ListView();
            this.PALABRAS_POR_MINUTO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PCORRECTAS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PINCORRECTAS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLPRECISION = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLletrasomitidas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLLetraPosIncorrecta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLletraAggIncorrecta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "Escoger Tematica";
            // 
            // CMBtematicas
            // 
            this.CMBtematicas.BackColor = System.Drawing.Color.SteelBlue;
            this.CMBtematicas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBtematicas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CMBtematicas.FormattingEnabled = true;
            this.CMBtematicas.Items.AddRange(new object[] {
            "Ciencia y Tecnología",
            "Cultura y Entretenimiento",
            "Ciencias Sociales",
            "Historia y Eventos Actuales",
            "Salud y Bienestar",
            "Medio Ambiente",
            "Educación",
            "Tendencias en Estilo de Vida",
            "Viajes y Culturas",
            "Exploración Espacial",
            "misiones espaciales y descubrimientos",
            "Tecnologías Emergentes",
            "Realidad virtual",
            "Blockchain y criptomonedas",
            "Desarrollos en robótica y automatización",
            "Psicología y Bienestar Mental",
            "Nutrición y Alimentación",
            "Innovación Empresarial",
            "Arquitectura y Diseño Urbano",
            "Deportes y Rendimiento Físico",
            "Arqueología y Descubrimientos Históricos",
            "Desarrollo Personal",
            "Ciencia de Datos y Analítica",
            "Derechos Humanos y Justicia Social",
            "Noticias",
            "Literatura",
            "Programacion"});
            this.CMBtematicas.Location = new System.Drawing.Point(18, 323);
            this.CMBtematicas.Name = "CMBtematicas";
            this.CMBtematicas.Size = new System.Drawing.Size(273, 29);
            this.CMBtematicas.TabIndex = 21;
            this.CMBtematicas.SelectedIndexChanged += new System.EventHandler(this.CMBdificultades_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTNsalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(619, 28);
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
            // btnIniciar
            // 
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Image = global::MECANOGRAFIA.Properties.Resources.boton_de_play;
            this.btnIniciar.Location = new System.Drawing.Point(538, 102);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(34, 33);
            this.btnIniciar.TabIndex = 29;
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtpalabrasescritas
            // 
            this.txtpalabrasescritas.BackColor = System.Drawing.Color.SteelBlue;
            this.txtpalabrasescritas.Font = new System.Drawing.Font("Humnst777 Blk BT", 15.75F);
            this.txtpalabrasescritas.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtpalabrasescritas.Location = new System.Drawing.Point(19, 102);
            this.txtpalabrasescritas.MaxLength = 29;
            this.txtpalabrasescritas.Multiline = true;
            this.txtpalabrasescritas.Name = "txtpalabrasescritas";
            this.txtpalabrasescritas.Size = new System.Drawing.Size(411, 33);
            this.txtpalabrasescritas.TabIndex = 24;
            this.txtpalabrasescritas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpalabrasescritas_KeyDown);
            this.txtpalabrasescritas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpalabrasescritas_KeyPress);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(438, 125);
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
            this.txtpalabrasmostradas.Location = new System.Drawing.Point(0, 31);
            this.txtpalabrasmostradas.MaxLength = 1000000000;
            this.txtpalabrasmostradas.Multiline = true;
            this.txtpalabrasmostradas.Name = "txtpalabrasmostradas";
            this.txtpalabrasmostradas.ReadOnly = true;
            this.txtpalabrasmostradas.ShortcutsEnabled = false;
            this.txtpalabrasmostradas.Size = new System.Drawing.Size(617, 66);
            this.txtpalabrasmostradas.TabIndex = 23;
            this.txtpalabrasmostradas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnreiniciar
            // 
            this.btnreiniciar.FlatAppearance.BorderSize = 0;
            this.btnreiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreiniciar.Image = global::MECANOGRAFIA.Properties.Resources.sincronizacion;
            this.btnreiniciar.Location = new System.Drawing.Point(575, 102);
            this.btnreiniciar.Name = "btnreiniciar";
            this.btnreiniciar.Size = new System.Drawing.Size(31, 33);
            this.btnreiniciar.TabIndex = 26;
            this.btnreiniciar.UseVisualStyleBackColor = true;
            this.btnreiniciar.Click += new System.EventHandler(this.btnreiniciar_Click);
            // 
            // lblSEGUNDOS
            // 
            this.lblSEGUNDOS.AutoSize = true;
            this.lblSEGUNDOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSEGUNDOS.ForeColor = System.Drawing.Color.White;
            this.lblSEGUNDOS.Location = new System.Drawing.Point(471, 98);
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
            this.lvPalabras.Location = new System.Drawing.Point(4, 141);
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
            // FrmTematicasV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(619, 355);
            this.Controls.Add(this.lvPalabras);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtpalabrasescritas);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtpalabrasmostradas);
            this.Controls.Add(this.btnreiniciar);
            this.Controls.Add(this.lblSEGUNDOS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CMBtematicas);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTematicasV";
            this.Text = "Tematicas";
            this.Load += new System.EventHandler(this.FrmTematicasV_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CMBtematicas;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BTNsalir;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtpalabrasescritas;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtpalabrasmostradas;
        private System.Windows.Forms.Button btnreiniciar;
        private System.Windows.Forms.Label lblSEGUNDOS;
        private System.Windows.Forms.Timer RELOJ;
        private System.Windows.Forms.ListView lvPalabras;
        private System.Windows.Forms.ColumnHeader PALABRAS_POR_MINUTO;
        private System.Windows.Forms.ColumnHeader PCORRECTAS;
        private System.Windows.Forms.ColumnHeader PINCORRECTAS;
        private System.Windows.Forms.ColumnHeader CLPRECISION;
        private System.Windows.Forms.ColumnHeader CLletrasomitidas;
        private System.Windows.Forms.ColumnHeader CLLetraPosIncorrecta;
        private System.Windows.Forms.ColumnHeader CLletraAggIncorrecta;
    }
}