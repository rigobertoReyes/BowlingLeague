namespace Bowling_League
{
    partial class FormRoles
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
            this.lblliga = new System.Windows.Forms.Label();
            this.bL_LigasDS = new Bowling_League.BL_LigasDS();
            this.ligasTableAdapter = new Bowling_League.BL_LigasDSTableAdapters.LigasTableAdapter();
            this.tableAdapterManager = new Bowling_League.BL_LigasDSTableAdapters.TableAdapterManager();
            this.ligasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbSemana = new System.Windows.Forms.ComboBox();
            this.cbJuegos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEquipo1 = new System.Windows.Forms.TextBox();
            this.txtEquipo2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bL_RolesDS = new Bowling_League.BL_RolesDS();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesTableAdapter = new Bowling_League.BL_RolesDSTableAdapters.RolesTableAdapter();
            this.tableAdapterManager1 = new Bowling_League.BL_RolesDSTableAdapters.TableAdapterManager();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblfecha = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bL_Juegosxsemana = new Bowling_League.BL_Juegosxsemana();
            this.juegosxSemanaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.juegosxSemanaTableAdapter = new Bowling_League.BL_JuegosxsemanaTableAdapters.JuegosxSemanaTableAdapter();
            this.tableAdapterManager2 = new Bowling_League.BL_JuegosxsemanaTableAdapters.TableAdapterManager();
            this.bL_DBEquiposDS = new Bowling_League.BL_DBEquiposDS();
            this.equiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equiposTableAdapter = new Bowling_League.BL_DBEquiposDSTableAdapters.EquiposTableAdapter();
            this.tableAdapterManager3 = new Bowling_League.BL_DBEquiposDSTableAdapters.TableAdapterManager();
            this.jugadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jugadoresTableAdapter = new Bowling_League.BL_DBEquiposDSTableAdapters.JugadoresTableAdapter();
            this.bL_LigasDetalles = new Bowling_League.BL_LigasDetalles();
            this.ligas_DetalleXEquiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ligas_DetalleXEquiposTableAdapter = new Bowling_League.BL_LigasDetallesTableAdapters.Ligas_DetalleXEquiposTableAdapter();
            this.tableAdapterManager4 = new Bowling_League.BL_LigasDetallesTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.bL_LigasDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bL_RolesDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bL_Juegosxsemana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.juegosxSemanaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bL_DBEquiposDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bL_LigasDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligas_DetalleXEquiposBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblliga
            // 
            this.lblliga.AutoSize = true;
            this.lblliga.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblliga.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblliga.Location = new System.Drawing.Point(77, 9);
            this.lblliga.Name = "lblliga";
            this.lblliga.Size = new System.Drawing.Size(175, 29);
            this.lblliga.TabIndex = 52;
            this.lblliga.Text = "Roles de liga ";
            // 
            // bL_LigasDS
            // 
            this.bL_LigasDS.DataSetName = "BL_LigasDS";
            this.bL_LigasDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // ligasBindingSource
            // 
            this.ligasBindingSource.DataMember = "Ligas";
            this.ligasBindingSource.DataSource = this.bL_LigasDS;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 54;
            this.label1.Text = "Semana";
            // 
            // cbSemana
            // 
            this.cbSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSemana.FormattingEnabled = true;
            this.cbSemana.Location = new System.Drawing.Point(117, 18);
            this.cbSemana.Name = "cbSemana";
            this.cbSemana.Size = new System.Drawing.Size(157, 21);
            this.cbSemana.TabIndex = 55;
            // 
            // cbJuegos
            // 
            this.cbJuegos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJuegos.FormattingEnabled = true;
            this.cbJuegos.Location = new System.Drawing.Point(116, 65);
            this.cbJuegos.Name = "cbJuegos";
            this.cbJuegos.Size = new System.Drawing.Size(158, 21);
            this.cbJuegos.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 56;
            this.label2.Text = "Juego";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 58;
            this.label3.Text = "Equipo 1";
            // 
            // txtEquipo1
            // 
            this.txtEquipo1.Enabled = false;
            this.txtEquipo1.Location = new System.Drawing.Point(117, 28);
            this.txtEquipo1.Name = "txtEquipo1";
            this.txtEquipo1.Size = new System.Drawing.Size(157, 20);
            this.txtEquipo1.TabIndex = 59;
            // 
            // txtEquipo2
            // 
            this.txtEquipo2.Enabled = false;
            this.txtEquipo2.Location = new System.Drawing.Point(117, 97);
            this.txtEquipo2.Name = "txtEquipo2";
            this.txtEquipo2.Size = new System.Drawing.Size(157, 20);
            this.txtEquipo2.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 60;
            this.label4.Text = "Equipo 2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(286, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 26);
            this.button1.TabIndex = 62;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Location = new System.Drawing.Point(313, 387);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 26);
            this.button4.TabIndex = 65;
            this.button4.Text = "Guardar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Bowling_League.Properties.Resources.addteam;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(286, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 37);
            this.button3.TabIndex = 64;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Bowling_League.Properties.Resources.addteam;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(286, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 37);
            this.button2.TabIndex = 63;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Bowling_League.Properties.Resources.Back;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 44);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(35, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 24);
            this.label5.TabIndex = 66;
            this.label5.Text = "Vs";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEquipo1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txtEquipo2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(16, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 131);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblfecha);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbSemana);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cbJuegos);
            this.groupBox2.Location = new System.Drawing.Point(16, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 100);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblfecha.Location = new System.Drawing.Point(283, 22);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(18, 16);
            this.lblfecha.TabIndex = 63;
            this.lblfecha.Text = "()";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(118, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 24);
            this.label6.TabIndex = 69;
            this.label6.Text = "Semana de roles";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(78, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(282, 24);
            this.label7.TabIndex = 70;
            this.label7.Text = "Enfrentamiento de la semana";
            // 
            // bL_Juegosxsemana
            // 
            this.bL_Juegosxsemana.DataSetName = "BL_Juegosxsemana";
            this.bL_Juegosxsemana.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // juegosxSemanaBindingSource
            // 
            this.juegosxSemanaBindingSource.DataMember = "JuegosxSemana";
            this.juegosxSemanaBindingSource.DataSource = this.bL_Juegosxsemana;
            // 
            // juegosxSemanaTableAdapter
            // 
            this.juegosxSemanaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.JuegosxSemanaTableAdapter = this.juegosxSemanaTableAdapter;
            this.tableAdapterManager2.UpdateOrder = Bowling_League.BL_JuegosxsemanaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bL_DBEquiposDS
            // 
            this.bL_DBEquiposDS.DataSetName = "BL_DBEquiposDS";
            this.bL_DBEquiposDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equiposBindingSource
            // 
            this.equiposBindingSource.DataMember = "Equipos";
            this.equiposBindingSource.DataSource = this.bL_DBEquiposDS;
            // 
            // equiposTableAdapter
            // 
            this.equiposTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager3
            // 
            this.tableAdapterManager3.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager3.EquiposTableAdapter = this.equiposTableAdapter;
            this.tableAdapterManager3.JugadoresTableAdapter = null;
            this.tableAdapterManager3.UpdateOrder = Bowling_League.BL_DBEquiposDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // bL_LigasDetalles
            // 
            this.bL_LigasDetalles.DataSetName = "BL_LigasDetalles";
            this.bL_LigasDetalles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ligas_DetalleXEquiposBindingSource
            // 
            this.ligas_DetalleXEquiposBindingSource.DataMember = "Ligas_DetalleXEquipos";
            this.ligas_DetalleXEquiposBindingSource.DataSource = this.bL_LigasDetalles;
            // 
            // ligas_DetalleXEquiposTableAdapter
            // 
            this.ligas_DetalleXEquiposTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager4
            // 
            this.tableAdapterManager4.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager4.Connection = null;
            this.tableAdapterManager4.UpdateOrder = Bowling_League.BL_LigasDetallesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(422, 434);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblliga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roles de Liga";
            this.Load += new System.EventHandler(this.FormRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bL_LigasDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bL_RolesDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bL_Juegosxsemana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.juegosxSemanaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bL_DBEquiposDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bL_LigasDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligas_DetalleXEquiposBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblliga;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BL_LigasDS bL_LigasDS;
        private System.Windows.Forms.BindingSource ligasBindingSource;
        private BL_LigasDSTableAdapters.LigasTableAdapter ligasTableAdapter;
        private BL_LigasDSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSemana;
        private System.Windows.Forms.ComboBox cbJuegos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEquipo1;
        private System.Windows.Forms.TextBox txtEquipo2;
        private System.Windows.Forms.Label label4;
        private BL_RolesDS bL_RolesDS;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private BL_RolesDSTableAdapters.RolesTableAdapter rolesTableAdapter;
        private BL_RolesDSTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblfecha;
        private BL_Juegosxsemana bL_Juegosxsemana;
        private System.Windows.Forms.BindingSource juegosxSemanaBindingSource;
        private BL_JuegosxsemanaTableAdapters.JuegosxSemanaTableAdapter juegosxSemanaTableAdapter;
        private BL_JuegosxsemanaTableAdapters.TableAdapterManager tableAdapterManager2;
        private BL_DBEquiposDS bL_DBEquiposDS;
        private System.Windows.Forms.BindingSource equiposBindingSource;
        private BL_DBEquiposDSTableAdapters.EquiposTableAdapter equiposTableAdapter;
        private BL_DBEquiposDSTableAdapters.TableAdapterManager tableAdapterManager3;
        private System.Windows.Forms.BindingSource jugadoresBindingSource;
        private BL_DBEquiposDSTableAdapters.JugadoresTableAdapter jugadoresTableAdapter;
        private BL_LigasDetalles bL_LigasDetalles;
        private System.Windows.Forms.BindingSource ligas_DetalleXEquiposBindingSource;
        private BL_LigasDetallesTableAdapters.Ligas_DetalleXEquiposTableAdapter ligas_DetalleXEquiposTableAdapter;
        private BL_LigasDetallesTableAdapters.TableAdapterManager tableAdapterManager4;
    }
}