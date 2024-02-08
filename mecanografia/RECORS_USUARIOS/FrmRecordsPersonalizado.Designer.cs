namespace MECANOGRAFIA.mecanografia.RECORS_USUARIOS
{
    partial class FrmRecordsPersonalizado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecordsPersonalizado));
            this.DGVdatos = new System.Windows.Forms.DataGridView();
            this.CLPPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLprec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLLomitida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLL_POS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLLAGGM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLFECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.CMBpersonalizado = new System.Windows.Forms.ComboBox();
            this.btnicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdatos)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVdatos
            // 
            this.DGVdatos.AllowUserToAddRows = false;
            this.DGVdatos.AllowUserToDeleteRows = false;
            this.DGVdatos.AllowUserToResizeColumns = false;
            this.DGVdatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGVdatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVdatos.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.DGVdatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVdatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DGVdatos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVdatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVdatos.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGVdatos.EnableHeadersVisualStyles = false;
            this.DGVdatos.GridColor = System.Drawing.Color.NavajoWhite;
            this.DGVdatos.Location = new System.Drawing.Point(6, 38);
            this.DGVdatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.DGVdatos.Size = new System.Drawing.Size(1199, 314);
            this.DGVdatos.TabIndex = 29;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CLprec.DefaultCellStyle = dataGridViewCellStyle3;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 359);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Seleccione el Record de Texto personalizado";
            // 
            // CMBpersonalizado
            // 
            this.CMBpersonalizado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMBpersonalizado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CMBpersonalizado.FormattingEnabled = true;
            this.CMBpersonalizado.Location = new System.Drawing.Point(10, 380);
            this.CMBpersonalizado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CMBpersonalizado.Name = "CMBpersonalizado";
            this.CMBpersonalizado.Size = new System.Drawing.Size(280, 23);
            this.CMBpersonalizado.TabIndex = 27;
            this.CMBpersonalizado.SelectedIndexChanged += new System.EventHandler(this.CMBpersonalizado_SelectedIndexChanged);
            // 
            // btnicio
            // 
            this.btnicio.Location = new System.Drawing.Point(539, 1);
            this.btnicio.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnicio.Name = "btnicio";
            this.btnicio.Size = new System.Drawing.Size(103, 31);
            this.btnicio.TabIndex = 26;
            this.btnicio.Text = "INICIO";
            this.btnicio.UseVisualStyleBackColor = true;
            this.btnicio.Click += new System.EventHandler(this.btnicio_Click);
            // 
            // FrmRecordsPersonalizado
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1213, 413);
            this.ControlBox = false;
            this.Controls.Add(this.DGVdatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CMBpersonalizado);
            this.Controls.Add(this.btnicio);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRecordsPersonalizado";
            this.Text = "Records Personalizado";
            this.Load += new System.EventHandler(this.FrmRecordsPersonalizado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVdatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVdatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLPPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLprec;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLLomitida;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLL_POS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLLAGGM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLFECHA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CMBpersonalizado;
        private System.Windows.Forms.Button btnicio;
    }
}