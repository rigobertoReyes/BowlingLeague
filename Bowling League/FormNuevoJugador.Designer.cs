namespace Bowling_League
{
    partial class FormNuevoJugador
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
            System.Windows.Forms.Label no_jugadorLabel;
            System.Windows.Forms.Label puestoDelJugadorLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label fechaNacimientoLabel;
            System.Windows.Forms.Label apellidoPaternoLabel;
            System.Windows.Forms.Label estadoNacimientoLabel;
            System.Windows.Forms.Label apellidoMaternoLabel;
            System.Windows.Forms.Label ciudadNacimientoLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label pinosEntLabel;
            System.Windows.Forms.Label promedioLabel;
            System.Windows.Forms.Label juegosJugadosLabel;
            System.Windows.Forms.Label pinosLabel;
            System.Windows.Forms.Label handycapLabel;
            System.Windows.Forms.Label highGameHandycapLabel;
            System.Windows.Forms.Label highGameScratchLabel;
            System.Windows.Forms.Label highSeriesScratchLabel;
            this.bL_DBDataSet = new Bowling_League.BL_DBDataSet();
            this.jugadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jugadoresTableAdapter = new Bowling_League.BL_DBDataSetTableAdapters.JugadoresTableAdapter();
            this.tableAdapterManager = new Bowling_League.BL_DBDataSetTableAdapters.TableAdapterManager();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPuesto = new System.Windows.Forms.ComboBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.no_jugadorTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.estadoNacimientoTextBox = new System.Windows.Forms.TextBox();
            this.apellidoPaternoTextBox = new System.Windows.Forms.TextBox();
            this.ciudadNacimientoTextBox = new System.Windows.Forms.TextBox();
            this.apellidoMaternoTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.txtConfirmpass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nmPromedio = new System.Windows.Forms.NumericUpDown();
            this.nmJuegosJugados = new System.Windows.Forms.NumericUpDown();
            this.nmPinos = new System.Windows.Forms.NumericUpDown();
            this.nmHGH = new System.Windows.Forms.NumericUpDown();
            this.nmHSS = new System.Windows.Forms.NumericUpDown();
            this.nmHGS = new System.Windows.Forms.NumericUpDown();
            this.nmHandycap = new System.Windows.Forms.NumericUpDown();
            this.nmPinosEnt = new System.Windows.Forms.NumericUpDown();
            no_jugadorLabel = new System.Windows.Forms.Label();
            puestoDelJugadorLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            apellidoPaternoLabel = new System.Windows.Forms.Label();
            estadoNacimientoLabel = new System.Windows.Forms.Label();
            apellidoMaternoLabel = new System.Windows.Forms.Label();
            ciudadNacimientoLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            pinosEntLabel = new System.Windows.Forms.Label();
            promedioLabel = new System.Windows.Forms.Label();
            juegosJugadosLabel = new System.Windows.Forms.Label();
            pinosLabel = new System.Windows.Forms.Label();
            handycapLabel = new System.Windows.Forms.Label();
            highGameHandycapLabel = new System.Windows.Forms.Label();
            highGameScratchLabel = new System.Windows.Forms.Label();
            highSeriesScratchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bL_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadoresBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPromedio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmJuegosJugados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPinos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHGH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHGS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHandycap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPinosEnt)).BeginInit();
            this.SuspendLayout();
            // 
            // no_jugadorLabel
            // 
            no_jugadorLabel.AutoSize = true;
            no_jugadorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            no_jugadorLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            no_jugadorLabel.Location = new System.Drawing.Point(6, 16);
            no_jugadorLabel.Name = "no_jugadorLabel";
            no_jugadorLabel.Size = new System.Drawing.Size(82, 15);
            no_jugadorLabel.TabIndex = 8;
            no_jugadorLabel.Text = "No jugador:";
            // 
            // puestoDelJugadorLabel
            // 
            puestoDelJugadorLabel.AutoSize = true;
            puestoDelJugadorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            puestoDelJugadorLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            puestoDelJugadorLabel.Location = new System.Drawing.Point(6, 224);
            puestoDelJugadorLabel.Name = "puestoDelJugadorLabel";
            puestoDelJugadorLabel.Size = new System.Drawing.Size(137, 15);
            puestoDelJugadorLabel.TabIndex = 24;
            puestoDelJugadorLabel.Text = "Puesto Del Jugador:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sexoLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            sexoLabel.Location = new System.Drawing.Point(6, 198);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(43, 15);
            sexoLabel.TabIndex = 22;
            sexoLabel.Text = "Sexo:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            nombreLabel.Location = new System.Drawing.Point(6, 42);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(62, 15);
            nombreLabel.TabIndex = 10;
            nombreLabel.Text = "Nombre:";
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaNacimientoLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            fechaNacimientoLabel.Location = new System.Drawing.Point(6, 173);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(127, 15);
            fechaNacimientoLabel.TabIndex = 20;
            fechaNacimientoLabel.Text = "Fecha Nacimiento:";
            // 
            // apellidoPaternoLabel
            // 
            apellidoPaternoLabel.AutoSize = true;
            apellidoPaternoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidoPaternoLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            apellidoPaternoLabel.Location = new System.Drawing.Point(6, 68);
            apellidoPaternoLabel.Name = "apellidoPaternoLabel";
            apellidoPaternoLabel.Size = new System.Drawing.Size(117, 15);
            apellidoPaternoLabel.TabIndex = 12;
            apellidoPaternoLabel.Text = "Apellido Paterno:";
            // 
            // estadoNacimientoLabel
            // 
            estadoNacimientoLabel.AutoSize = true;
            estadoNacimientoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estadoNacimientoLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            estadoNacimientoLabel.Location = new System.Drawing.Point(6, 146);
            estadoNacimientoLabel.Name = "estadoNacimientoLabel";
            estadoNacimientoLabel.Size = new System.Drawing.Size(132, 15);
            estadoNacimientoLabel.TabIndex = 18;
            estadoNacimientoLabel.Text = "Estado Nacimiento:";
            // 
            // apellidoMaternoLabel
            // 
            apellidoMaternoLabel.AutoSize = true;
            apellidoMaternoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidoMaternoLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            apellidoMaternoLabel.Location = new System.Drawing.Point(6, 94);
            apellidoMaternoLabel.Name = "apellidoMaternoLabel";
            apellidoMaternoLabel.Size = new System.Drawing.Size(120, 15);
            apellidoMaternoLabel.TabIndex = 14;
            apellidoMaternoLabel.Text = "Apellido Materno:";
            // 
            // ciudadNacimientoLabel
            // 
            ciudadNacimientoLabel.AutoSize = true;
            ciudadNacimientoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ciudadNacimientoLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            ciudadNacimientoLabel.Location = new System.Drawing.Point(6, 120);
            ciudadNacimientoLabel.Name = "ciudadNacimientoLabel";
            ciudadNacimientoLabel.Size = new System.Drawing.Size(133, 15);
            ciudadNacimientoLabel.TabIndex = 16;
            ciudadNacimientoLabel.Text = "Ciudad Nacimiento:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            passwordLabel.Location = new System.Drawing.Point(6, 16);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(80, 15);
            passwordLabel.TabIndex = 42;
            passwordLabel.Text = "Contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            label2.Location = new System.Drawing.Point(6, 54);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 30);
            label2.TabIndex = 44;
            label2.Text = "Confirmar\r\ncontraseña";
            // 
            // pinosEntLabel
            // 
            pinosEntLabel.AutoSize = true;
            pinosEntLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pinosEntLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            pinosEntLabel.Location = new System.Drawing.Point(7, 16);
            pinosEntLabel.Name = "pinosEntLabel";
            pinosEntLabel.Size = new System.Drawing.Size(72, 15);
            pinosEntLabel.TabIndex = 26;
            pinosEntLabel.Text = "Pinos Ent:";
            // 
            // promedioLabel
            // 
            promedioLabel.AutoSize = true;
            promedioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            promedioLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            promedioLabel.Location = new System.Drawing.Point(7, 198);
            promedioLabel.Name = "promedioLabel";
            promedioLabel.Size = new System.Drawing.Size(73, 15);
            promedioLabel.TabIndex = 40;
            promedioLabel.Text = "Promedio:";
            // 
            // juegosJugadosLabel
            // 
            juegosJugadosLabel.AutoSize = true;
            juegosJugadosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            juegosJugadosLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            juegosJugadosLabel.Location = new System.Drawing.Point(7, 172);
            juegosJugadosLabel.Name = "juegosJugadosLabel";
            juegosJugadosLabel.Size = new System.Drawing.Size(115, 15);
            juegosJugadosLabel.TabIndex = 38;
            juegosJugadosLabel.Text = "Juegos Jugados:";
            // 
            // pinosLabel
            // 
            pinosLabel.AutoSize = true;
            pinosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pinosLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            pinosLabel.Location = new System.Drawing.Point(7, 146);
            pinosLabel.Name = "pinosLabel";
            pinosLabel.Size = new System.Drawing.Size(47, 15);
            pinosLabel.TabIndex = 36;
            pinosLabel.Text = "Pinos:";
            // 
            // handycapLabel
            // 
            handycapLabel.AutoSize = true;
            handycapLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            handycapLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            handycapLabel.Location = new System.Drawing.Point(7, 42);
            handycapLabel.Name = "handycapLabel";
            handycapLabel.Size = new System.Drawing.Size(74, 15);
            handycapLabel.TabIndex = 28;
            handycapLabel.Text = "Handycap:";
            // 
            // highGameHandycapLabel
            // 
            highGameHandycapLabel.AutoSize = true;
            highGameHandycapLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            highGameHandycapLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            highGameHandycapLabel.Location = new System.Drawing.Point(7, 120);
            highGameHandycapLabel.Name = "highGameHandycapLabel";
            highGameHandycapLabel.Size = new System.Drawing.Size(150, 15);
            highGameHandycapLabel.TabIndex = 34;
            highGameHandycapLabel.Text = "High Game Handycap:";
            // 
            // highGameScratchLabel
            // 
            highGameScratchLabel.AutoSize = true;
            highGameScratchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            highGameScratchLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            highGameScratchLabel.Location = new System.Drawing.Point(7, 68);
            highGameScratchLabel.Name = "highGameScratchLabel";
            highGameScratchLabel.Size = new System.Drawing.Size(135, 15);
            highGameScratchLabel.TabIndex = 30;
            highGameScratchLabel.Text = "High Game Scratch:";
            // 
            // highSeriesScratchLabel
            // 
            highSeriesScratchLabel.AutoSize = true;
            highSeriesScratchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            highSeriesScratchLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            highSeriesScratchLabel.Location = new System.Drawing.Point(7, 94);
            highSeriesScratchLabel.Name = "highSeriesScratchLabel";
            highSeriesScratchLabel.Size = new System.Drawing.Size(138, 15);
            highSeriesScratchLabel.TabIndex = 32;
            highSeriesScratchLabel.Text = "High Series Scratch:";
            // 
            // bL_DBDataSet
            // 
            this.bL_DBDataSet.DataSetName = "BL_DBDataSet";
            this.bL_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jugadoresBindingSource
            // 
            this.jugadoresBindingSource.DataMember = "Jugadores";
            this.jugadoresBindingSource.DataSource = this.bL_DBDataSet;
            // 
            // jugadoresTableAdapter
            // 
            this.jugadoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.JugadoresTableAdapter = this.jugadoresTableAdapter;
            this.tableAdapterManager.UpdateOrder = Bowling_League.BL_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbPuesto);
            this.groupBox2.Controls.Add(this.cbSexo);
            this.groupBox2.Controls.Add(no_jugadorLabel);
            this.groupBox2.Controls.Add(puestoDelJugadorLabel);
            this.groupBox2.Controls.Add(this.no_jugadorTextBox);
            this.groupBox2.Controls.Add(sexoLabel);
            this.groupBox2.Controls.Add(nombreLabel);
            this.groupBox2.Controls.Add(this.fechaNacimientoDateTimePicker);
            this.groupBox2.Controls.Add(this.nombreTextBox);
            this.groupBox2.Controls.Add(fechaNacimientoLabel);
            this.groupBox2.Controls.Add(apellidoPaternoLabel);
            this.groupBox2.Controls.Add(this.estadoNacimientoTextBox);
            this.groupBox2.Controls.Add(this.apellidoPaternoTextBox);
            this.groupBox2.Controls.Add(estadoNacimientoLabel);
            this.groupBox2.Controls.Add(apellidoMaternoLabel);
            this.groupBox2.Controls.Add(this.ciudadNacimientoTextBox);
            this.groupBox2.Controls.Add(this.apellidoMaternoTextBox);
            this.groupBox2.Controls.Add(ciudadNacimientoLabel);
            this.groupBox2.Location = new System.Drawing.Point(33, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 257);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            // 
            // cbPuesto
            // 
            this.cbPuesto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.jugadoresBindingSource, "PuestoDelJugador", true));
            this.cbPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPuesto.FormattingEnabled = true;
            this.cbPuesto.Items.AddRange(new object[] {
            "Administrador",
            "Presidente",
            "Secretario General",
            "Tesorero",
            "Jugador"});
            this.cbPuesto.Location = new System.Drawing.Point(144, 224);
            this.cbPuesto.Name = "cbPuesto";
            this.cbPuesto.Size = new System.Drawing.Size(183, 21);
            this.cbPuesto.TabIndex = 26;
            // 
            // cbSexo
            // 
            this.cbSexo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.jugadoresBindingSource, "Sexo", true));
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbSexo.Location = new System.Drawing.Point(144, 196);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(183, 21);
            this.cbSexo.TabIndex = 25;
            // 
            // no_jugadorTextBox
            // 
            this.no_jugadorTextBox.Location = new System.Drawing.Point(144, 13);
            this.no_jugadorTextBox.Name = "no_jugadorTextBox";
            this.no_jugadorTextBox.Size = new System.Drawing.Size(183, 20);
            this.no_jugadorTextBox.TabIndex = 0;
            this.no_jugadorTextBox.TextChanged += new System.EventHandler(this.no_jugadorTextBox_TextChanged);
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.jugadoresBindingSource, "FechaNacimiento", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(144, 169);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(183, 20);
            this.fechaNacimientoDateTimePicker.TabIndex = 6;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(144, 39);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(183, 20);
            this.nombreTextBox.TabIndex = 1;
            // 
            // estadoNacimientoTextBox
            // 
            this.estadoNacimientoTextBox.Location = new System.Drawing.Point(144, 143);
            this.estadoNacimientoTextBox.Name = "estadoNacimientoTextBox";
            this.estadoNacimientoTextBox.Size = new System.Drawing.Size(183, 20);
            this.estadoNacimientoTextBox.TabIndex = 5;
            // 
            // apellidoPaternoTextBox
            // 
            this.apellidoPaternoTextBox.Location = new System.Drawing.Point(144, 65);
            this.apellidoPaternoTextBox.Name = "apellidoPaternoTextBox";
            this.apellidoPaternoTextBox.Size = new System.Drawing.Size(183, 20);
            this.apellidoPaternoTextBox.TabIndex = 2;
            // 
            // ciudadNacimientoTextBox
            // 
            this.ciudadNacimientoTextBox.Location = new System.Drawing.Point(144, 117);
            this.ciudadNacimientoTextBox.Name = "ciudadNacimientoTextBox";
            this.ciudadNacimientoTextBox.Size = new System.Drawing.Size(183, 20);
            this.ciudadNacimientoTextBox.TabIndex = 4;
            // 
            // apellidoMaternoTextBox
            // 
            this.apellidoMaternoTextBox.Location = new System.Drawing.Point(144, 91);
            this.apellidoMaternoTextBox.Name = "apellidoMaternoTextBox";
            this.apellidoMaternoTextBox.Size = new System.Drawing.Size(183, 20);
            this.apellidoMaternoTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(122, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 18);
            this.label3.TabIndex = 50;
            this.label3.Text = "Informacion Personal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(155, 594);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 54;
            this.label5.Text = "Contraseña";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(passwordLabel);
            this.groupBox4.Controls.Add(this.passwordTextBox);
            this.groupBox4.Controls.Add(this.txtConfirmpass);
            this.groupBox4.Controls.Add(label2);
            this.groupBox4.Location = new System.Drawing.Point(31, 615);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(342, 100);
            this.groupBox4.TabIndex = 53;
            this.groupBox4.TabStop = false;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(127, 17);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(200, 20);
            this.passwordTextBox.TabIndex = 0;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // txtConfirmpass
            // 
            this.txtConfirmpass.Location = new System.Drawing.Point(127, 55);
            this.txtConfirmpass.Name = "txtConfirmpass";
            this.txtConfirmpass.Size = new System.Drawing.Size(200, 20);
            this.txtConfirmpass.TabIndex = 1;
            this.txtConfirmpass.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(219, 735);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 38);
            this.button1.TabIndex = 55;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(157, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 57;
            this.label4.Text = "Estadisticas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nmPromedio);
            this.groupBox3.Controls.Add(this.nmJuegosJugados);
            this.groupBox3.Controls.Add(this.nmPinos);
            this.groupBox3.Controls.Add(this.nmHGH);
            this.groupBox3.Controls.Add(this.nmHSS);
            this.groupBox3.Controls.Add(this.nmHGS);
            this.groupBox3.Controls.Add(this.nmHandycap);
            this.groupBox3.Controls.Add(this.nmPinosEnt);
            this.groupBox3.Controls.Add(pinosEntLabel);
            this.groupBox3.Controls.Add(promedioLabel);
            this.groupBox3.Controls.Add(juegosJugadosLabel);
            this.groupBox3.Controls.Add(pinosLabel);
            this.groupBox3.Controls.Add(handycapLabel);
            this.groupBox3.Controls.Add(highGameHandycapLabel);
            this.groupBox3.Controls.Add(highGameScratchLabel);
            this.groupBox3.Controls.Add(highSeriesScratchLabel);
            this.groupBox3.Location = new System.Drawing.Point(33, 337);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 233);
            this.groupBox3.TabIndex = 56;
            this.groupBox3.TabStop = false;
            // 
            // nmPromedio
            // 
            this.nmPromedio.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.jugadoresBindingSource, "Promedio", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.nmPromedio.DecimalPlaces = 2;
            this.nmPromedio.Location = new System.Drawing.Point(158, 198);
            this.nmPromedio.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmPromedio.Name = "nmPromedio";
            this.nmPromedio.Size = new System.Drawing.Size(120, 20);
            this.nmPromedio.TabIndex = 48;
            // 
            // nmJuegosJugados
            // 
            this.nmJuegosJugados.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.jugadoresBindingSource, "JuegosJugados", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.nmJuegosJugados.Location = new System.Drawing.Point(158, 172);
            this.nmJuegosJugados.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmJuegosJugados.Name = "nmJuegosJugados";
            this.nmJuegosJugados.Size = new System.Drawing.Size(120, 20);
            this.nmJuegosJugados.TabIndex = 47;
            // 
            // nmPinos
            // 
            this.nmPinos.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.jugadoresBindingSource, "Pinos", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.nmPinos.Location = new System.Drawing.Point(158, 145);
            this.nmPinos.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmPinos.Name = "nmPinos";
            this.nmPinos.Size = new System.Drawing.Size(120, 20);
            this.nmPinos.TabIndex = 46;
            // 
            // nmHGH
            // 
            this.nmHGH.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.jugadoresBindingSource, "HighGameHandycap", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.nmHGH.Location = new System.Drawing.Point(158, 120);
            this.nmHGH.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmHGH.Name = "nmHGH";
            this.nmHGH.Size = new System.Drawing.Size(120, 20);
            this.nmHGH.TabIndex = 45;
            // 
            // nmHSS
            // 
            this.nmHSS.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.jugadoresBindingSource, "HighSeriesScratch", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.nmHSS.Location = new System.Drawing.Point(158, 94);
            this.nmHSS.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmHSS.Name = "nmHSS";
            this.nmHSS.Size = new System.Drawing.Size(120, 20);
            this.nmHSS.TabIndex = 44;
            // 
            // nmHGS
            // 
            this.nmHGS.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.jugadoresBindingSource, "HighGameScratch", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.nmHGS.Location = new System.Drawing.Point(158, 68);
            this.nmHGS.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmHGS.Name = "nmHGS";
            this.nmHGS.Size = new System.Drawing.Size(120, 20);
            this.nmHGS.TabIndex = 43;
            // 
            // nmHandycap
            // 
            this.nmHandycap.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.jugadoresBindingSource, "Handycap", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.nmHandycap.Location = new System.Drawing.Point(158, 42);
            this.nmHandycap.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmHandycap.Name = "nmHandycap";
            this.nmHandycap.Size = new System.Drawing.Size(120, 20);
            this.nmHandycap.TabIndex = 42;
            // 
            // nmPinosEnt
            // 
            this.nmPinosEnt.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.jugadoresBindingSource, "PinosEnt", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.nmPinosEnt.Location = new System.Drawing.Point(158, 15);
            this.nmPinosEnt.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmPinosEnt.Name = "nmPinosEnt";
            this.nmPinosEnt.Size = new System.Drawing.Size(120, 20);
            this.nmPinosEnt.TabIndex = 41;
            // 
            // FormNuevoJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(432, 785);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormNuevoJugador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Jugador";
            this.Load += new System.EventHandler(this.FormNuevoJugador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bL_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadoresBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPromedio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmJuegosJugados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPinos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHGH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHGS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmHandycap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPinosEnt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BL_DBDataSet bL_DBDataSet;
        private System.Windows.Forms.BindingSource jugadoresBindingSource;
        private BL_DBDataSetTableAdapters.JugadoresTableAdapter jugadoresTableAdapter;
        private BL_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbPuesto;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.TextBox no_jugadorTextBox;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox estadoNacimientoTextBox;
        private System.Windows.Forms.TextBox apellidoPaternoTextBox;
        private System.Windows.Forms.TextBox ciudadNacimientoTextBox;
        private System.Windows.Forms.TextBox apellidoMaternoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox txtConfirmpass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nmPromedio;
        private System.Windows.Forms.NumericUpDown nmJuegosJugados;
        private System.Windows.Forms.NumericUpDown nmPinos;
        private System.Windows.Forms.NumericUpDown nmHGH;
        private System.Windows.Forms.NumericUpDown nmHSS;
        private System.Windows.Forms.NumericUpDown nmHGS;
        private System.Windows.Forms.NumericUpDown nmHandycap;
        private System.Windows.Forms.NumericUpDown nmPinosEnt;
    }
}