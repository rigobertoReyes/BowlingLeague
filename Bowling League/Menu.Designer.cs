namespace Bowling_League
{
    partial class Menu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminarLiga = new System.Windows.Forms.Button();
            this.ligasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ligasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bL_LigasDS = new Bowling_League.BL_LigasDS();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDiajuego = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNombrebol = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblIndividual = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblFechafinal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblFechainicio = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSecretarioG = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTesorero = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPresidente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombreLiga = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.ligasTableAdapter = new Bowling_League.BL_LigasDSTableAdapters.LigasTableAdapter();
            this.tableAdapterManager = new Bowling_League.BL_LigasDSTableAdapters.TableAdapterManager();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ligasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bL_LigasDS)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(154, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Nueva Liga";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(279, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "Jugadores";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(496, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 38);
            this.button3.TabIndex = 4;
            this.button3.Text = "Roles";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnEliminarLiga);
            this.groupBox1.Controls.Add(this.ligasDataGridView);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 334);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnEliminarLiga
            // 
            this.btnEliminarLiga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarLiga.BackColor = System.Drawing.Color.Red;
            this.btnEliminarLiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarLiga.ForeColor = System.Drawing.Color.White;
            this.btnEliminarLiga.Location = new System.Drawing.Point(679, 292);
            this.btnEliminarLiga.Name = "btnEliminarLiga";
            this.btnEliminarLiga.Size = new System.Drawing.Size(107, 36);
            this.btnEliminarLiga.TabIndex = 2;
            this.btnEliminarLiga.Text = "Eliminar Liga";
            this.btnEliminarLiga.UseVisualStyleBackColor = false;
            this.btnEliminarLiga.Click += new System.EventHandler(this.btnEliminarLiga_Click);
            // 
            // ligasDataGridView
            // 
            this.ligasDataGridView.AllowUserToAddRows = false;
            this.ligasDataGridView.AllowUserToDeleteRows = false;
            this.ligasDataGridView.AllowUserToResizeColumns = false;
            this.ligasDataGridView.AllowUserToResizeRows = false;
            this.ligasDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ligasDataGridView.AutoGenerateColumns = false;
            this.ligasDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.ligasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ligasDataGridView.ColumnHeadersVisible = false;
            this.ligasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1});
            this.ligasDataGridView.DataSource = this.ligasBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrchid;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ligasDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.ligasDataGridView.Location = new System.Drawing.Point(13, 37);
            this.ligasDataGridView.MultiSelect = false;
            this.ligasDataGridView.Name = "ligasDataGridView";
            this.ligasDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ligasDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ligasDataGridView.RowHeadersVisible = false;
            this.ligasDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ligasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ligasDataGridView.Size = new System.Drawing.Size(196, 249);
            this.ligasDataGridView.TabIndex = 1;
            this.ligasDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ligasDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre_de_liga";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre_de_liga";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Liga";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Liga";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblDiajuego);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblNombrebol);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblCantidad);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.lblIndividual);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.lblHora);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lblFechafinal);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lblFechainicio);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lblCiudad);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblSecretarioG);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblTesorero);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblPresidente);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblNombreLiga);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(224, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 249);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liga Seleccionada";
            // 
            // lblDiajuego
            // 
            this.lblDiajuego.AutoSize = true;
            this.lblDiajuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiajuego.Location = new System.Drawing.Point(435, 67);
            this.lblDiajuego.Name = "lblDiajuego";
            this.lblDiajuego.Size = new System.Drawing.Size(11, 13);
            this.lblDiajuego.TabIndex = 23;
            this.lblDiajuego.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(303, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Dias de Juego";
            // 
            // lblNombrebol
            // 
            this.lblNombrebol.AutoSize = true;
            this.lblNombrebol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrebol.Location = new System.Drawing.Point(141, 211);
            this.lblNombrebol.Name = "lblNombrebol";
            this.lblNombrebol.Size = new System.Drawing.Size(11, 13);
            this.lblNombrebol.TabIndex = 21;
            this.lblNombrebol.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Nombre del Boliche";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(435, 198);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(11, 13);
            this.lblCantidad.TabIndex = 19;
            this.lblCantidad.Text = "-";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(303, 198);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(127, 13);
            this.label19.TabIndex = 18;
            this.label19.Text = "Cantidad de equipos:";
            // 
            // lblIndividual
            // 
            this.lblIndividual.AutoSize = true;
            this.lblIndividual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndividual.Location = new System.Drawing.Point(435, 163);
            this.lblIndividual.Name = "lblIndividual";
            this.lblIndividual.Size = new System.Drawing.Size(11, 13);
            this.lblIndividual.TabIndex = 17;
            this.lblIndividual.Text = "-";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(303, 163);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(111, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Individual/Equipo:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(435, 131);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(11, 13);
            this.lblHora.TabIndex = 15;
            this.lblHora.Text = "-";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(303, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Hora del juego:";
            // 
            // lblFechafinal
            // 
            this.lblFechafinal.AutoSize = true;
            this.lblFechafinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechafinal.Location = new System.Drawing.Point(435, 99);
            this.lblFechafinal.Name = "lblFechafinal";
            this.lblFechafinal.Size = new System.Drawing.Size(11, 13);
            this.lblFechafinal.TabIndex = 13;
            this.lblFechafinal.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(303, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Fecha final:";
            // 
            // lblFechainicio
            // 
            this.lblFechainicio.AutoSize = true;
            this.lblFechainicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechainicio.Location = new System.Drawing.Point(435, 35);
            this.lblFechainicio.Name = "lblFechainicio";
            this.lblFechainicio.Size = new System.Drawing.Size(11, 13);
            this.lblFechainicio.TabIndex = 11;
            this.lblFechainicio.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(303, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Fecha inicio:";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.Location = new System.Drawing.Point(141, 172);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(11, 13);
            this.lblCiudad.TabIndex = 9;
            this.lblCiudad.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ciudad de Juego";
            // 
            // lblSecretarioG
            // 
            this.lblSecretarioG.AutoSize = true;
            this.lblSecretarioG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecretarioG.Location = new System.Drawing.Point(141, 134);
            this.lblSecretarioG.Name = "lblSecretarioG";
            this.lblSecretarioG.Size = new System.Drawing.Size(11, 13);
            this.lblSecretarioG.TabIndex = 7;
            this.lblSecretarioG.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Secretario General:";
            // 
            // lblTesorero
            // 
            this.lblTesorero.AutoSize = true;
            this.lblTesorero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTesorero.Location = new System.Drawing.Point(141, 99);
            this.lblTesorero.Name = "lblTesorero";
            this.lblTesorero.Size = new System.Drawing.Size(11, 13);
            this.lblTesorero.TabIndex = 5;
            this.lblTesorero.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tesorero";
            // 
            // lblPresidente
            // 
            this.lblPresidente.AutoSize = true;
            this.lblPresidente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresidente.Location = new System.Drawing.Point(141, 67);
            this.lblPresidente.Name = "lblPresidente";
            this.lblPresidente.Size = new System.Drawing.Size(11, 13);
            this.lblPresidente.TabIndex = 3;
            this.lblPresidente.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Presidente:";
            // 
            // lblNombreLiga
            // 
            this.lblNombreLiga.AutoSize = true;
            this.lblNombreLiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreLiga.Location = new System.Drawing.Point(141, 35);
            this.lblNombreLiga.Name = "lblNombreLiga";
            this.lblNombreLiga.Size = new System.Drawing.Size(11, 13);
            this.lblNombreLiga.TabIndex = 1;
            this.lblNombreLiga.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la liga:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(316, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Resumen de Ligas";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RoyalBlue;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button5.Location = new System.Drawing.Point(386, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 38);
            this.button5.TabIndex = 9;
            this.button5.Text = "Equipos";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.RoyalBlue;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button6.Location = new System.Drawing.Point(606, 16);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(143, 38);
            this.button6.TabIndex = 10;
            this.button6.Text = "Juego Semanal";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
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
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::Bowling_League.Properties.Resources.Logout1;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(767, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 47);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.RoyalBlue;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button7.Location = new System.Drawing.Point(25, 16);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(110, 43);
            this.button7.TabIndex = 11;
            this.button7.Text = "Tabla de posiciones";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(829, 450);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ligasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bL_LigasDS)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblIndividual;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblFechafinal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblFechainicio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSecretarioG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTesorero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPresidente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombreLiga;
        private System.Windows.Forms.Label label1;
        private BL_LigasDS bL_LigasDS;
        private System.Windows.Forms.BindingSource ligasBindingSource;
        private BL_LigasDSTableAdapters.LigasTableAdapter ligasTableAdapter;
        private BL_LigasDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView ligasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombrebol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminarLiga;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblDiajuego;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}