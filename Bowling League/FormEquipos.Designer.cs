﻿namespace Bowling_League
{
    partial class Equipos
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
            System.Windows.Forms.Label no_EquipoLabel;
            System.Windows.Forms.Label nombre_de_equipoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.equiposDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bL_DBEquiposDS = new Bowling_League.BL_DBEquiposDS();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nombre_de_equipoTextBox = new System.Windows.Forms.TextBox();
            this.no_EquipoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnagregars2 = new System.Windows.Forms.Button();
            this.numeros2 = new System.Windows.Forms.Label();
            this.nombres2 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnagregars1 = new System.Windows.Forms.Button();
            this.numeros1 = new System.Windows.Forms.Label();
            this.nombres1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnagregari5 = new System.Windows.Forms.Button();
            this.numeroi5 = new System.Windows.Forms.Label();
            this.nombrei5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnagregari4 = new System.Windows.Forms.Button();
            this.numeroi4 = new System.Windows.Forms.Label();
            this.nombrei4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnagregari3 = new System.Windows.Forms.Button();
            this.numeroi3 = new System.Windows.Forms.Label();
            this.nombrei3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnagregari2 = new System.Windows.Forms.Button();
            this.numeroi2 = new System.Windows.Forms.Label();
            this.nombrei2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnagregari1 = new System.Windows.Forms.Button();
            this.numeroi1 = new System.Windows.Forms.Label();
            this.nombrei1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.equiposTableAdapter = new Bowling_League.BL_DBEquiposDSTableAdapters.EquiposTableAdapter();
            this.tableAdapterManager = new Bowling_League.BL_DBEquiposDSTableAdapters.TableAdapterManager();
            this.jugadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jugadoresTableAdapter = new Bowling_League.BL_DBEquiposDSTableAdapters.JugadoresTableAdapter();
            no_EquipoLabel = new System.Windows.Forms.Label();
            nombre_de_equipoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.equiposDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bL_DBEquiposDS)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // no_EquipoLabel
            // 
            no_EquipoLabel.AutoSize = true;
            no_EquipoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            no_EquipoLabel.Location = new System.Drawing.Point(3, 44);
            no_EquipoLabel.Name = "no_EquipoLabel";
            no_EquipoLabel.Size = new System.Drawing.Size(78, 15);
            no_EquipoLabel.TabIndex = 15;
            no_EquipoLabel.Text = "No Equipo:";
            // 
            // nombre_de_equipoLabel
            // 
            nombre_de_equipoLabel.AutoSize = true;
            nombre_de_equipoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombre_de_equipoLabel.Location = new System.Drawing.Point(286, 44);
            nombre_de_equipoLabel.Name = "nombre_de_equipoLabel";
            nombre_de_equipoLabel.Size = new System.Drawing.Size(130, 15);
            nombre_de_equipoLabel.TabIndex = 16;
            nombre_de_equipoLabel.Text = "Nombre de equipo:";
            // 
            // equiposDataGridView
            // 
            this.equiposDataGridView.AllowUserToAddRows = false;
            this.equiposDataGridView.AllowUserToDeleteRows = false;
            this.equiposDataGridView.AllowUserToResizeColumns = false;
            this.equiposDataGridView.AllowUserToResizeRows = false;
            this.equiposDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.equiposDataGridView.AutoGenerateColumns = false;
            this.equiposDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.equiposDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equiposDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.equiposDataGridView.DataSource = this.equiposBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrchid;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.equiposDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.equiposDataGridView.Location = new System.Drawing.Point(12, 82);
            this.equiposDataGridView.MultiSelect = false;
            this.equiposDataGridView.Name = "equiposDataGridView";
            this.equiposDataGridView.ReadOnly = true;
            this.equiposDataGridView.RowHeadersVisible = false;
            this.equiposDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.equiposDataGridView.Size = new System.Drawing.Size(204, 486);
            this.equiposDataGridView.TabIndex = 1;
            this.equiposDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.equiposDataGridView_CellClick);
            this.equiposDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.equiposDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "No_Equipo";
            this.dataGridViewTextBoxColumn2.HeaderText = "No_Equipo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombre_de_equipo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre_de_equipo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // equiposBindingSource
            // 
            this.equiposBindingSource.DataMember = "Equipos";
            this.equiposBindingSource.DataSource = this.bL_DBEquiposDS;
            // 
            // bL_DBEquiposDS
            // 
            this.bL_DBEquiposDS.DataSetName = "BL_DBEquiposDS";
            this.bL_DBEquiposDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(nombre_de_equipoLabel);
            this.groupBox1.Controls.Add(this.nombre_de_equipoTextBox);
            this.groupBox1.Controls.Add(no_EquipoLabel);
            this.groupBox1.Controls.Add(this.no_EquipoTextBox);
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(232, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 486);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // nombre_de_equipoTextBox
            // 
            this.nombre_de_equipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equiposBindingSource, "Nombre_de_equipo", true));
            this.nombre_de_equipoTextBox.Location = new System.Drawing.Point(422, 43);
            this.nombre_de_equipoTextBox.Name = "nombre_de_equipoTextBox";
            this.nombre_de_equipoTextBox.Size = new System.Drawing.Size(159, 20);
            this.nombre_de_equipoTextBox.TabIndex = 17;
            // 
            // no_EquipoTextBox
            // 
            this.no_EquipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equiposBindingSource, "No_Equipo", true));
            this.no_EquipoTextBox.Location = new System.Drawing.Point(102, 43);
            this.no_EquipoTextBox.Name = "no_EquipoTextBox";
            this.no_EquipoTextBox.Size = new System.Drawing.Size(165, 20);
            this.no_EquipoTextBox.TabIndex = 16;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnagregars2);
            this.groupBox8.Controls.Add(this.numeros2);
            this.groupBox8.Controls.Add(this.nombres2);
            this.groupBox8.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox8.Location = new System.Drawing.Point(319, 381);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(307, 77);
            this.groupBox8.TabIndex = 15;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Suplente 2";
            // 
            // btnagregars2
            // 
            this.btnagregars2.BackgroundImage = global::Bowling_League.Properties.Resources.adduser;
            this.btnagregars2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregars2.Location = new System.Drawing.Point(263, 39);
            this.btnagregars2.Name = "btnagregars2";
            this.btnagregars2.Size = new System.Drawing.Size(38, 32);
            this.btnagregars2.TabIndex = 54;
            this.btnagregars2.UseVisualStyleBackColor = true;
            this.btnagregars2.Click += new System.EventHandler(this.btnagregars2_Click);
            // 
            // numeros2
            // 
            this.numeros2.AutoSize = true;
            this.numeros2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeros2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.numeros2.Location = new System.Drawing.Point(6, 47);
            this.numeros2.Name = "numeros2";
            this.numeros2.Size = new System.Drawing.Size(82, 15);
            this.numeros2.TabIndex = 12;
            this.numeros2.Text = "No jugador:";
            // 
            // nombres2
            // 
            this.nombres2.AutoSize = true;
            this.nombres2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombres2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nombres2.Location = new System.Drawing.Point(6, 16);
            this.nombres2.Name = "nombres2";
            this.nombres2.Size = new System.Drawing.Size(62, 15);
            this.nombres2.TabIndex = 11;
            this.nombres2.Text = "Nombre:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnagregars1);
            this.groupBox7.Controls.Add(this.numeros1);
            this.groupBox7.Controls.Add(this.nombres1);
            this.groupBox7.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox7.Location = new System.Drawing.Point(6, 381);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(307, 77);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Suplente 1";
            // 
            // btnagregars1
            // 
            this.btnagregars1.BackgroundImage = global::Bowling_League.Properties.Resources.adduser;
            this.btnagregars1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregars1.Location = new System.Drawing.Point(263, 39);
            this.btnagregars1.Name = "btnagregars1";
            this.btnagregars1.Size = new System.Drawing.Size(38, 32);
            this.btnagregars1.TabIndex = 54;
            this.btnagregars1.UseVisualStyleBackColor = true;
            this.btnagregars1.Click += new System.EventHandler(this.btnagregars1_Click);
            // 
            // numeros1
            // 
            this.numeros1.AutoSize = true;
            this.numeros1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeros1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.numeros1.Location = new System.Drawing.Point(6, 47);
            this.numeros1.Name = "numeros1";
            this.numeros1.Size = new System.Drawing.Size(82, 15);
            this.numeros1.TabIndex = 12;
            this.numeros1.Text = "No jugador:";
            // 
            // nombres1
            // 
            this.nombres1.AutoSize = true;
            this.nombres1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombres1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nombres1.Location = new System.Drawing.Point(6, 16);
            this.nombres1.Name = "nombres1";
            this.nombres1.Size = new System.Drawing.Size(62, 15);
            this.nombres1.TabIndex = 11;
            this.nombres1.Text = "Nombre:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnagregari5);
            this.groupBox6.Controls.Add(this.numeroi5);
            this.groupBox6.Controls.Add(this.nombrei5);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox6.Location = new System.Drawing.Point(6, 277);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(307, 77);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Integrante 5";
            // 
            // btnagregari5
            // 
            this.btnagregari5.BackgroundImage = global::Bowling_League.Properties.Resources.adduser;
            this.btnagregari5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregari5.Location = new System.Drawing.Point(263, 39);
            this.btnagregari5.Name = "btnagregari5";
            this.btnagregari5.Size = new System.Drawing.Size(38, 32);
            this.btnagregari5.TabIndex = 54;
            this.btnagregari5.UseVisualStyleBackColor = true;
            this.btnagregari5.Click += new System.EventHandler(this.btnagregari5_Click);
            // 
            // numeroi5
            // 
            this.numeroi5.AutoSize = true;
            this.numeroi5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroi5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.numeroi5.Location = new System.Drawing.Point(6, 47);
            this.numeroi5.Name = "numeroi5";
            this.numeroi5.Size = new System.Drawing.Size(82, 15);
            this.numeroi5.TabIndex = 12;
            this.numeroi5.Text = "No jugador:";
            // 
            // nombrei5
            // 
            this.nombrei5.AutoSize = true;
            this.nombrei5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrei5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nombrei5.Location = new System.Drawing.Point(6, 16);
            this.nombrei5.Name = "nombrei5";
            this.nombrei5.Size = new System.Drawing.Size(62, 15);
            this.nombrei5.TabIndex = 11;
            this.nombrei5.Text = "Nombre:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnagregari4);
            this.groupBox5.Controls.Add(this.numeroi4);
            this.groupBox5.Controls.Add(this.nombrei4);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Location = new System.Drawing.Point(319, 184);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(307, 77);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Integrante 4";
            // 
            // btnagregari4
            // 
            this.btnagregari4.BackgroundImage = global::Bowling_League.Properties.Resources.adduser;
            this.btnagregari4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregari4.Location = new System.Drawing.Point(263, 39);
            this.btnagregari4.Name = "btnagregari4";
            this.btnagregari4.Size = new System.Drawing.Size(38, 32);
            this.btnagregari4.TabIndex = 54;
            this.btnagregari4.UseVisualStyleBackColor = true;
            this.btnagregari4.Click += new System.EventHandler(this.btnagregari4_Click);
            // 
            // numeroi4
            // 
            this.numeroi4.AutoSize = true;
            this.numeroi4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroi4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.numeroi4.Location = new System.Drawing.Point(6, 47);
            this.numeroi4.Name = "numeroi4";
            this.numeroi4.Size = new System.Drawing.Size(82, 15);
            this.numeroi4.TabIndex = 12;
            this.numeroi4.Text = "No jugador:";
            // 
            // nombrei4
            // 
            this.nombrei4.AutoSize = true;
            this.nombrei4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrei4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nombrei4.Location = new System.Drawing.Point(6, 16);
            this.nombrei4.Name = "nombrei4";
            this.nombrei4.Size = new System.Drawing.Size(62, 15);
            this.nombrei4.TabIndex = 11;
            this.nombrei4.Text = "Nombre:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnagregari3);
            this.groupBox4.Controls.Add(this.numeroi3);
            this.groupBox4.Controls.Add(this.nombrei3);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Location = new System.Drawing.Point(6, 184);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(307, 77);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Integrante 3";
            // 
            // btnagregari3
            // 
            this.btnagregari3.BackgroundImage = global::Bowling_League.Properties.Resources.adduser;
            this.btnagregari3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregari3.Location = new System.Drawing.Point(263, 39);
            this.btnagregari3.Name = "btnagregari3";
            this.btnagregari3.Size = new System.Drawing.Size(38, 32);
            this.btnagregari3.TabIndex = 54;
            this.btnagregari3.UseVisualStyleBackColor = true;
            this.btnagregari3.Click += new System.EventHandler(this.btnagregari3_Click);
            // 
            // numeroi3
            // 
            this.numeroi3.AutoSize = true;
            this.numeroi3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroi3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.numeroi3.Location = new System.Drawing.Point(6, 47);
            this.numeroi3.Name = "numeroi3";
            this.numeroi3.Size = new System.Drawing.Size(82, 15);
            this.numeroi3.TabIndex = 12;
            this.numeroi3.Text = "No jugador:";
            // 
            // nombrei3
            // 
            this.nombrei3.AutoSize = true;
            this.nombrei3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrei3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nombrei3.Location = new System.Drawing.Point(6, 16);
            this.nombrei3.Name = "nombrei3";
            this.nombrei3.Size = new System.Drawing.Size(62, 15);
            this.nombrei3.TabIndex = 11;
            this.nombrei3.Text = "Nombre:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnagregari2);
            this.groupBox3.Controls.Add(this.numeroi2);
            this.groupBox3.Controls.Add(this.nombrei2);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(319, 91);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 77);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Integrante 2";
            // 
            // btnagregari2
            // 
            this.btnagregari2.BackgroundImage = global::Bowling_League.Properties.Resources.adduser;
            this.btnagregari2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregari2.Location = new System.Drawing.Point(263, 39);
            this.btnagregari2.Name = "btnagregari2";
            this.btnagregari2.Size = new System.Drawing.Size(38, 32);
            this.btnagregari2.TabIndex = 54;
            this.btnagregari2.UseVisualStyleBackColor = true;
            this.btnagregari2.Click += new System.EventHandler(this.btnagregari2_Click);
            // 
            // numeroi2
            // 
            this.numeroi2.AutoSize = true;
            this.numeroi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroi2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.numeroi2.Location = new System.Drawing.Point(6, 47);
            this.numeroi2.Name = "numeroi2";
            this.numeroi2.Size = new System.Drawing.Size(82, 15);
            this.numeroi2.TabIndex = 12;
            this.numeroi2.Text = "No jugador:";
            // 
            // nombrei2
            // 
            this.nombrei2.AutoSize = true;
            this.nombrei2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrei2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nombrei2.Location = new System.Drawing.Point(6, 16);
            this.nombrei2.Name = "nombrei2";
            this.nombrei2.Size = new System.Drawing.Size(62, 15);
            this.nombrei2.TabIndex = 11;
            this.nombrei2.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnagregari1);
            this.groupBox2.Controls.Add(this.numeroi1);
            this.groupBox2.Controls.Add(this.nombrei1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(6, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 77);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Integrante 1";
            // 
            // btnagregari1
            // 
            this.btnagregari1.BackgroundImage = global::Bowling_League.Properties.Resources.adduser;
            this.btnagregari1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregari1.Location = new System.Drawing.Point(263, 39);
            this.btnagregari1.Name = "btnagregari1";
            this.btnagregari1.Size = new System.Drawing.Size(38, 32);
            this.btnagregari1.TabIndex = 53;
            this.btnagregari1.UseVisualStyleBackColor = true;
            this.btnagregari1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numeroi1
            // 
            this.numeroi1.AutoSize = true;
            this.numeroi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroi1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.numeroi1.Location = new System.Drawing.Point(6, 47);
            this.numeroi1.Name = "numeroi1";
            this.numeroi1.Size = new System.Drawing.Size(82, 15);
            this.numeroi1.TabIndex = 12;
            this.numeroi1.Text = "No jugador:";
            // 
            // nombrei1
            // 
            this.nombrei1.AutoSize = true;
            this.nombrei1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrei1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nombrei1.Location = new System.Drawing.Point(6, 16);
            this.nombrei1.Name = "nombrei1";
            this.nombrei1.Size = new System.Drawing.Size(62, 15);
            this.nombrei1.TabIndex = 11;
            this.nombrei1.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(430, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 29);
            this.label6.TabIndex = 51;
            this.label6.Text = "Equipos";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(722, 579);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 38);
            this.button3.TabIndex = 52;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(60, 579);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 38);
            this.button1.TabIndex = 53;
            this.button1.Text = "Nuevo Equipo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Bowling_League.Properties.Resources.Back;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 44);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // equiposTableAdapter
            // 
            this.equiposTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EquiposTableAdapter = this.equiposTableAdapter;
            this.tableAdapterManager.JugadoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Bowling_League.BL_DBEquiposDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // jugadoresBindingSource
            // 
            this.jugadoresBindingSource.DataMember = "Jugadores";
            this.jugadoresBindingSource.DataSource = this.bL_DBEquiposDS;
            // 
            // jugadoresTableAdapter
            // 
            this.jugadoresTableAdapter.ClearBeforeFill = true;
            // 
            // Equipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(892, 629);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.equiposDataGridView);
            this.Name = "Equipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipos";
            this.Load += new System.EventHandler(this.FormEquipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equiposDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bL_DBEquiposDS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BL_DBEquiposDS bL_DBEquiposDS;
        private System.Windows.Forms.BindingSource equiposBindingSource;
        private BL_DBEquiposDSTableAdapters.EquiposTableAdapter equiposTableAdapter;
        private BL_DBEquiposDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView equiposDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label numeros2;
        private System.Windows.Forms.Label nombres2;
        private System.Windows.Forms.Label numeros1;
        private System.Windows.Forms.Label nombres1;
        private System.Windows.Forms.Label numeroi5;
        private System.Windows.Forms.Label nombrei5;
        private System.Windows.Forms.Label numeroi4;
        private System.Windows.Forms.Label nombrei4;
        private System.Windows.Forms.Label numeroi3;
        private System.Windows.Forms.Label nombrei3;
        private System.Windows.Forms.Label numeroi2;
        private System.Windows.Forms.Label nombrei2;
        private System.Windows.Forms.Label numeroi1;
        private System.Windows.Forms.Label nombrei1;
        private System.Windows.Forms.BindingSource jugadoresBindingSource;
        private BL_DBEquiposDSTableAdapters.JugadoresTableAdapter jugadoresTableAdapter;
        private System.Windows.Forms.Button btnagregari1;
        private System.Windows.Forms.Button btnagregars2;
        private System.Windows.Forms.Button btnagregars1;
        private System.Windows.Forms.Button btnagregari5;
        private System.Windows.Forms.Button btnagregari4;
        private System.Windows.Forms.Button btnagregari3;
        private System.Windows.Forms.Button btnagregari2;
        private System.Windows.Forms.TextBox nombre_de_equipoTextBox;
        private System.Windows.Forms.TextBox no_EquipoTextBox;
        private System.Windows.Forms.Button button1;
    }
}