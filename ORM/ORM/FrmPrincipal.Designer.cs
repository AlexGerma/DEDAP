namespace ORM
{
    partial class FrmPrincipal
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
            this.btnConectar = new System.Windows.Forms.Button();
            this.dgvBases = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMotor = new System.Windows.Forms.ComboBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.cbBases = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.cbTablas = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbTipoDato = new System.Windows.Forms.ComboBox();
            this.pnllogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnMini = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbEstado = new System.Windows.Forms.Label();
            this.pnlStringConexion = new System.Windows.Forms.Panel();
            this.txtStringConexion = new System.Windows.Forms.TextBox();
            this.pnlForm2 = new System.Windows.Forms.Panel();
            this.btnMostraTodas = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtLenght = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbTb = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbBD = new System.Windows.Forms.ComboBox();
            this.DgridTipos = new System.Windows.Forms.DataGridView();
            this.btnTiposDatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBases)).BeginInit();
            this.pnllogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlStringConexion.SuspendLayout();
            this.pnlForm2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgridTipos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConectar.FlatAppearance.BorderSize = 0;
            this.btnConectar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnConectar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConectar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.ForeColor = System.Drawing.Color.White;
            this.btnConectar.Location = new System.Drawing.Point(134, 168);
            this.btnConectar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(113, 28);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // dgvBases
            // 
            this.dgvBases.AllowUserToAddRows = false;
            this.dgvBases.AllowUserToDeleteRows = false;
            this.dgvBases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvBases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBases.Location = new System.Drawing.Point(12, 204);
            this.dgvBases.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvBases.Name = "dgvBases";
            this.dgvBases.ReadOnly = true;
            this.dgvBases.Size = new System.Drawing.Size(862, 363);
            this.dgvBases.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Servidor de BD:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(118, 73);
            this.txtHost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(189, 21);
            this.txtHost.TabIndex = 4;
            this.txtHost.TextChanged += new System.EventHandler(this.txtHost_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(50, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Servidor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(55, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(28, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contraseña:";
            // 
            // cbMotor
            // 
            this.cbMotor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMotor.FormattingEnabled = true;
            this.cbMotor.Items.AddRange(new object[] {
            "MySQL",
            "MSSQL",
            "PostgreSQL",
            "FoxPro"});
            this.cbMotor.Location = new System.Drawing.Point(118, 47);
            this.cbMotor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMotor.Name = "cbMotor";
            this.cbMotor.Size = new System.Drawing.Size(188, 24);
            this.cbMotor.TabIndex = 8;
            this.cbMotor.SelectedIndexChanged += new System.EventHandler(this.cbMotor_SelectedIndexChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(118, 117);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(189, 21);
            this.txtUsuario.TabIndex = 9;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(118, 139);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(189, 21);
            this.txtPass.TabIndex = 10;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            // 
            // cbBases
            // 
            this.cbBases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBases.FormattingEnabled = true;
            this.cbBases.Location = new System.Drawing.Point(686, 75);
            this.cbBases.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbBases.Name = "cbBases";
            this.cbBases.Size = new System.Drawing.Size(188, 24);
            this.cbBases.TabIndex = 11;
            this.cbBases.SelectedIndexChanged += new System.EventHandler(this.cbBases_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(558, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Base de Datos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "String de Conexión:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(63, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Puerto:";
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(118, 95);
            this.txtPuerto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(189, 21);
            this.txtPuerto.TabIndex = 18;
            this.txtPuerto.TextChanged += new System.EventHandler(this.txtPuerto_TextChanged);
            // 
            // cbTablas
            // 
            this.cbTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTablas.FormattingEnabled = true;
            this.cbTablas.Location = new System.Drawing.Point(686, 123);
            this.cbTablas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTablas.Name = "cbTablas";
            this.cbTablas.Size = new System.Drawing.Size(188, 24);
            this.cbTablas.TabIndex = 21;
            this.cbTablas.SelectedIndexChanged += new System.EventHandler(this.cbTablas_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(612, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tablas:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(570, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Tipo de Dato:";
            // 
            // cbTipoDato
            // 
            this.cbTipoDato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoDato.FormattingEnabled = true;
            this.cbTipoDato.Items.AddRange(new object[] {
            "Estructura de BD",
            "Estructura de Tablas",
            "Indices",
            "Constrain de BD",
            "Store Procedures",
            "Views",
            "Triggers"});
            this.cbTipoDato.Location = new System.Drawing.Point(686, 99);
            this.cbTipoDato.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTipoDato.Name = "cbTipoDato";
            this.cbTipoDato.Size = new System.Drawing.Size(188, 24);
            this.cbTipoDato.TabIndex = 24;
            this.cbTipoDato.SelectedIndexChanged += new System.EventHandler(this.cbTipoDato_SelectedIndexChanged);
            // 
            // pnllogo
            // 
            this.pnllogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnllogo.Controls.Add(this.pictureBox1);
            this.pnllogo.Controls.Add(this.label10);
            this.pnllogo.Controls.Add(this.btnMini);
            this.pnllogo.Controls.Add(this.btnExit);
            this.pnllogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnllogo.ForeColor = System.Drawing.Color.DimGray;
            this.pnllogo.Location = new System.Drawing.Point(0, 0);
            this.pnllogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnllogo.Name = "pnllogo";
            this.pnllogo.Size = new System.Drawing.Size(887, 32);
            this.pnllogo.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::ORM.Properties.Resources.officedatabase_103574;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(41, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "ORM Beta Version v.1";
            // 
            // btnMini
            // 
            this.btnMini.BackgroundImage = global::ORM.Properties.Resources.MInimizar;
            this.btnMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMini.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMini.FlatAppearance.BorderSize = 0;
            this.btnMini.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.btnMini.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.Location = new System.Drawing.Point(809, 0);
            this.btnMini.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(39, 32);
            this.btnMini.TabIndex = 1;
            this.btnMini.UseVisualStyleBackColor = true;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::ORM.Properties.Resources.Salir;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(848, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(39, 32);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstado.ForeColor = System.Drawing.Color.Red;
            this.lbEstado.Location = new System.Drawing.Point(314, 48);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(72, 23);
            this.lbEstado.TabIndex = 26;
            this.lbEstado.Text = "Estado";
            // 
            // pnlStringConexion
            // 
            this.pnlStringConexion.BackColor = System.Drawing.Color.Gray;
            this.pnlStringConexion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlStringConexion.Controls.Add(this.txtStringConexion);
            this.pnlStringConexion.Controls.Add(this.label6);
            this.pnlStringConexion.Location = new System.Drawing.Point(318, 73);
            this.pnlStringConexion.Name = "pnlStringConexion";
            this.pnlStringConexion.Size = new System.Drawing.Size(226, 87);
            this.pnlStringConexion.TabIndex = 27;
            // 
            // txtStringConexion
            // 
            this.txtStringConexion.BackColor = System.Drawing.Color.Gray;
            this.txtStringConexion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStringConexion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStringConexion.ForeColor = System.Drawing.Color.White;
            this.txtStringConexion.Location = new System.Drawing.Point(12, 24);
            this.txtStringConexion.Multiline = true;
            this.txtStringConexion.Name = "txtStringConexion";
            this.txtStringConexion.Size = new System.Drawing.Size(196, 51);
            this.txtStringConexion.TabIndex = 28;
            // 
            // pnlForm2
            // 
            this.pnlForm2.Controls.Add(this.btnMostraTodas);
            this.pnlForm2.Controls.Add(this.btnConsultar);
            this.pnlForm2.Controls.Add(this.txtLenght);
            this.pnlForm2.Controls.Add(this.cmbType);
            this.pnlForm2.Controls.Add(this.label15);
            this.pnlForm2.Controls.Add(this.label11);
            this.pnlForm2.Controls.Add(this.label12);
            this.pnlForm2.Controls.Add(this.label13);
            this.pnlForm2.Controls.Add(this.cmbTb);
            this.pnlForm2.Controls.Add(this.label14);
            this.pnlForm2.Controls.Add(this.cmbBD);
            this.pnlForm2.Controls.Add(this.DgridTipos);
            this.pnlForm2.Location = new System.Drawing.Point(0, 33);
            this.pnlForm2.Name = "pnlForm2";
            this.pnlForm2.Size = new System.Drawing.Size(887, 546);
            this.pnlForm2.TabIndex = 28;
            this.pnlForm2.Visible = false;
            // 
            // btnMostraTodas
            // 
            this.btnMostraTodas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMostraTodas.FlatAppearance.BorderSize = 0;
            this.btnMostraTodas.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMostraTodas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMostraTodas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostraTodas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostraTodas.ForeColor = System.Drawing.Color.White;
            this.btnMostraTodas.Location = new System.Drawing.Point(428, 30);
            this.btnMostraTodas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMostraTodas.Name = "btnMostraTodas";
            this.btnMostraTodas.Size = new System.Drawing.Size(160, 28);
            this.btnMostraTodas.TabIndex = 32;
            this.btnMostraTodas.Text = "Mostrar Todas";
            this.btnMostraTodas.UseVisualStyleBackColor = false;
            this.btnMostraTodas.Click += new System.EventHandler(this.btnMostraTodas_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(299, 30);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(113, 28);
            this.btnConsultar.TabIndex = 32;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtLenght
            // 
            this.txtLenght.Location = new System.Drawing.Point(776, 6);
            this.txtLenght.Name = "txtLenght";
            this.txtLenght.Size = new System.Drawing.Size(41, 21);
            this.txtLenght.TabIndex = 31;
            this.txtLenght.TextChanged += new System.EventHandler(this.txtLenght_TextChanged);
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "tinyInt",
            "smallInt",
            "mediumInt",
            "int",
            "bigInt",
            "float",
            "double",
            "decimal",
            "date",
            "dateTime",
            "time",
            "char",
            "varchar",
            "tinytext",
            "text",
            "mediumtext",
            "longtext"});
            this.cmbType.Location = new System.Drawing.Point(630, 4);
            this.cmbType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 24);
            this.cmbType.TabIndex = 30;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(820, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 25);
            this.label15.TabIndex = 29;
            this.label15.Text = ")";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(753, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 25);
            this.label11.TabIndex = 29;
            this.label11.Text = "(";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(514, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 16);
            this.label12.TabIndex = 29;
            this.label12.Text = "Tipo de Dato:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(291, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 16);
            this.label13.TabIndex = 28;
            this.label13.Text = "Tablas:";
            // 
            // cmbTb
            // 
            this.cmbTb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTb.FormattingEnabled = true;
            this.cmbTb.Items.AddRange(new object[] {
            "ALL"});
            this.cmbTb.Location = new System.Drawing.Point(365, 4);
            this.cmbTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTb.Name = "cmbTb";
            this.cmbTb.Size = new System.Drawing.Size(139, 24);
            this.cmbTb.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(6, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 16);
            this.label14.TabIndex = 26;
            this.label14.Text = "Base de Datos:";
            // 
            // cmbBD
            // 
            this.cmbBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBD.FormattingEnabled = true;
            this.cmbBD.Location = new System.Drawing.Point(134, 4);
            this.cmbBD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbBD.Name = "cmbBD";
            this.cmbBD.Size = new System.Drawing.Size(150, 24);
            this.cmbBD.TabIndex = 25;
            this.cmbBD.SelectedIndexChanged += new System.EventHandler(this.cmbBD_SelectedIndexChanged);
            // 
            // DgridTipos
            // 
            this.DgridTipos.AllowUserToAddRows = false;
            this.DgridTipos.AllowUserToDeleteRows = false;
            this.DgridTipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgridTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgridTipos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgridTipos.Location = new System.Drawing.Point(0, 64);
            this.DgridTipos.Name = "DgridTipos";
            this.DgridTipos.ReadOnly = true;
            this.DgridTipos.Size = new System.Drawing.Size(887, 482);
            this.DgridTipos.TabIndex = 0;
            // 
            // btnTiposDatos
            // 
            this.btnTiposDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTiposDatos.FlatAppearance.BorderSize = 0;
            this.btnTiposDatos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTiposDatos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTiposDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiposDatos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiposDatos.ForeColor = System.Drawing.Color.White;
            this.btnTiposDatos.Location = new System.Drawing.Point(617, 168);
            this.btnTiposDatos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTiposDatos.Name = "btnTiposDatos";
            this.btnTiposDatos.Size = new System.Drawing.Size(223, 28);
            this.btnTiposDatos.TabIndex = 0;
            this.btnTiposDatos.Text = "Identifica TipoDeDatos";
            this.btnTiposDatos.UseVisualStyleBackColor = false;
            this.btnTiposDatos.Visible = false;
            this.btnTiposDatos.Click += new System.EventHandler(this.btnTiposDatos_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(887, 580);
            this.Controls.Add(this.pnlForm2);
            this.Controls.Add(this.pnlStringConexion);
            this.Controls.Add(this.lbEstado);
            this.Controls.Add(this.pnllogo);
            this.Controls.Add(this.cbTipoDato);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbTablas);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbBases);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.cbMotor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBases);
            this.Controls.Add(this.btnTiposDatos);
            this.Controls.Add(this.btnConectar);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ORM";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBases)).EndInit();
            this.pnllogo.ResumeLayout(false);
            this.pnllogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlStringConexion.ResumeLayout(false);
            this.pnlStringConexion.PerformLayout();
            this.pnlForm2.ResumeLayout(false);
            this.pnlForm2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgridTipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.DataGridView dgvBases;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMotor;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.ComboBox cbBases;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.ComboBox cbTablas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbTipoDato;
        private System.Windows.Forms.Panel pnllogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Panel pnlStringConexion;
        private System.Windows.Forms.TextBox txtStringConexion;
        private System.Windows.Forms.Panel pnlForm2;
        private System.Windows.Forms.DataGridView DgridTipos;
        private System.Windows.Forms.TextBox txtLenght;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbTb;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbBD;
        private System.Windows.Forms.Button btnTiposDatos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnMostraTodas;
    }
}

