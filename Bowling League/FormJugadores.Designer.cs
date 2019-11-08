namespace Bowling_League
{
    partial class FormJugadores
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoPaternoLabel;
            System.Windows.Forms.Label apellidoMaternoLabel;
            System.Windows.Forms.Label ciudadNacimientoLabel;
            System.Windows.Forms.Label estadoNacimientoLabel;
            System.Windows.Forms.Label fechaNacimientoLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label puestoDelJugadorLabel;
            System.Windows.Forms.Label pinosEntLabel;
            System.Windows.Forms.Label handycapLabel;
            System.Windows.Forms.Label highGameScratchLabel;
            System.Windows.Forms.Label highSeriesScratchLabel;
            System.Windows.Forms.Label highGameHandycapLabel;
            System.Windows.Forms.Label pinosLabel;
            System.Windows.Forms.Label juegosJugadosLabel;
            System.Windows.Forms.Label promedioLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.bL_DBDataSet = new Bowling_League.BL_DBDataSet();
            this.jugadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jugadoresTableAdapter = new Bowling_League.BL_DBDataSetTableAdapters.JugadoresTableAdapter();
            this.tableAdapterManager = new Bowling_League.BL_DBDataSetTableAdapters.TableAdapterManager();
            this.jugadoresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.no_jugadorTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoPaternoTextBox = new System.Windows.Forms.TextBox();
            this.apellidoMaternoTextBox = new System.Windows.Forms.TextBox();
            this.ciudadNacimientoTextBox = new System.Windows.Forms.TextBox();
            this.estadoNacimientoTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.txtConfirmpass = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbPuesto = new System.Windows.Forms.ComboBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
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
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Validacion = new DevComponents.DotNetBar.Validator.Highlighter();
            no_jugadorLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoPaternoLabel = new System.Windows.Forms.Label();
            apellidoMaternoLabel = new System.Windows.Forms.Label();
            ciudadNacimientoLabel = new System.Windows.Forms.Label();
            estadoNacimientoLabel = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            puestoDelJugadorLabel = new System.Windows.Forms.Label();
            pinosEntLabel = new System.Windows.Forms.Label();
            handycapLabel = new System.Windows.Forms.Label();
            highGameScratchLabel = new System.Windows.Forms.Label();
            highSeriesScratchLabel = new System.Windows.Forms.Label();
            highGameHandycapLabel = new System.Windows.Forms.Label();
            pinosLabel = new System.Windows.Forms.Label();
            juegosJugadosLabel = new System.Windows.Forms.Label();
            promedioLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bL_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadoresDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            passwordLabel.Location = new System.Drawing.Point(6, 16);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(122, 30);
            passwordLabel.TabIndex = 42;
            passwordLabel.Text = "Nueva contraseña\r\n(Opcional)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            label2.Location = new System.Drawing.Point(6, 54);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(111, 30);
            label2.TabIndex = 44;
            label2.Text = "Confirma nueva \r\ncontraseña";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(283, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nuevo Jugador";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // jugadoresDataGridView
            // 
            this.jugadoresDataGridView.AllowUserToAddRows = false;
            this.jugadoresDataGridView.AllowUserToDeleteRows = false;
            this.jugadoresDataGridView.AllowUserToResizeColumns = false;
            this.jugadoresDataGridView.AllowUserToResizeRows = false;
            this.jugadoresDataGridView.AutoGenerateColumns = false;
            this.jugadoresDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.jugadoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jugadoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.jugadoresDataGridView.DataSource = this.jugadoresBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrchid;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.jugadoresDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.jugadoresDataGridView.Location = new System.Drawing.Point(6, 28);
            this.jugadoresDataGridView.MultiSelect = false;
            this.jugadoresDataGridView.Name = "jugadoresDataGridView";
            this.jugadoresDataGridView.ReadOnly = true;
            this.jugadoresDataGridView.RowHeadersVisible = false;
            this.jugadoresDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.jugadoresDataGridView.Size = new System.Drawing.Size(405, 220);
            this.jugadoresDataGridView.TabIndex = 2;
            this.jugadoresDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jugadoresDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "No_jugador";
            this.dataGridViewTextBoxColumn2.HeaderText = "No jugador";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ApellidoPaterno";
            this.dataGridViewTextBoxColumn4.HeaderText = "Apellido Paterno";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ApellidoMaterno";
            this.dataGridViewTextBoxColumn5.HeaderText = "Apellido Materno";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CiudadNacimiento";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ciudad de Nacimiento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "EstadoNacimiento";
            this.dataGridViewTextBoxColumn7.HeaderText = "Estado de Nacimiento";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "FechaNacimiento";
            this.dataGridViewTextBoxColumn8.HeaderText = "Fecha Nacimiento";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Sexo";
            this.dataGridViewTextBoxColumn9.HeaderText = "Sexo";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PuestoDelJugador";
            this.dataGridViewTextBoxColumn10.HeaderText = "Puesto Del Jugador";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "PinosEnt";
            this.dataGridViewTextBoxColumn11.HeaderText = "PinosEnt";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Handycap";
            this.dataGridViewTextBoxColumn12.HeaderText = "Handycap";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "HighGameScratch";
            this.dataGridViewTextBoxColumn13.HeaderText = "High Game Scratch";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "HighSeriesScratch";
            this.dataGridViewTextBoxColumn14.HeaderText = "High Series Scratch";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "HighGameHandycap";
            this.dataGridViewTextBoxColumn15.HeaderText = "High Game Handycap";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Pinos";
            this.dataGridViewTextBoxColumn16.HeaderText = "Pinos";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "JuegosJugados";
            this.dataGridViewTextBoxColumn17.HeaderText = "Juegos Jugados";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Promedio";
            this.dataGridViewTextBoxColumn18.HeaderText = "Promedio";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.jugadoresDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 278);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(152, 81);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(287, 20);
            this.txtBuscar.TabIndex = 5;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(19, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar Jugador";
            // 
            // no_jugadorTextBox
            // 
            this.no_jugadorTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.no_jugadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadoresBindingSource, "No_jugador", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.no_jugadorTextBox.Location = new System.Drawing.Point(144, 13);
            this.no_jugadorTextBox.Name = "no_jugadorTextBox";
            this.no_jugadorTextBox.Size = new System.Drawing.Size(183, 20);
            this.no_jugadorTextBox.TabIndex = 0;
            this.no_jugadorTextBox.TextChanged += new System.EventHandler(this.no_jugadorTextBox_TextChanged);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadoresBindingSource, "Nombre", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.nombreTextBox.Location = new System.Drawing.Point(144, 39);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(183, 20);
            this.nombreTextBox.TabIndex = 1;
            // 
            // apellidoPaternoTextBox
            // 
            this.apellidoPaternoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadoresBindingSource, "ApellidoPaterno", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.apellidoPaternoTextBox.Location = new System.Drawing.Point(144, 65);
            this.apellidoPaternoTextBox.Name = "apellidoPaternoTextBox";
            this.apellidoPaternoTextBox.Size = new System.Drawing.Size(183, 20);
            this.apellidoPaternoTextBox.TabIndex = 2;
            // 
            // apellidoMaternoTextBox
            // 
            this.apellidoMaternoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadoresBindingSource, "ApellidoMaterno", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.apellidoMaternoTextBox.Location = new System.Drawing.Point(144, 91);
            this.apellidoMaternoTextBox.Name = "apellidoMaternoTextBox";
            this.apellidoMaternoTextBox.Size = new System.Drawing.Size(183, 20);
            this.apellidoMaternoTextBox.TabIndex = 3;
            // 
            // ciudadNacimientoTextBox
            // 
            this.ciudadNacimientoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadoresBindingSource, "CiudadNacimiento", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.ciudadNacimientoTextBox.Location = new System.Drawing.Point(144, 117);
            this.ciudadNacimientoTextBox.Name = "ciudadNacimientoTextBox";
            this.ciudadNacimientoTextBox.Size = new System.Drawing.Size(183, 20);
            this.ciudadNacimientoTextBox.TabIndex = 4;
            // 
            // estadoNacimientoTextBox
            // 
            this.estadoNacimientoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadoresBindingSource, "EstadoNacimiento", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.estadoNacimientoTextBox.Location = new System.Drawing.Point(144, 143);
            this.estadoNacimientoTextBox.Name = "estadoNacimientoTextBox";
            this.estadoNacimientoTextBox.Size = new System.Drawing.Size(183, 20);
            this.estadoNacimientoTextBox.TabIndex = 5;
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.jugadoresBindingSource, "FechaNacimiento", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(144, 169);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(183, 20);
            this.fechaNacimientoDateTimePicker.TabIndex = 6;
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
            this.groupBox2.Location = new System.Drawing.Point(14, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 257);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            // 
            // cbPuesto
            // 
            this.cbPuesto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.jugadoresBindingSource, "PuestoDelJugador", true));
            this.cbPuesto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadoresBindingSource, "PuestoDelJugador", true, System.Windows.Forms.DataSourceUpdateMode.Never));
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
            this.cbSexo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jugadoresBindingSource, "Sexo", true, System.Windows.Forms.DataSourceUpdateMode.Never));
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
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(465, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 321);
            this.panel1.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(138, 603);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 51;
            this.label5.Text = "Contraseña";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(passwordLabel);
            this.groupBox4.Controls.Add(this.passwordTextBox);
            this.groupBox4.Controls.Add(this.txtConfirmpass);
            this.groupBox4.Controls.Add(label2);
            this.groupBox4.Location = new System.Drawing.Point(14, 624);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(342, 100);
            this.groupBox4.TabIndex = 49;
            this.groupBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(138, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 50;
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
            this.groupBox3.Location = new System.Drawing.Point(14, 344);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 233);
            this.groupBox3.TabIndex = 49;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(106, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 18);
            this.label3.TabIndex = 49;
            this.label3.Text = "Informacion Personal";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(706, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 38);
            this.button3.TabIndex = 49;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(392, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 29);
            this.label6.TabIndex = 50;
            this.label6.Text = "Jugadores";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(544, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 38);
            this.button2.TabIndex = 51;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Bowling_League.Properties.Resources.Back;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(18, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 44);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Validacion
            // 
            this.Validacion.ContainerControl = this.panel1;
            // 
            // FormJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(892, 463);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormJugadores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jugadores";
            this.Load += new System.EventHandler(this.FromNuevoJugador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bL_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadoresDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private BL_DBDataSet bL_DBDataSet;
        private System.Windows.Forms.BindingSource jugadoresBindingSource;
        private BL_DBDataSetTableAdapters.JugadoresTableAdapter jugadoresTableAdapter;
        private BL_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView jugadoresDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox no_jugadorTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoPaternoTextBox;
        private System.Windows.Forms.TextBox apellidoMaternoTextBox;
        private System.Windows.Forms.TextBox ciudadNacimientoTextBox;
        private System.Windows.Forms.TextBox estadoNacimientoTextBox;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox txtConfirmpass;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.ComboBox cbPuesto;
        private System.Windows.Forms.NumericUpDown nmPinosEnt;
        private System.Windows.Forms.NumericUpDown nmPromedio;
        private System.Windows.Forms.NumericUpDown nmJuegosJugados;
        private System.Windows.Forms.NumericUpDown nmPinos;
        private System.Windows.Forms.NumericUpDown nmHGH;
        private System.Windows.Forms.NumericUpDown nmHSS;
        private System.Windows.Forms.NumericUpDown nmHGS;
        private System.Windows.Forms.NumericUpDown nmHandycap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DevComponents.DotNetBar.Validator.Highlighter Validacion;
    }
}