namespace MECANOGRAFIA.mecanografia
{
    partial class ESCRITURA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ESCRITURA));
            this.RELOJ = new System.Windows.Forms.Timer(this.components);
            this.P_ESCRITURA = new System.Windows.Forms.Panel();
            this.lblINCIAR_SESION = new System.Windows.Forms.Label();
            this.txtpalabrasescritas = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtpalabrasmostradas = new System.Windows.Forms.TextBox();
            this.lvPalabras = new System.Windows.Forms.ListView();
            this.PALABRAS_POR_MINUTO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PCORRECTAS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PINCORRECTAS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLPRECISION = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLletrasomitidas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLLetraPosIncorrecta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLletraAggIncorrecta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSEGUNDOS = new System.Windows.Forms.Label();
            this.P_modo = new System.Windows.Forms.Panel();
            this.P_ON = new System.Windows.Forms.Panel();
            this.P_OFF = new System.Windows.Forms.Panel();
            this.P_REGISTRO = new System.Windows.Forms.Panel();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnentrar_REGISTRO = new System.Windows.Forms.Button();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.P_INICIOSESION = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RDno = new System.Windows.Forms.RadioButton();
            this.RDsi = new System.Windows.Forms.RadioButton();
            this.CBusuario = new System.Windows.Forms.ComboBox();
            this.registro = new System.Windows.Forms.LinkLabel();
            this.btncancelar_sesion = new System.Windows.Forms.Button();
            this.btnentrar_INCIOSESION = new System.Windows.Forms.Button();
            this.txtcontra_sesion = new System.Windows.Forms.TextBox();
            this.txtusuario_sesion = new System.Windows.Forms.TextBox();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuOpciones = new System.Windows.Forms.MenuStrip();
            this.OPTLogoSAEG = new System.Windows.Forms.ToolStripMenuItem();
            this.eSCRITURAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rECORDSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OPTlogros = new System.Windows.Forms.ToolStripMenuItem();
            this.dESAFIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OPTdificultades = new System.Windows.Forms.ToolStripMenuItem();
            this.OPTrecordsdifi = new System.Windows.Forms.ToolStripMenuItem();
            this.OPTtematicas = new System.Windows.Forms.ToolStripMenuItem();
            this.rECORDSTEMATICASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mODOPERSONALIZADOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rECORDSMODOPERSONALIZADOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVolverASesion = new System.Windows.Forms.Button();
            this.btnver = new System.Windows.Forms.Button();
            this.btnVolverAEscritura = new System.Windows.Forms.Button();
            this.btnverSesion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnreiniciar = new System.Windows.Forms.Button();
            this.P_ESCRITURA.SuspendLayout();
            this.P_modo.SuspendLayout();
            this.P_REGISTRO.SuspendLayout();
            this.P_INICIOSESION.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MenuOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // RELOJ
            // 
            this.RELOJ.Interval = 1000;
            this.RELOJ.Tick += new System.EventHandler(this.RELOJ_Tick);
            // 
            // P_ESCRITURA
            // 
            this.P_ESCRITURA.Controls.Add(this.button1);
            this.P_ESCRITURA.Controls.Add(this.lblINCIAR_SESION);
            this.P_ESCRITURA.Controls.Add(this.btnIniciar);
            this.P_ESCRITURA.Controls.Add(this.txtpalabrasescritas);
            this.P_ESCRITURA.Controls.Add(this.lbl1);
            this.P_ESCRITURA.Controls.Add(this.txtpalabrasmostradas);
            this.P_ESCRITURA.Controls.Add(this.btnreiniciar);
            this.P_ESCRITURA.Controls.Add(this.lvPalabras);
            this.P_ESCRITURA.Controls.Add(this.lblSEGUNDOS);
            this.P_ESCRITURA.Controls.Add(this.P_modo);
            this.P_ESCRITURA.Location = new System.Drawing.Point(3, 3);
            this.P_ESCRITURA.Name = "P_ESCRITURA";
            this.P_ESCRITURA.Size = new System.Drawing.Size(613, 306);
            this.P_ESCRITURA.TabIndex = 12;
            // 
            // lblINCIAR_SESION
            // 
            this.lblINCIAR_SESION.AutoSize = true;
            this.lblINCIAR_SESION.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINCIAR_SESION.ForeColor = System.Drawing.Color.Blue;
            this.lblINCIAR_SESION.Location = new System.Drawing.Point(490, 273);
            this.lblINCIAR_SESION.Name = "lblINCIAR_SESION";
            this.lblINCIAR_SESION.Size = new System.Drawing.Size(104, 16);
            this.lblINCIAR_SESION.TabIndex = 9;
            this.lblINCIAR_SESION.Text = "INCIAR SESION";
            this.lblINCIAR_SESION.Click += new System.EventHandler(this.lblINCIAR_SESION_Click);
            // 
            // txtpalabrasescritas
            // 
            this.txtpalabrasescritas.BackColor = System.Drawing.Color.Brown;
            this.txtpalabrasescritas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpalabrasescritas.Font = new System.Drawing.Font("Humnst777 Blk BT", 15.75F);
            this.txtpalabrasescritas.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtpalabrasescritas.Location = new System.Drawing.Point(7, 72);
            this.txtpalabrasescritas.MaxLength = 29;
            this.txtpalabrasescritas.Multiline = true;
            this.txtpalabrasescritas.Name = "txtpalabrasescritas";
            this.txtpalabrasescritas.Size = new System.Drawing.Size(411, 33);
            this.txtpalabrasescritas.TabIndex = 2;
            this.txtpalabrasescritas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpalabrasescritas_KeyDown);
            this.txtpalabrasescritas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpalabrasescritas_KeyPress);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.White;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(440, 93);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(83, 25);
            this.lbl1.TabIndex = 10;
            this.lbl1.Text = "Tiempo";
            // 
            // txtpalabrasmostradas
            // 
            this.txtpalabrasmostradas.BackColor = System.Drawing.Color.Brown;
            this.txtpalabrasmostradas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpalabrasmostradas.Cursor = System.Windows.Forms.Cursors.No;
            this.txtpalabrasmostradas.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtpalabrasmostradas.Font = new System.Drawing.Font("Humnst777 Blk BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpalabrasmostradas.ForeColor = System.Drawing.SystemColors.Window;
            this.txtpalabrasmostradas.Location = new System.Drawing.Point(0, 0);
            this.txtpalabrasmostradas.MaxLength = 1000000000;
            this.txtpalabrasmostradas.Multiline = true;
            this.txtpalabrasmostradas.Name = "txtpalabrasmostradas";
            this.txtpalabrasmostradas.ReadOnly = true;
            this.txtpalabrasmostradas.ShortcutsEnabled = false;
            this.txtpalabrasmostradas.Size = new System.Drawing.Size(613, 66);
            this.txtpalabrasmostradas.TabIndex = 100;
            this.txtpalabrasmostradas.TabStop = false;
            this.txtpalabrasmostradas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lvPalabras
            // 
            this.lvPalabras.BackColor = System.Drawing.Color.Brown;
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
            this.lvPalabras.Location = new System.Drawing.Point(7, 120);
            this.lvPalabras.Name = "lvPalabras";
            this.lvPalabras.Size = new System.Drawing.Size(440, 130);
            this.lvPalabras.TabIndex = 3;
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
            // lblSEGUNDOS
            // 
            this.lblSEGUNDOS.AutoSize = true;
            this.lblSEGUNDOS.BackColor = System.Drawing.Color.White;
            this.lblSEGUNDOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSEGUNDOS.Location = new System.Drawing.Point(463, 69);
            this.lblSEGUNDOS.Name = "lblSEGUNDOS";
            this.lblSEGUNDOS.Size = new System.Drawing.Size(36, 25);
            this.lblSEGUNDOS.TabIndex = 5;
            this.lblSEGUNDOS.Text = "60";
            // 
            // P_modo
            // 
            this.P_modo.Controls.Add(this.P_ON);
            this.P_modo.Controls.Add(this.P_OFF);
            this.P_modo.Location = new System.Drawing.Point(39, 273);
            this.P_modo.Name = "P_modo";
            this.P_modo.Size = new System.Drawing.Size(87, 22);
            this.P_modo.TabIndex = 8;
            // 
            // P_ON
            // 
            this.P_ON.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.P_ON.Dock = System.Windows.Forms.DockStyle.Right;
            this.P_ON.Location = new System.Drawing.Point(41, 0);
            this.P_ON.Name = "P_ON";
            this.P_ON.Size = new System.Drawing.Size(46, 22);
            this.P_ON.TabIndex = 10;
            // 
            // P_OFF
            // 
            this.P_OFF.BackColor = System.Drawing.Color.Red;
            this.P_OFF.Dock = System.Windows.Forms.DockStyle.Left;
            this.P_OFF.Location = new System.Drawing.Point(0, 0);
            this.P_OFF.Name = "P_OFF";
            this.P_OFF.Size = new System.Drawing.Size(44, 22);
            this.P_OFF.TabIndex = 9;
            // 
            // P_REGISTRO
            // 
            this.P_REGISTRO.Controls.Add(this.btnVolverASesion);
            this.P_REGISTRO.Controls.Add(this.btnver);
            this.P_REGISTRO.Controls.Add(this.btncancelar);
            this.P_REGISTRO.Controls.Add(this.btnentrar_REGISTRO);
            this.P_REGISTRO.Controls.Add(this.txtcontra);
            this.P_REGISTRO.Controls.Add(this.txtusuario);
            this.P_REGISTRO.Controls.Add(this.lbl4);
            this.P_REGISTRO.Controls.Add(this.lbl3);
            this.P_REGISTRO.Location = new System.Drawing.Point(618, 16);
            this.P_REGISTRO.Name = "P_REGISTRO";
            this.P_REGISTRO.Size = new System.Drawing.Size(230, 164);
            this.P_REGISTRO.TabIndex = 8;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(106, 129);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(115, 30);
            this.btncancelar.TabIndex = 19;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnentrar_REGISTRO
            // 
            this.btnentrar_REGISTRO.Location = new System.Drawing.Point(8, 129);
            this.btnentrar_REGISTRO.Name = "btnentrar_REGISTRO";
            this.btnentrar_REGISTRO.Size = new System.Drawing.Size(84, 30);
            this.btnentrar_REGISTRO.TabIndex = 18;
            this.btnentrar_REGISTRO.Text = "ENTRAR";
            this.btnentrar_REGISTRO.UseVisualStyleBackColor = true;
            this.btnentrar_REGISTRO.Click += new System.EventHandler(this.btnentrar_REGISTRO_Click);
            // 
            // txtcontra
            // 
            this.txtcontra.BackColor = System.Drawing.Color.Brown;
            this.txtcontra.Location = new System.Drawing.Point(38, 96);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(130, 27);
            this.txtcontra.TabIndex = 16;
            this.txtcontra.UseSystemPasswordChar = true;
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.Color.Brown;
            this.txtusuario.Location = new System.Drawing.Point(38, 32);
            this.txtusuario.MaxLength = 50;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(130, 27);
            this.txtusuario.TabIndex = 14;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(41, 72);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(122, 21);
            this.lbl4.TabIndex = 15;
            this.lbl4.Text = "CONTRASEÑA";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(61, 8);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(82, 21);
            this.lbl3.TabIndex = 13;
            this.lbl3.Text = "USUARIO";
            // 
            // P_INICIOSESION
            // 
            this.P_INICIOSESION.Controls.Add(this.groupBox1);
            this.P_INICIOSESION.Controls.Add(this.CBusuario);
            this.P_INICIOSESION.Controls.Add(this.btnVolverAEscritura);
            this.P_INICIOSESION.Controls.Add(this.registro);
            this.P_INICIOSESION.Controls.Add(this.btnverSesion);
            this.P_INICIOSESION.Controls.Add(this.btncancelar_sesion);
            this.P_INICIOSESION.Controls.Add(this.btnentrar_INCIOSESION);
            this.P_INICIOSESION.Controls.Add(this.txtcontra_sesion);
            this.P_INICIOSESION.Controls.Add(this.txtusuario_sesion);
            this.P_INICIOSESION.Controls.Add(this.lbl6);
            this.P_INICIOSESION.Controls.Add(this.lbl5);
            this.P_INICIOSESION.Location = new System.Drawing.Point(850, 15);
            this.P_INICIOSESION.Name = "P_INICIOSESION";
            this.P_INICIOSESION.Size = new System.Drawing.Size(324, 244);
            this.P_INICIOSESION.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RDno);
            this.groupBox1.Controls.Add(this.RDsi);
            this.groupBox1.Location = new System.Drawing.Point(10, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 52);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recordar Usuario:";
            // 
            // RDno
            // 
            this.RDno.AutoSize = true;
            this.RDno.Location = new System.Drawing.Point(85, 21);
            this.RDno.Name = "RDno";
            this.RDno.Size = new System.Drawing.Size(54, 25);
            this.RDno.TabIndex = 23;
            this.RDno.TabStop = true;
            this.RDno.Text = "NO";
            this.RDno.UseVisualStyleBackColor = true;
            this.RDno.CheckedChanged += new System.EventHandler(this.RDno_CheckedChanged);
            // 
            // RDsi
            // 
            this.RDsi.AutoSize = true;
            this.RDsi.Location = new System.Drawing.Point(27, 21);
            this.RDsi.Name = "RDsi";
            this.RDsi.Size = new System.Drawing.Size(41, 25);
            this.RDsi.TabIndex = 22;
            this.RDsi.TabStop = true;
            this.RDsi.Text = "SI";
            this.RDsi.UseVisualStyleBackColor = true;
            this.RDsi.CheckedChanged += new System.EventHandler(this.RDsi_CheckedChanged);
            // 
            // CBusuario
            // 
            this.CBusuario.BackColor = System.Drawing.Color.Brown;
            this.CBusuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBusuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBusuario.FormattingEnabled = true;
            this.CBusuario.Location = new System.Drawing.Point(88, 28);
            this.CBusuario.Name = "CBusuario";
            this.CBusuario.Size = new System.Drawing.Size(116, 29);
            this.CBusuario.TabIndex = 24;
            // 
            // registro
            // 
            this.registro.AutoSize = true;
            this.registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registro.Location = new System.Drawing.Point(202, 205);
            this.registro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(91, 20);
            this.registro.TabIndex = 14;
            this.registro.TabStop = true;
            this.registro.Text = "Registrarse";
            this.registro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registro_LinkClicked);
            // 
            // btncancelar_sesion
            // 
            this.btncancelar_sesion.Location = new System.Drawing.Point(190, 131);
            this.btncancelar_sesion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btncancelar_sesion.Name = "btncancelar_sesion";
            this.btncancelar_sesion.Size = new System.Drawing.Size(120, 25);
            this.btncancelar_sesion.TabIndex = 13;
            this.btncancelar_sesion.Text = "CANCELAR";
            this.btncancelar_sesion.UseVisualStyleBackColor = true;
            this.btncancelar_sesion.Click += new System.EventHandler(this.btncancelar_sesion_Click);
            // 
            // btnentrar_INCIOSESION
            // 
            this.btnentrar_INCIOSESION.Location = new System.Drawing.Point(28, 131);
            this.btnentrar_INCIOSESION.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnentrar_INCIOSESION.Name = "btnentrar_INCIOSESION";
            this.btnentrar_INCIOSESION.Size = new System.Drawing.Size(85, 25);
            this.btnentrar_INCIOSESION.TabIndex = 12;
            this.btnentrar_INCIOSESION.Text = "ENTRAR";
            this.btnentrar_INCIOSESION.UseVisualStyleBackColor = true;
            this.btnentrar_INCIOSESION.Click += new System.EventHandler(this.btnentrar_INCIOSESION_Click);
            // 
            // txtcontra_sesion
            // 
            this.txtcontra_sesion.BackColor = System.Drawing.Color.Brown;
            this.txtcontra_sesion.Location = new System.Drawing.Point(89, 93);
            this.txtcontra_sesion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtcontra_sesion.Name = "txtcontra_sesion";
            this.txtcontra_sesion.Size = new System.Drawing.Size(116, 27);
            this.txtcontra_sesion.TabIndex = 10;
            this.txtcontra_sesion.UseSystemPasswordChar = true;
            // 
            // txtusuario_sesion
            // 
            this.txtusuario_sesion.BackColor = System.Drawing.Color.Brown;
            this.txtusuario_sesion.Location = new System.Drawing.Point(89, 30);
            this.txtusuario_sesion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtusuario_sesion.MaxLength = 50;
            this.txtusuario_sesion.Name = "txtusuario_sesion";
            this.txtusuario_sesion.Size = new System.Drawing.Size(116, 27);
            this.txtusuario_sesion.TabIndex = 8;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(85, 69);
            this.lbl6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(122, 21);
            this.lbl6.TabIndex = 9;
            this.lbl6.Text = "CONTRASEÑA";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(103, 6);
            this.lbl5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(82, 21);
            this.lbl5.TabIndex = 7;
            this.lbl5.Text = "USUARIO";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.P_REGISTRO);
            this.panel1.Controls.Add(this.P_INICIOSESION);
            this.panel1.Controls.Add(this.P_ESCRITURA);
            this.panel1.Location = new System.Drawing.Point(2, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 339);
            this.panel1.TabIndex = 16;
            // 
            // MenuOpciones
            // 
            this.MenuOpciones.BackColor = System.Drawing.Color.AliceBlue;
            this.MenuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OPTLogoSAEG,
            this.eSCRITURAToolStripMenuItem,
            this.dESAFIOSToolStripMenuItem});
            this.MenuOpciones.Location = new System.Drawing.Point(0, 0);
            this.MenuOpciones.Name = "MenuOpciones";
            this.MenuOpciones.Size = new System.Drawing.Size(1201, 24);
            this.MenuOpciones.TabIndex = 19;
            this.MenuOpciones.Text = "menuStrip1";
            // 
            // OPTLogoSAEG
            // 
            this.OPTLogoSAEG.BackColor = System.Drawing.Color.Silver;
            this.OPTLogoSAEG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OPTLogoSAEG.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OPTLogoSAEG.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OPTLogoSAEG.Image = global::MECANOGRAFIA.Properties.Resources.saeg_logo;
            this.OPTLogoSAEG.Name = "OPTLogoSAEG";
            this.OPTLogoSAEG.ShowShortcutKeys = false;
            this.OPTLogoSAEG.Size = new System.Drawing.Size(28, 20);
            // 
            // eSCRITURAToolStripMenuItem
            // 
            this.eSCRITURAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rECORDSToolStripMenuItem,
            this.OPTlogros});
            this.eSCRITURAToolStripMenuItem.Font = new System.Drawing.Font("Humnst777 Blk BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eSCRITURAToolStripMenuItem.Image = global::MECANOGRAFIA.Properties.Resources.teclado;
            this.eSCRITURAToolStripMenuItem.Name = "eSCRITURAToolStripMenuItem";
            this.eSCRITURAToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.eSCRITURAToolStripMenuItem.Text = "ESCRITURA";
            // 
            // rECORDSToolStripMenuItem
            // 
            this.rECORDSToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.rECORDSToolStripMenuItem.Image = global::MECANOGRAFIA.Properties.Resources.verificar;
            this.rECORDSToolStripMenuItem.Name = "rECORDSToolStripMenuItem";
            this.rECORDSToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.rECORDSToolStripMenuItem.Text = "RECORDS";
            this.rECORDSToolStripMenuItem.Click += new System.EventHandler(this.rECORDSToolStripMenuItem_Click_1);
            // 
            // OPTlogros
            // 
            this.OPTlogros.Image = global::MECANOGRAFIA.Properties.Resources.medal;
            this.OPTlogros.Name = "OPTlogros";
            this.OPTlogros.Size = new System.Drawing.Size(130, 22);
            this.OPTlogros.Text = "LOGROS";
            this.OPTlogros.Click += new System.EventHandler(this.OPTlogros_Click);
            // 
            // dESAFIOSToolStripMenuItem
            // 
            this.dESAFIOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OPTdificultades,
            this.OPTtematicas,
            this.mODOPERSONALIZADOToolStripMenuItem});
            this.dESAFIOSToolStripMenuItem.Font = new System.Drawing.Font("Humnst777 Blk BT", 9F);
            this.dESAFIOSToolStripMenuItem.Image = global::MECANOGRAFIA.Properties.Resources.desafio;
            this.dESAFIOSToolStripMenuItem.Name = "dESAFIOSToolStripMenuItem";
            this.dESAFIOSToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.dESAFIOSToolStripMenuItem.Text = "DESAFIOS";
            // 
            // OPTdificultades
            // 
            this.OPTdificultades.BackColor = System.Drawing.Color.AliceBlue;
            this.OPTdificultades.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OPTrecordsdifi});
            this.OPTdificultades.Image = global::MECANOGRAFIA.Properties.Resources.velocimetro;
            this.OPTdificultades.Name = "OPTdificultades";
            this.OPTdificultades.Size = new System.Drawing.Size(216, 22);
            this.OPTdificultades.Text = "DIFICULTADES";
            this.OPTdificultades.Click += new System.EventHandler(this.OPTdificultades_Click);
            // 
            // OPTrecordsdifi
            // 
            this.OPTrecordsdifi.BackColor = System.Drawing.Color.AliceBlue;
            this.OPTrecordsdifi.Image = global::MECANOGRAFIA.Properties.Resources.verificar;
            this.OPTrecordsdifi.Name = "OPTrecordsdifi";
            this.OPTrecordsdifi.Size = new System.Drawing.Size(240, 22);
            this.OPTrecordsdifi.Text = "RECORDS DE DIFICULTADES";
            this.OPTrecordsdifi.Click += new System.EventHandler(this.OPTrecordsdifi_Click);
            // 
            // OPTtematicas
            // 
            this.OPTtematicas.BackColor = System.Drawing.Color.AliceBlue;
            this.OPTtematicas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rECORDSTEMATICASToolStripMenuItem});
            this.OPTtematicas.Image = global::MECANOGRAFIA.Properties.Resources.mosaico;
            this.OPTtematicas.Name = "OPTtematicas";
            this.OPTtematicas.Size = new System.Drawing.Size(216, 22);
            this.OPTtematicas.Text = "TEMATICAS";
            this.OPTtematicas.Click += new System.EventHandler(this.tEMATICASToolStripMenuItem_Click);
            // 
            // rECORDSTEMATICASToolStripMenuItem
            // 
            this.rECORDSTEMATICASToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.rECORDSTEMATICASToolStripMenuItem.Image = global::MECANOGRAFIA.Properties.Resources.verificar;
            this.rECORDSTEMATICASToolStripMenuItem.Name = "rECORDSTEMATICASToolStripMenuItem";
            this.rECORDSTEMATICASToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.rECORDSTEMATICASToolStripMenuItem.Text = "RECORDS TEMATICAS";
            this.rECORDSTEMATICASToolStripMenuItem.Click += new System.EventHandler(this.rECORDSTEMATICASToolStripMenuItem_Click);
            // 
            // mODOPERSONALIZADOToolStripMenuItem
            // 
            this.mODOPERSONALIZADOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rECORDSMODOPERSONALIZADOToolStripMenuItem});
            this.mODOPERSONALIZADOToolStripMenuItem.Image = global::MECANOGRAFIA.Properties.Resources.deslizadores;
            this.mODOPERSONALIZADOToolStripMenuItem.Name = "mODOPERSONALIZADOToolStripMenuItem";
            this.mODOPERSONALIZADOToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.mODOPERSONALIZADOToolStripMenuItem.Text = "MODO PERSONALIZADO";
            this.mODOPERSONALIZADOToolStripMenuItem.Click += new System.EventHandler(this.mODOPERSONALIZADOToolStripMenuItem_Click);
            // 
            // rECORDSMODOPERSONALIZADOToolStripMenuItem
            // 
            this.rECORDSMODOPERSONALIZADOToolStripMenuItem.Image = global::MECANOGRAFIA.Properties.Resources.verificar;
            this.rECORDSMODOPERSONALIZADOToolStripMenuItem.Name = "rECORDSMODOPERSONALIZADOToolStripMenuItem";
            this.rECORDSMODOPERSONALIZADOToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.rECORDSMODOPERSONALIZADOToolStripMenuItem.Text = "RECORDS MODO PERSONALIZADO";
            // 
            // btnVolverASesion
            // 
            this.btnVolverASesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverASesion.Image = global::MECANOGRAFIA.Properties.Resources.derecha;
            this.btnVolverASesion.Location = new System.Drawing.Point(178, 8);
            this.btnVolverASesion.Name = "btnVolverASesion";
            this.btnVolverASesion.Size = new System.Drawing.Size(32, 30);
            this.btnVolverASesion.TabIndex = 20;
            this.btnVolverASesion.UseVisualStyleBackColor = true;
            this.btnVolverASesion.Click += new System.EventHandler(this.btnVolverASesion_Click);
            // 
            // btnver
            // 
            this.btnver.Font = new System.Drawing.Font("Clarendon BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnver.Image = global::MECANOGRAFIA.Properties.Resources.show_pwd;
            this.btnver.Location = new System.Drawing.Point(177, 96);
            this.btnver.Name = "btnver";
            this.btnver.Size = new System.Drawing.Size(33, 25);
            this.btnver.TabIndex = 17;
            this.btnver.UseVisualStyleBackColor = true;
            this.btnver.Click += new System.EventHandler(this.btnver_Click);
            // 
            // btnVolverAEscritura
            // 
            this.btnVolverAEscritura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverAEscritura.Image = global::MECANOGRAFIA.Properties.Resources.derecha;
            this.btnVolverAEscritura.Location = new System.Drawing.Point(289, 3);
            this.btnVolverAEscritura.Name = "btnVolverAEscritura";
            this.btnVolverAEscritura.Size = new System.Drawing.Size(32, 30);
            this.btnVolverAEscritura.TabIndex = 21;
            this.btnVolverAEscritura.UseVisualStyleBackColor = true;
            this.btnVolverAEscritura.Click += new System.EventHandler(this.btnVolverAEscritura_Click);
            // 
            // btnverSesion
            // 
            this.btnverSesion.Font = new System.Drawing.Font("Clarendon BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverSesion.Image = global::MECANOGRAFIA.Properties.Resources.show_pwd;
            this.btnverSesion.Location = new System.Drawing.Point(230, 95);
            this.btnverSesion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnverSesion.Name = "btnverSesion";
            this.btnverSesion.Size = new System.Drawing.Size(32, 25);
            this.btnverSesion.TabIndex = 11;
            this.btnverSesion.UseVisualStyleBackColor = true;
            this.btnverSesion.Click += new System.EventHandler(this.btnverSesion_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::MECANOGRAFIA.Properties.Resources.dia_y_noche;
            this.button1.Location = new System.Drawing.Point(7, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 21);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Image = global::MECANOGRAFIA.Properties.Resources.boton_de_play;
            this.btnIniciar.Location = new System.Drawing.Point(526, 72);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(34, 33);
            this.btnIniciar.TabIndex = 11;
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnreiniciar
            // 
            this.btnreiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreiniciar.Image = global::MECANOGRAFIA.Properties.Resources.sincronizacion;
            this.btnreiniciar.Location = new System.Drawing.Point(563, 72);
            this.btnreiniciar.Name = "btnreiniciar";
            this.btnreiniciar.Size = new System.Drawing.Size(31, 33);
            this.btnreiniciar.TabIndex = 4;
            this.btnreiniciar.UseVisualStyleBackColor = true;
            this.btnreiniciar.Click += new System.EventHandler(this.btnreiniciar_Click);
            // 
            // ESCRITURA
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1201, 369);
            this.Controls.Add(this.MenuOpciones);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ESCRITURA";
            this.Text = "ESCRITURA";
            this.Load += new System.EventHandler(this.ESCRITURA_Load);
            this.P_ESCRITURA.ResumeLayout(false);
            this.P_ESCRITURA.PerformLayout();
            this.P_modo.ResumeLayout(false);
            this.P_REGISTRO.ResumeLayout(false);
            this.P_REGISTRO.PerformLayout();
            this.P_INICIOSESION.ResumeLayout(false);
            this.P_INICIOSESION.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.MenuOpciones.ResumeLayout(false);
            this.MenuOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer RELOJ;
        private System.Windows.Forms.Label lblINCIAR_SESION;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtpalabrasescritas;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtpalabrasmostradas;
        private System.Windows.Forms.Button btnreiniciar;
        private System.Windows.Forms.ListView lvPalabras;
        private System.Windows.Forms.ColumnHeader PALABRAS_POR_MINUTO;
        private System.Windows.Forms.ColumnHeader PCORRECTAS;
        private System.Windows.Forms.ColumnHeader PINCORRECTAS;
        private System.Windows.Forms.Label lblSEGUNDOS;
        private System.Windows.Forms.Panel P_modo;
        private System.Windows.Forms.Panel P_ON;
        private System.Windows.Forms.Panel P_OFF;
        private System.Windows.Forms.Panel P_REGISTRO;
        private System.Windows.Forms.Button btnver;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnentrar_REGISTRO;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Panel P_INICIOSESION;
        private System.Windows.Forms.LinkLabel registro;
        private System.Windows.Forms.Button btnverSesion;
        private System.Windows.Forms.Button btncancelar_sesion;
        private System.Windows.Forms.Button btnentrar_INCIOSESION;
        private System.Windows.Forms.TextBox txtcontra_sesion;
        private System.Windows.Forms.TextBox txtusuario_sesion;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVolverASesion;
        private System.Windows.Forms.Button btnVolverAEscritura;
        public System.Windows.Forms.Panel P_ESCRITURA;
        private System.Windows.Forms.ComboBox CBusuario;
        private System.Windows.Forms.RadioButton RDsi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RDno;
        private System.Windows.Forms.MenuStrip MenuOpciones;
        private System.Windows.Forms.ToolStripMenuItem OPTLogoSAEG;
        private System.Windows.Forms.ToolStripMenuItem eSCRITURAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rECORDSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dESAFIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OPTdificultades;
        private System.Windows.Forms.ToolStripMenuItem OPTrecordsdifi;
        private System.Windows.Forms.ToolStripMenuItem OPTtematicas;
        private System.Windows.Forms.ToolStripMenuItem rECORDSTEMATICASToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader CLPRECISION;
        private System.Windows.Forms.ColumnHeader CLletrasomitidas;
        private System.Windows.Forms.ColumnHeader CLLetraPosIncorrecta;
        private System.Windows.Forms.ColumnHeader CLletraAggIncorrecta;
        private System.Windows.Forms.ToolStripMenuItem OPTlogros;
        private System.Windows.Forms.ToolStripMenuItem mODOPERSONALIZADOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rECORDSMODOPERSONALIZADOToolStripMenuItem;
    }
}