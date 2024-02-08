namespace MECANOGRAFIA.mecanografia.RECORS_USUARIOS
{
    partial class RECORDS
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
            this.btnicio = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.P_modo = new System.Windows.Forms.Panel();
            this.P_ON = new System.Windows.Forms.Panel();
            this.P_OFF = new System.Windows.Forms.Panel();
            this.DGVdatos = new System.Windows.Forms.DataGridView();
            this.CLPPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLprec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLLomitida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLL_POS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLLAGGM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLFECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_modo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnicio
            // 
            this.btnicio.FlatAppearance.BorderSize = 0;
            this.btnicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnicio.ForeColor = System.Drawing.Color.White;
            this.btnicio.Location = new System.Drawing.Point(572, 4);
            this.btnicio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnicio.Name = "btnicio";
            this.btnicio.Size = new System.Drawing.Size(88, 27);
            this.btnicio.TabIndex = 3;
            this.btnicio.Text = "INICIO";
            this.btnicio.UseVisualStyleBackColor = true;
            this.btnicio.Click += new System.EventHandler(this.btnicio_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = global::MECANOGRAFIA.Properties.Resources.dia_y_noche;
            this.button1.Location = new System.Drawing.Point(15, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 27);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // P_modo
            // 
            this.P_modo.Controls.Add(this.P_ON);
            this.P_modo.Controls.Add(this.P_OFF);
            this.P_modo.Location = new System.Drawing.Point(55, 6);
            this.P_modo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.P_modo.Name = "P_modo";
            this.P_modo.Size = new System.Drawing.Size(102, 25);
            this.P_modo.TabIndex = 13;
            // 
            // P_ON
            // 
            this.P_ON.BackColor = System.Drawing.Color.Black;
            this.P_ON.Dock = System.Windows.Forms.DockStyle.Right;
            this.P_ON.Location = new System.Drawing.Point(48, 0);
            this.P_ON.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.P_ON.Name = "P_ON";
            this.P_ON.Size = new System.Drawing.Size(54, 25);
            this.P_ON.TabIndex = 10;
            // 
            // P_OFF
            // 
            this.P_OFF.BackColor = System.Drawing.Color.Red;
            this.P_OFF.Dock = System.Windows.Forms.DockStyle.Left;
            this.P_OFF.Location = new System.Drawing.Point(0, 0);
            this.P_OFF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.P_OFF.Name = "P_OFF";
            this.P_OFF.Size = new System.Drawing.Size(51, 25);
            this.P_OFF.TabIndex = 9;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVdatos.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGVdatos.EnableHeadersVisualStyles = false;
            this.DGVdatos.GridColor = System.Drawing.Color.NavajoWhite;
            this.DGVdatos.Location = new System.Drawing.Point(12, 37);
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
            this.DGVdatos.TabIndex = 15;
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
            // RECORDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1226, 313);
            this.ControlBox = false;
            this.Controls.Add(this.DGVdatos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.P_modo);
            this.Controls.Add(this.btnicio);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RECORDS";
            this.Text = "RECORDS";
            this.Load += new System.EventHandler(this.RECORDS_Load);
            this.P_modo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVdatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnicio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel P_modo;
        private System.Windows.Forms.Panel P_ON;
        private System.Windows.Forms.Panel P_OFF;
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