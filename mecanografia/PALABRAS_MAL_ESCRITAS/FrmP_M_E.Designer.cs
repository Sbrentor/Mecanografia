namespace MECANOGRAFIA.mecanografia.PALABRAS_MAL_ESCRITAS
{
    partial class FrmP_M_E
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVdatos = new System.Windows.Forms.DataGridView();
            this.DTPfecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.CLPI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLFECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdatos)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVdatos
            // 
            this.DGVdatos.AllowUserToAddRows = false;
            this.DGVdatos.AllowUserToDeleteRows = false;
            this.DGVdatos.AllowUserToResizeColumns = false;
            this.DGVdatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGVdatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.DGVdatos.BackgroundColor = System.Drawing.Color.NavajoWhite;
            this.DGVdatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVdatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DGVdatos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVdatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DGVdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVdatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CLPI,
            this.CLFECHA});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVdatos.DefaultCellStyle = dataGridViewCellStyle15;
            this.DGVdatos.EnableHeadersVisualStyles = false;
            this.DGVdatos.GridColor = System.Drawing.Color.NavajoWhite;
            this.DGVdatos.Location = new System.Drawing.Point(2, 2);
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
            this.DGVdatos.Size = new System.Drawing.Size(863, 382);
            this.DGVdatos.TabIndex = 16;
            // 
            // DTPfecha
            // 
            this.DTPfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPfecha.Location = new System.Drawing.Point(395, 424);
            this.DTPfecha.Name = "DTPfecha";
            this.DTPfecha.Size = new System.Drawing.Size(99, 21);
            this.DTPfecha.TabIndex = 17;
            this.DTPfecha.Value = new System.DateTime(2024, 2, 7, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Seleccionar Fecha";
            // 
            // CLPI
            // 
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLPI.DefaultCellStyle = dataGridViewCellStyle13;
            this.CLPI.HeaderText = "PALABRAS INCORRECTAS";
            this.CLPI.Name = "CLPI";
            this.CLPI.ReadOnly = true;
            this.CLPI.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CLPI.Width = 700;
            // 
            // CLFECHA
            // 
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLFECHA.DefaultCellStyle = dataGridViewCellStyle14;
            this.CLFECHA.HeaderText = "FECHA DE JUEGO";
            this.CLFECHA.Name = "CLFECHA";
            this.CLFECHA.ReadOnly = true;
            this.CLFECHA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CLFECHA.Width = 159;
            // 
            // FrmP_M_E
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(870, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DTPfecha);
            this.Controls.Add(this.DGVdatos);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmP_M_E";
            this.ShowIcon = false;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmP_M_E_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVdatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVdatos;
        private System.Windows.Forms.DateTimePicker DTPfecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLPI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLFECHA;
    }
}