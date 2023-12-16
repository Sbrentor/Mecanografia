namespace MECANOGRAFIA.mecanografia.RECORS_USUARIOS
{
    partial class FrmRecordsTematicas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CMBtematicas = new System.Windows.Forms.ComboBox();
            this.btnicio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVdatos = new System.Windows.Forms.DataGridView();
            this.CLPPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLprec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLLomitida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLL_POS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLLAGGM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLFECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdatos)).BeginInit();
            this.SuspendLayout();
            // 
            // CMBtematicas
            // 
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
            this.CMBtematicas.Location = new System.Drawing.Point(8, 341);
            this.CMBtematicas.Name = "CMBtematicas";
            this.CMBtematicas.Size = new System.Drawing.Size(271, 23);
            this.CMBtematicas.TabIndex = 24;
            this.CMBtematicas.SelectedIndexChanged += new System.EventHandler(this.CMBtematicas_SelectedIndexChanged);
            // 
            // btnicio
            // 
            this.btnicio.Location = new System.Drawing.Point(465, 5);
            this.btnicio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnicio.Name = "btnicio";
            this.btnicio.Size = new System.Drawing.Size(88, 27);
            this.btnicio.TabIndex = 21;
            this.btnicio.Text = "INICIO";
            this.btnicio.UseVisualStyleBackColor = true;
            this.btnicio.Click += new System.EventHandler(this.btnicio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Seleccione el Record de Tematica";
            // 
            // DGVdatos
            // 
            this.DGVdatos.AllowUserToAddRows = false;
            this.DGVdatos.AllowUserToDeleteRows = false;
            this.DGVdatos.AllowUserToResizeColumns = false;
            this.DGVdatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGVdatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DGVdatos.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.DGVdatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVdatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DGVdatos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVdatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DGVdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVdatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CLPPM,
            this.CLPC,
            this.CLPI,
            this.CLprec,
            this.CLLomitida,
            this.CLL_POS,
            this.CLLAGGM,
            this.CLFECHA});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVdatos.DefaultCellStyle = dataGridViewCellStyle12;
            this.DGVdatos.EnableHeadersVisualStyles = false;
            this.DGVdatos.GridColor = System.Drawing.Color.NavajoWhite;
            this.DGVdatos.Location = new System.Drawing.Point(8, 38);
            this.DGVdatos.Name = "DGVdatos";
            this.DGVdatos.ReadOnly = true;
            this.DGVdatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DGVdatos.RowHeadersVisible = false;
            this.DGVdatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGVdatos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGVdatos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Brown;
            this.DGVdatos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVdatos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Lavender;
            this.DGVdatos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.DGVdatos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DGVdatos.RowTemplate.ReadOnly = true;
            this.DGVdatos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVdatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGVdatos.Size = new System.Drawing.Size(1202, 272);
            this.DGVdatos.TabIndex = 26;
            // 
            // CLPPM
            // 
            this.CLPPM.HeaderText = "PALABRAS POR MINUTO";
            this.CLPPM.Name = "CLPPM";
            this.CLPPM.ReadOnly = true;
            this.CLPPM.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CLPPM.Width = 138;
            // 
            // CLPC
            // 
            this.CLPC.HeaderText = "PALABRAS CORRECTAS";
            this.CLPC.Name = "CLPC";
            this.CLPC.ReadOnly = true;
            this.CLPC.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CLPC.Width = 135;
            // 
            // CLPI
            // 
            this.CLPI.HeaderText = "PALABRAS INCORRECTAS";
            this.CLPI.Name = "CLPI";
            this.CLPI.ReadOnly = true;
            this.CLPI.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CLPI.Width = 148;
            // 
            // CLprec
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CLprec.DefaultCellStyle = dataGridViewCellStyle11;
            this.CLprec.HeaderText = "PRECISION";
            this.CLprec.Name = "CLprec";
            this.CLprec.ReadOnly = true;
            this.CLprec.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CLprec.Width = 80;
            // 
            // CLLomitida
            // 
            this.CLLomitida.HeaderText = "LETRA/S OMTIDA/S";
            this.CLLomitida.Name = "CLLomitida";
            this.CLLomitida.ReadOnly = true;
            this.CLLomitida.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CLLomitida.Width = 115;
            // 
            // CLL_POS
            // 
            this.CLL_POS.HeaderText = "LETRAS MAL POSICIONADAS";
            this.CLL_POS.Name = "CLL_POS";
            this.CLL_POS.ReadOnly = true;
            this.CLL_POS.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CLL_POS.Width = 170;
            // 
            // CLLAGGM
            // 
            this.CLLAGGM.HeaderText = "LETRAS AGREGADAS INCORRECTAMENTE";
            this.CLLAGGM.Name = "CLLAGGM";
            this.CLLAGGM.ReadOnly = true;
            this.CLLAGGM.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CLLAGGM.Width = 235;
            // 
            // CLFECHA
            // 
            this.CLFECHA.HeaderText = "FECHA DE JUEGO";
            this.CLFECHA.Name = "CLFECHA";
            this.CLFECHA.ReadOnly = true;
            this.CLFECHA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CLFECHA.Width = 159;
            // 
            // FrmRecordsTematicas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1216, 370);
            this.ControlBox = false;
            this.Controls.Add(this.DGVdatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CMBtematicas);
            this.Controls.Add(this.btnicio);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRecordsTematicas";
            this.Text = "Records de Tematicas";
            this.Load += new System.EventHandler(this.FrmRecordsTematicas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVdatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CMBtematicas;
        private System.Windows.Forms.Button btnicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVdatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLPPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLprec;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLLomitida;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLL_POS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLLAGGM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLFECHA;
    }
}