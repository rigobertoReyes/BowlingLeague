namespace Bowling_League
{
    partial class FormNuevaLiga
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
            System.Windows.Forms.Label nombre_de_ligaLabel;
            System.Windows.Forms.Label nombreBolicheLabel;
            System.Windows.Forms.Label ciudadJuegoLabel;
            System.Windows.Forms.Label fechaInicioLabel;
            System.Windows.Forms.Label horaJuegoLabel;
            System.Windows.Forms.Label individualOEquipoLabel;
            System.Windows.Forms.Label cantidadEquiposLabel;
            System.Windows.Forms.Label nombrePresidenteLabel;
            System.Windows.Forms.Label nombreTesoreroLabel;
            System.Windows.Forms.Label nombreSecretarioGralLabel;
            this.nombre_de_ligaTextBox = new System.Windows.Forms.TextBox();
            this.ligasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bL_LigasDS = new Bowling_League.BL_LigasDS();
            this.nombreBolicheTextBox = new System.Windows.Forms.TextBox();
            this.ciudadJuegoTextBox = new System.Windows.Forms.TextBox();
            this.fechaInicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nombrePresidenteTextBox = new System.Windows.Forms.TextBox();
            this.nombreTesoreroTextBox = new System.Windows.Forms.TextBox();
            this.nombreSecretarioGralTextBox = new System.Windows.Forms.TextBox();
            this.lbldia = new System.Windows.Forms.Label();
            this.cbhora = new System.Windows.Forms.ComboBox();
            this.cbminuto = new System.Windows.Forms.ComboBox();
            this.cbampm = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.lblfechafin = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.bL_RolesDS = new Bowling_League.BL_RolesDS();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesTableAdapter = new Bowling_League.BL_RolesDSTableAdapters.RolesTableAdapter();
            this.tableAdapterManager1 = new Bowling_League.BL_RolesDSTableAdapters.TableAdapterManager();
            this.ligasTableAdapter = new Bowling_League.BL_LigasDSTableAdapters.LigasTableAdapter();
            this.tableAdapterManager = new Bowling_League.BL_LigasDSTableAdapters.TableAdapterManager();
            nombre_de_ligaLabel = new System.Windows.Forms.Label();
            nombreBolicheLabel = new System.Windows.Forms.Label();
            ciudadJuegoLabel = new System.Windows.Forms.Label();
            fechaInicioLabel = new System.Windows.Forms.Label();
            horaJuegoLabel = new System.Windows.Forms.Label();
            individualOEquipoLabel = new System.Windows.Forms.Label();
            cantidadEquiposLabel = new System.Windows.Forms.Label();
            nombrePresidenteLabel = new System.Windows.Forms.Label();
            nombreTesoreroLabel = new System.Windows.Forms.Label();
            nombreSecretarioGralLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ligasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bL_LigasDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bL_RolesDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nombre_de_ligaLabel
            // 
            nombre_de_ligaLabel.AutoSize = true;
            nombre_de_ligaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombre_de_ligaLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            nombre_de_ligaLabel.Location = new System.Drawing.Point(6, 26);
            nombre_de_ligaLabel.Name = "nombre_de_ligaLabel";
            nombre_de_ligaLabel.Size = new System.Drawing.Size(110, 15);
            nombre_de_ligaLabel.TabIndex = 4;
            nombre_de_ligaLabel.Text = "Nombre de liga:";
            // 
            // nombreBolicheLabel
            // 
            nombreBolicheLabel.AutoSize = true;
            nombreBolicheLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreBolicheLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            nombreBolicheLabel.Location = new System.Drawing.Point(6, 162);
            nombreBolicheLabel.Name = "nombreBolicheLabel";
            nombreBolicheLabel.Size = new System.Drawing.Size(114, 15);
            nombreBolicheLabel.TabIndex = 6;
            nombreBolicheLabel.Text = "Nombre Boliche:";
            // 
            // ciudadJuegoLabel
            // 
            ciudadJuegoLabel.AutoSize = true;
            ciudadJuegoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ciudadJuegoLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            ciudadJuegoLabel.Location = new System.Drawing.Point(6, 209);
            ciudadJuegoLabel.Name = "ciudadJuegoLabel";
            ciudadJuegoLabel.Size = new System.Drawing.Size(99, 15);
            ciudadJuegoLabel.TabIndex = 8;
            ciudadJuegoLabel.Text = "Ciudad Juego:";
            // 
            // fechaInicioLabel
            // 
            fechaInicioLabel.AutoSize = true;
            fechaInicioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaInicioLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            fechaInicioLabel.Location = new System.Drawing.Point(6, 25);
            fechaInicioLabel.Name = "fechaInicioLabel";
            fechaInicioLabel.Size = new System.Drawing.Size(89, 15);
            fechaInicioLabel.TabIndex = 10;
            fechaInicioLabel.Text = "Fecha Inicio:";
            // 
            // horaJuegoLabel
            // 
            horaJuegoLabel.AutoSize = true;
            horaJuegoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            horaJuegoLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            horaJuegoLabel.Location = new System.Drawing.Point(6, 112);
            horaJuegoLabel.Name = "horaJuegoLabel";
            horaJuegoLabel.Size = new System.Drawing.Size(85, 15);
            horaJuegoLabel.TabIndex = 14;
            horaJuegoLabel.Text = "Hora Juego:";
            // 
            // individualOEquipoLabel
            // 
            individualOEquipoLabel.AutoSize = true;
            individualOEquipoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            individualOEquipoLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            individualOEquipoLabel.Location = new System.Drawing.Point(6, 68);
            individualOEquipoLabel.Name = "individualOEquipoLabel";
            individualOEquipoLabel.Size = new System.Drawing.Size(132, 15);
            individualOEquipoLabel.TabIndex = 16;
            individualOEquipoLabel.Text = "Individual OEquipo:";
            // 
            // cantidadEquiposLabel
            // 
            cantidadEquiposLabel.AutoSize = true;
            cantidadEquiposLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cantidadEquiposLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            cantidadEquiposLabel.Location = new System.Drawing.Point(6, 67);
            cantidadEquiposLabel.Name = "cantidadEquiposLabel";
            cantidadEquiposLabel.Size = new System.Drawing.Size(124, 15);
            cantidadEquiposLabel.TabIndex = 18;
            cantidadEquiposLabel.Text = "Cantidad Equipos:";
            // 
            // nombrePresidenteLabel
            // 
            nombrePresidenteLabel.AutoSize = true;
            nombrePresidenteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombrePresidenteLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            nombrePresidenteLabel.Location = new System.Drawing.Point(6, 16);
            nombrePresidenteLabel.Name = "nombrePresidenteLabel";
            nombrePresidenteLabel.Size = new System.Drawing.Size(135, 15);
            nombrePresidenteLabel.TabIndex = 26;
            nombrePresidenteLabel.Text = "Nombre Presidente:";
            // 
            // nombreTesoreroLabel
            // 
            nombreTesoreroLabel.AutoSize = true;
            nombreTesoreroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreTesoreroLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            nombreTesoreroLabel.Location = new System.Drawing.Point(6, 60);
            nombreTesoreroLabel.Name = "nombreTesoreroLabel";
            nombreTesoreroLabel.Size = new System.Drawing.Size(123, 15);
            nombreTesoreroLabel.TabIndex = 28;
            nombreTesoreroLabel.Text = "Nombre Tesorero:";
            // 
            // nombreSecretarioGralLabel
            // 
            nombreSecretarioGralLabel.AutoSize = true;
            nombreSecretarioGralLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreSecretarioGralLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            nombreSecretarioGralLabel.Location = new System.Drawing.Point(6, 106);
            nombreSecretarioGralLabel.Name = "nombreSecretarioGralLabel";
            nombreSecretarioGralLabel.Size = new System.Drawing.Size(163, 15);
            nombreSecretarioGralLabel.TabIndex = 30;
            nombreSecretarioGralLabel.Text = "Nombre Secretario Gral:";
            // 
            // nombre_de_ligaTextBox
            // 
            this.nombre_de_ligaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ligasBindingSource, "Nombre_de_liga", true));
            this.nombre_de_ligaTextBox.Location = new System.Drawing.Point(191, 23);
            this.nombre_de_ligaTextBox.Name = "nombre_de_ligaTextBox";
            this.nombre_de_ligaTextBox.Size = new System.Drawing.Size(216, 20);
            this.nombre_de_ligaTextBox.TabIndex = 2;
            // 
            // ligasBindingSource
            // 
            this.ligasBindingSource.DataMember = "Ligas";
            this.ligasBindingSource.DataSource = this.bL_LigasDS;
            // 
            // bL_LigasDS
            // 
            this.bL_LigasDS.DataSetName = "BL_LigasDS";
            this.bL_LigasDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nombreBolicheTextBox
            // 
            this.nombreBolicheTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ligasBindingSource, "NombreBoliche", true));
            this.nombreBolicheTextBox.Location = new System.Drawing.Point(191, 159);
            this.nombreBolicheTextBox.Name = "nombreBolicheTextBox";
            this.nombreBolicheTextBox.Size = new System.Drawing.Size(216, 20);
            this.nombreBolicheTextBox.TabIndex = 7;
            // 
            // ciudadJuegoTextBox
            // 
            this.ciudadJuegoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ligasBindingSource, "CiudadJuego", true));
            this.ciudadJuegoTextBox.Location = new System.Drawing.Point(191, 206);
            this.ciudadJuegoTextBox.Name = "ciudadJuegoTextBox";
            this.ciudadJuegoTextBox.Size = new System.Drawing.Size(216, 20);
            this.ciudadJuegoTextBox.TabIndex = 8;
            // 
            // fechaInicioDateTimePicker
            // 
            this.fechaInicioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ligasBindingSource, "FechaInicio", true));
            this.fechaInicioDateTimePicker.Location = new System.Drawing.Point(191, 21);
            this.fechaInicioDateTimePicker.Name = "fechaInicioDateTimePicker";
            this.fechaInicioDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaInicioDateTimePicker.TabIndex = 0;
            this.fechaInicioDateTimePicker.ValueChanged += new System.EventHandler(this.fechaInicioDateTimePicker_ValueChanged);
            // 
            // nombrePresidenteTextBox
            // 
            this.nombrePresidenteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ligasBindingSource, "NombrePresidente", true));
            this.nombrePresidenteTextBox.Enabled = false;
            this.nombrePresidenteTextBox.Location = new System.Drawing.Point(191, 13);
            this.nombrePresidenteTextBox.Name = "nombrePresidenteTextBox";
            this.nombrePresidenteTextBox.Size = new System.Drawing.Size(156, 20);
            this.nombrePresidenteTextBox.TabIndex = 1;
            // 
            // nombreTesoreroTextBox
            // 
            this.nombreTesoreroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ligasBindingSource, "NombreTesorero", true));
            this.nombreTesoreroTextBox.Enabled = false;
            this.nombreTesoreroTextBox.Location = new System.Drawing.Point(191, 57);
            this.nombreTesoreroTextBox.Name = "nombreTesoreroTextBox";
            this.nombreTesoreroTextBox.Size = new System.Drawing.Size(156, 20);
            this.nombreTesoreroTextBox.TabIndex = 2;
            // 
            // nombreSecretarioGralTextBox
            // 
            this.nombreSecretarioGralTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ligasBindingSource, "NombreSecretarioGral", true));
            this.nombreSecretarioGralTextBox.Enabled = false;
            this.nombreSecretarioGralTextBox.Location = new System.Drawing.Point(191, 103);
            this.nombreSecretarioGralTextBox.Name = "nombreSecretarioGralTextBox";
            this.nombreSecretarioGralTextBox.Size = new System.Drawing.Size(156, 20);
            this.nombreSecretarioGralTextBox.TabIndex = 3;
            // 
            // lbldia
            // 
            this.lbldia.AutoSize = true;
            this.lbldia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldia.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbldia.Location = new System.Drawing.Point(406, 25);
            this.lbldia.Name = "lbldia";
            this.lbldia.Size = new System.Drawing.Size(118, 15);
            this.lbldia.TabIndex = 32;
            this.lbldia.Text = "(Se jugara cada )";
            // 
            // cbhora
            // 
            this.cbhora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbhora.FormattingEnabled = true;
            this.cbhora.Items.AddRange(new object[] {
            "12",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11"});
            this.cbhora.Location = new System.Drawing.Point(191, 112);
            this.cbhora.Name = "cbhora";
            this.cbhora.Size = new System.Drawing.Size(68, 21);
            this.cbhora.TabIndex = 4;
            // 
            // cbminuto
            // 
            this.cbminuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbminuto.FormattingEnabled = true;
            this.cbminuto.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cbminuto.Location = new System.Drawing.Point(265, 112);
            this.cbminuto.Name = "cbminuto";
            this.cbminuto.Size = new System.Drawing.Size(68, 21);
            this.cbminuto.TabIndex = 5;
            // 
            // cbampm
            // 
            this.cbampm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbampm.FormattingEnabled = true;
            this.cbampm.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cbampm.Location = new System.Drawing.Point(339, 112);
            this.cbampm.Name = "cbampm";
            this.cbampm.Size = new System.Drawing.Size(68, 21);
            this.cbampm.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(11, 134);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(380, 274);
            this.listBox1.TabIndex = 36;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRecorrer.Enabled = false;
            this.btnRecorrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecorrer.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRecorrer.Location = new System.Drawing.Point(406, 133);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRecorrer.Size = new System.Drawing.Size(95, 45);
            this.btnRecorrer.TabIndex = 37;
            this.btnRecorrer.Text = "Recorrer semanas";
            this.btnRecorrer.UseVisualStyleBackColor = false;
            this.btnRecorrer.Click += new System.EventHandler(this.txtRecorrer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(8, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "Numero de semanas";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(191, 98);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            52,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Location = new System.Drawing.Point(250, 91);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button4.Size = new System.Drawing.Size(95, 31);
            this.button4.TabIndex = 3;
            this.button4.Text = "Generar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(nombrePresidenteLabel);
            this.groupBox1.Controls.Add(this.nombreSecretarioGralTextBox);
            this.groupBox1.Controls.Add(nombreSecretarioGralLabel);
            this.groupBox1.Controls.Add(this.nombreTesoreroTextBox);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(nombreTesoreroLabel);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.nombrePresidenteTextBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(23, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 146);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Bowling_League.Properties.Resources.adduser;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(353, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 32);
            this.button3.TabIndex = 40;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Bowling_League.Properties.Resources.adduser;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(353, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 32);
            this.button2.TabIndex = 39;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Bowling_League.Properties.Resources.adduser;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(353, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 32);
            this.button1.TabIndex = 38;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(191, 61);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblfechafin
            // 
            this.lblfechafin.AutoSize = true;
            this.lblfechafin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechafin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblfechafin.Location = new System.Drawing.Point(403, 197);
            this.lblfechafin.Name = "lblfechafin";
            this.lblfechafin.Size = new System.Drawing.Size(86, 15);
            this.lblfechafin.TabIndex = 46;
            this.lblfechafin.Text = "Fecha Final:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Individual",
            "Equipo"});
            this.comboBox1.Location = new System.Drawing.Point(191, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(nombre_de_ligaLabel);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(individualOEquipoLabel);
            this.groupBox2.Controls.Add(horaJuegoLabel);
            this.groupBox2.Controls.Add(this.ciudadJuegoTextBox);
            this.groupBox2.Controls.Add(ciudadJuegoLabel);
            this.groupBox2.Controls.Add(this.nombreBolicheTextBox);
            this.groupBox2.Controls.Add(nombreBolicheLabel);
            this.groupBox2.Controls.Add(this.nombre_de_ligaTextBox);
            this.groupBox2.Controls.Add(this.cbhora);
            this.groupBox2.Controls.Add(this.cbminuto);
            this.groupBox2.Controls.Add(this.cbampm);
            this.groupBox2.Location = new System.Drawing.Point(23, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 256);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(464, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 29);
            this.label2.TabIndex = 49;
            this.label2.Text = "Nueva Liga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(138, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "Datos de la liga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(138, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 24);
            this.label4.TabIndex = 51;
            this.label4.Text = "Representantes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Bowling_League.Properties.Resources.Back;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 44);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(fechaInicioLabel);
            this.groupBox3.Controls.Add(cantidadEquiposLabel);
            this.groupBox3.Controls.Add(this.fechaInicioDateTimePicker);
            this.groupBox3.Controls.Add(this.lbldia);
            this.groupBox3.Controls.Add(this.lblfechafin);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.numericUpDown2);
            this.groupBox3.Controls.Add(this.btnRecorrer);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Location = new System.Drawing.Point(469, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(598, 434);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(746, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 24);
            this.label5.TabIndex = 53;
            this.label5.Text = "Fechas";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RoyalBlue;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button5.Location = new System.Drawing.Point(959, 511);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 34);
            this.button5.TabIndex = 54;
            this.button5.Text = "Guardar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.RoyalBlue;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button6.Location = new System.Drawing.Point(835, 511);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 34);
            this.button6.TabIndex = 55;
            this.button6.Text = "Cancelar";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // bL_RolesDS
            // 
            this.bL_RolesDS.DataSetName = "BL_RolesDS";
            this.bL_RolesDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.bL_RolesDS;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.RolesTableAdapter = this.rolesTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Bowling_League.BL_RolesDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ligasTableAdapter
            // 
            this.ligasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Bowling_League.BL_LigasDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormNuevaLiga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1088, 554);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormNuevaLiga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Liga";
            this.Load += new System.EventHandler(this.FormNuevaLiga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ligasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bL_LigasDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bL_RolesDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private BL_LigasDS bL_LigasDS;
        private System.Windows.Forms.BindingSource ligasBindingSource;
        private BL_LigasDSTableAdapters.LigasTableAdapter ligasTableAdapter;
        private BL_LigasDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nombre_de_ligaTextBox;
        private System.Windows.Forms.TextBox nombreBolicheTextBox;
        private System.Windows.Forms.TextBox ciudadJuegoTextBox;
        private System.Windows.Forms.DateTimePicker fechaInicioDateTimePicker;
        private System.Windows.Forms.TextBox nombrePresidenteTextBox;
        private System.Windows.Forms.TextBox nombreTesoreroTextBox;
        private System.Windows.Forms.TextBox nombreSecretarioGralTextBox;
        private System.Windows.Forms.Label lbldia;
        private System.Windows.Forms.ComboBox cbhora;
        private System.Windows.Forms.ComboBox cbminuto;
        private System.Windows.Forms.ComboBox cbampm;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label lblfechafin;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private BL_RolesDS bL_RolesDS;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private BL_RolesDSTableAdapters.RolesTableAdapter rolesTableAdapter;
        private BL_RolesDSTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}