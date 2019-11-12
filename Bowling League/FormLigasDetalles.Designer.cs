namespace Bowling_League
{
    partial class FormLigasDetalles
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
            this.lblliga = new System.Windows.Forms.Label();
            this.bL_LigasDetalles = new Bowling_League.BL_LigasDetalles();
            this.ligas_DetalleXEquiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ligas_DetalleXEquiposTableAdapter = new Bowling_League.BL_LigasDetallesTableAdapters.Ligas_DetalleXEquiposTableAdapter();
            this.tableAdapterManager = new Bowling_League.BL_LigasDetallesTableAdapters.TableAdapterManager();
            this.ligas_DetalleXEquiposDataGridView = new System.Windows.Forms.DataGridView();
            this.Posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblfecha = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cbSemana = new System.Windows.Forms.ComboBox();
            this.bL_LigasDS = new Bowling_League.BL_LigasDS();
            this.ligasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ligasTableAdapter = new Bowling_League.BL_LigasDSTableAdapters.LigasTableAdapter();
            this.tableAdapterManager1 = new Bowling_League.BL_LigasDSTableAdapters.TableAdapterManager();
            this.bL_RolesDS = new Bowling_League.BL_RolesDS();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesTableAdapter = new Bowling_League.BL_RolesDSTableAdapters.RolesTableAdapter();
            this.tableAdapterManager2 = new Bowling_League.BL_RolesDSTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bL_LigasDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligas_DetalleXEquiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligas_DetalleXEquiposDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bL_LigasDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bL_RolesDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblliga
            // 
            this.lblliga.AutoSize = true;
            this.lblliga.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblliga.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblliga.Location = new System.Drawing.Point(330, 9);
            this.lblliga.Name = "lblliga";
            this.lblliga.Size = new System.Drawing.Size(243, 29);
            this.lblliga.TabIndex = 53;
            this.lblliga.Text = "Detalles por equipo";
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Bowling_League.BL_LigasDetallesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ligas_DetalleXEquiposDataGridView
            // 
            this.ligas_DetalleXEquiposDataGridView.AllowUserToAddRows = false;
            this.ligas_DetalleXEquiposDataGridView.AllowUserToDeleteRows = false;
            this.ligas_DetalleXEquiposDataGridView.AllowUserToResizeRows = false;
            this.ligas_DetalleXEquiposDataGridView.AutoGenerateColumns = false;
            this.ligas_DetalleXEquiposDataGridView.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.ligas_DetalleXEquiposDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ligas_DetalleXEquiposDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Posicion,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.ligas_DetalleXEquiposDataGridView.DataSource = this.ligas_DetalleXEquiposBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrchid;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ligas_DetalleXEquiposDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.ligas_DetalleXEquiposDataGridView.Location = new System.Drawing.Point(12, 137);
            this.ligas_DetalleXEquiposDataGridView.MultiSelect = false;
            this.ligas_DetalleXEquiposDataGridView.Name = "ligas_DetalleXEquiposDataGridView";
            this.ligas_DetalleXEquiposDataGridView.ReadOnly = true;
            this.ligas_DetalleXEquiposDataGridView.RowHeadersVisible = false;
            this.ligas_DetalleXEquiposDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ligas_DetalleXEquiposDataGridView.Size = new System.Drawing.Size(875, 350);
            this.ligas_DetalleXEquiposDataGridView.TabIndex = 53;
            // 
            // Posicion
            // 
            this.Posicion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Posicion.HeaderText = "Posicion";
            this.Posicion.Name = "Posicion";
            this.Posicion.ReadOnly = true;
            this.Posicion.Width = 72;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Nombre_de_equipo";
            this.dataGridViewTextBoxColumn12.HeaderText = "Equipo";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Total_Juegos_Ganados";
            this.dataGridViewTextBoxColumn5.HeaderText = "Total Juegos Ganados";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Total_Juegos_Perdidos";
            this.dataGridViewTextBoxColumn6.HeaderText = "Total Juegos Perdidos";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Total_Pinos_Acumulados";
            this.dataGridViewTextBoxColumn7.HeaderText = "Total Pinos Acumulados";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "JG_Ultima_Semana";
            this.dataGridViewTextBoxColumn8.HeaderText = "JG Ultima Semana";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "JP_Ultima_Semana";
            this.dataGridViewTextBoxColumn9.HeaderText = "JP Ultima Semana";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Juego_Alto";
            this.dataGridViewTextBoxColumn10.HeaderText = "Juego Alto";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Serie_Alta";
            this.dataGridViewTextBoxColumn11.HeaderText = "Serie Alta";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblfecha.Location = new System.Drawing.Point(289, 105);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(18, 16);
            this.lblfecha.TabIndex = 66;
            this.lblfecha.Text = "()";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label19.Location = new System.Drawing.Point(12, 99);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 24);
            this.label19.TabIndex = 65;
            this.label19.Text = "Semana";
            // 
            // cbSemana
            // 
            this.cbSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSemana.FormattingEnabled = true;
            this.cbSemana.Location = new System.Drawing.Point(123, 101);
            this.cbSemana.Name = "cbSemana";
            this.cbSemana.Size = new System.Drawing.Size(157, 21);
            this.cbSemana.TabIndex = 64;
            // 
            // bL_LigasDS
            // 
            this.bL_LigasDS.DataSetName = "BL_LigasDS";
            this.bL_LigasDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ligasBindingSource
            // 
            this.ligasBindingSource.DataMember = "Ligas";
            this.ligasBindingSource.DataSource = this.bL_LigasDS;
            // 
            // ligasTableAdapter
            // 
            this.ligasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = Bowling_League.BL_LigasDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.RolesTableAdapter = this.rolesTableAdapter;
            this.tableAdapterManager2.UpdateOrder = Bowling_League.BL_RolesDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(400, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 72;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(773, 502);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 39);
            this.button2.TabIndex = 73;
            this.button2.Text = "Generar PDF";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Bowling_League.Properties.Resources.Back;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 44);
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormLigasDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(899, 553);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.cbSemana);
            this.Controls.Add(this.ligas_DetalleXEquiposDataGridView);
            this.Controls.Add(this.lblliga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormLigasDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles por equipos";
            this.Load += new System.EventHandler(this.FormLigasDetalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bL_LigasDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligas_DetalleXEquiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligas_DetalleXEquiposDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bL_LigasDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bL_RolesDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblliga;
        private BL_LigasDetalles bL_LigasDetalles;
        private System.Windows.Forms.BindingSource ligas_DetalleXEquiposBindingSource;
        private BL_LigasDetallesTableAdapters.Ligas_DetalleXEquiposTableAdapter ligas_DetalleXEquiposTableAdapter;
        private BL_LigasDetallesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView ligas_DetalleXEquiposDataGridView;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbSemana;
        private BL_LigasDS bL_LigasDS;
        private System.Windows.Forms.BindingSource ligasBindingSource;
        private BL_LigasDSTableAdapters.LigasTableAdapter ligasTableAdapter;
        private BL_LigasDSTableAdapters.TableAdapterManager tableAdapterManager1;
        private BL_RolesDS bL_RolesDS;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private BL_RolesDSTableAdapters.RolesTableAdapter rolesTableAdapter;
        private BL_RolesDSTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}