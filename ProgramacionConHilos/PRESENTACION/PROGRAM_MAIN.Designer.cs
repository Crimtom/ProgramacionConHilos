namespace ProgramacionConHilos
{
    partial class PROGRAM_MAIN
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.LAB_PROCESANDO = new System.Windows.Forms.Label();
            this.Dtg_Edades_Sexo = new System.Windows.Forms.DataGridView();
            this.LAB_EDADES = new System.Windows.Forms.Label();
            this.LAB_ETAREO = new System.Windows.Forms.Label();
            this.Dtg_Etareo = new System.Windows.Forms.DataGridView();
            this.LAB_ESCOLARIDAD = new System.Windows.Forms.Label();
            this.Dtg_Escolaridad = new System.Windows.Forms.DataGridView();
            this.BT_SALIR = new System.Windows.Forms.Button();
            this.BT_CARGAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Edades_Sexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Etareo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Escolaridad)).BeginInit();
            this.SuspendLayout();
            // 
            // LAB_PROCESANDO
            // 
            this.LAB_PROCESANDO.AutoSize = true;
            this.LAB_PROCESANDO.BackColor = System.Drawing.Color.Transparent;
            this.LAB_PROCESANDO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_PROCESANDO.Location = new System.Drawing.Point(12, 9);
            this.LAB_PROCESANDO.Name = "LAB_PROCESANDO";
            this.LAB_PROCESANDO.Size = new System.Drawing.Size(192, 25);
            this.LAB_PROCESANDO.TabIndex = 0;
            this.LAB_PROCESANDO.Text = "Procesando Hilo:";
            // 
            // Dtg_Edades_Sexo
            // 
            this.Dtg_Edades_Sexo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dtg_Edades_Sexo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dtg_Edades_Sexo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtg_Edades_Sexo.Location = new System.Drawing.Point(12, 106);
            this.Dtg_Edades_Sexo.Name = "Dtg_Edades_Sexo";
            this.Dtg_Edades_Sexo.RowHeadersWidth = 62;
            this.Dtg_Edades_Sexo.Size = new System.Drawing.Size(389, 464);
            this.Dtg_Edades_Sexo.TabIndex = 21;
            // 
            // LAB_EDADES
            // 
            this.LAB_EDADES.AutoSize = true;
            this.LAB_EDADES.BackColor = System.Drawing.Color.Transparent;
            this.LAB_EDADES.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_EDADES.Location = new System.Drawing.Point(60, 83);
            this.LAB_EDADES.Name = "LAB_EDADES";
            this.LAB_EDADES.Size = new System.Drawing.Size(265, 20);
            this.LAB_EDADES.TabIndex = 22;
            this.LAB_EDADES.Text = "Lista de edades según el sexo";
            // 
            // LAB_ETAREO
            // 
            this.LAB_ETAREO.AutoSize = true;
            this.LAB_ETAREO.BackColor = System.Drawing.Color.Transparent;
            this.LAB_ETAREO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_ETAREO.Location = new System.Drawing.Point(441, 83);
            this.LAB_ETAREO.Name = "LAB_ETAREO";
            this.LAB_ETAREO.Size = new System.Drawing.Size(299, 20);
            this.LAB_ETAREO.TabIndex = 24;
            this.LAB_ETAREO.Text = "Listado según sexo y grupo etáreo";
            // 
            // Dtg_Etareo
            // 
            this.Dtg_Etareo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dtg_Etareo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dtg_Etareo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtg_Etareo.Location = new System.Drawing.Point(407, 106);
            this.Dtg_Etareo.Name = "Dtg_Etareo";
            this.Dtg_Etareo.RowHeadersWidth = 62;
            this.Dtg_Etareo.Size = new System.Drawing.Size(372, 464);
            this.Dtg_Etareo.TabIndex = 23;
            // 
            // LAB_ESCOLARIDAD
            // 
            this.LAB_ESCOLARIDAD.AutoSize = true;
            this.LAB_ESCOLARIDAD.BackColor = System.Drawing.Color.Transparent;
            this.LAB_ESCOLARIDAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB_ESCOLARIDAD.Location = new System.Drawing.Point(840, 83);
            this.LAB_ESCOLARIDAD.Name = "LAB_ESCOLARIDAD";
            this.LAB_ESCOLARIDAD.Size = new System.Drawing.Size(230, 20);
            this.LAB_ESCOLARIDAD.TabIndex = 26;
            this.LAB_ESCOLARIDAD.Text = "Listado según escolaridad";
            // 
            // Dtg_Escolaridad
            // 
            this.Dtg_Escolaridad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Dtg_Escolaridad.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Dtg_Escolaridad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtg_Escolaridad.Location = new System.Drawing.Point(785, 106);
            this.Dtg_Escolaridad.Name = "Dtg_Escolaridad";
            this.Dtg_Escolaridad.RowHeadersWidth = 62;
            this.Dtg_Escolaridad.Size = new System.Drawing.Size(348, 464);
            this.Dtg_Escolaridad.TabIndex = 25;
            // 
            // BT_SALIR
            // 
            this.BT_SALIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_SALIR.Location = new System.Drawing.Point(986, 587);
            this.BT_SALIR.Name = "BT_SALIR";
            this.BT_SALIR.Size = new System.Drawing.Size(158, 63);
            this.BT_SALIR.TabIndex = 27;
            this.BT_SALIR.Text = "SALIR";
            this.BT_SALIR.UseVisualStyleBackColor = true;
            this.BT_SALIR.Click += new System.EventHandler(this.BT_SALIR_Click);
            // 
            // BT_CARGAR
            // 
            this.BT_CARGAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_CARGAR.Location = new System.Drawing.Point(822, 587);
            this.BT_CARGAR.Name = "BT_CARGAR";
            this.BT_CARGAR.Size = new System.Drawing.Size(158, 63);
            this.BT_CARGAR.TabIndex = 28;
            this.BT_CARGAR.Text = "CARGAR ARCHIVO";
            this.BT_CARGAR.UseVisualStyleBackColor = true;
            this.BT_CARGAR.Click += new System.EventHandler(this.BT_CARGAR_Click);
            // 
            // PROGRAM_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1145, 672);
            this.Controls.Add(this.BT_CARGAR);
            this.Controls.Add(this.BT_SALIR);
            this.Controls.Add(this.LAB_ESCOLARIDAD);
            this.Controls.Add(this.Dtg_Escolaridad);
            this.Controls.Add(this.LAB_ETAREO);
            this.Controls.Add(this.Dtg_Etareo);
            this.Controls.Add(this.LAB_EDADES);
            this.Controls.Add(this.Dtg_Edades_Sexo);
            this.Controls.Add(this.LAB_PROCESANDO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "PROGRAM_MAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INEC";
            this.Load += new System.EventHandler(this.PROGRAM_MAIN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Edades_Sexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Etareo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtg_Escolaridad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label LAB_PROCESANDO;
        private System.Windows.Forms.DataGridView Dtg_Edades_Sexo;
        private System.Windows.Forms.Label LAB_EDADES;
        private System.Windows.Forms.Label LAB_ETAREO;
        private System.Windows.Forms.DataGridView Dtg_Etareo;
        private System.Windows.Forms.Label LAB_ESCOLARIDAD;
        private System.Windows.Forms.DataGridView Dtg_Escolaridad;
        private System.Windows.Forms.Button BT_SALIR;
        private System.Windows.Forms.Button BT_CARGAR;
    }
}