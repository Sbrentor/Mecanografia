namespace MECANOGRAFIA.mecanografia.RECORS_USUARIOS
{
    partial class FrmRecordsDificultades
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnicio = new System.Windows.Forms.Button();
            this.CMBdificultades = new System.Windows.Forms.ComboBox();
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
            // btnicio
            // 
            this.btnicio.Location = new System.Drawing.Point(543, 7);
            this.btnicio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnicio.Name = "btnicio";
            this.btnicio.Size = new System.Drawing.Size(88, 27);
            this.btnicio.TabIndex = 4;
            this.btnicio.Text = "INICIO";
            this.btnicio.UseVisualStyleBackColor = true;
            this.btnicio.Click += new System.EventHandler(this.btnicio_Click);
            // 
            // CMBdificultades
            // 
            this.CMBdificultades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBdificultades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CMBdificultades.FormattingEnabled = true;
            this.CMBdificultades.Items.AddRange(new object[] {
            "FACIL",
            "INTERMEDIO",
            "DIFICIL"});
            this.CMBdificultades.Location = new System.Drawing.Point(12, 350);
            this.CMBdificultades.Name = "CMBdificultades";
            this.CMBdificultades.Size = new System.Drawing.Size(120, 23);
            this.CMBdificultades.TabIndex = 20;
            this.CMBdificultades.SelectedIndexChanged += new System.EventHandler(this.CMBdificultades_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Seleccione el Record de Dificultad";
            // 
            // DGVdatos
            // 
            this.DGVdatos.AllowUserToAddRows = false;
            this.DGVdatos.AllowUserToDeleteRows = false;
            this.DGVdatos.AllowUserToResizeColumns = false;
            this.DGVdatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGVdatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVdatos.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.DGVdatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVdatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DGVdatos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVdatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVdatos.DefaultCellStyle = dataGridViewCellStyle8;
            this.DGVdatos.EnableHeadersVisualStyles = false;
            this.DGVdatos.GridColor = System.Drawing.Color.NavajoWhite;
            this.DGVdatos.Location = new System.Drawing.Point(2, 40);
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
            this.DGVdatos.TabIndex = 25;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CLprec.DefaultCellStyle = dataGridViewCellStyle7;
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
            // FrmRecordsDificultades
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1207, 391);
            this.ControlBox = false;
            this.Controls.Add(this.DGVdatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CMBdificultades);
            this.Controls.Add(this.btnicio);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmRecordsDificultades";
            this.Text = "Records Dificultades";
            this.Load += new System.EventHandler(this.FrmRecordsDificultades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVdatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnicio;
        private System.Windows.Forms.ComboBox CMBdificultades;
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