namespace ACRRentalCar
{
    partial class frmConsultaCliente
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
            this.dvgCliente = new System.Windows.Forms.DataGridView();
            this.dBLOCADORADECARROSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_LOCADORADECARROSDataSet = new ACRRentalCar.DB_LOCADORADECARROSDataSet();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLOCADORADECARROSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_LOCADORADECARROSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgCliente
            // 
            this.dvgCliente.AllowDrop = true;
            this.dvgCliente.AllowUserToAddRows = false;
            this.dvgCliente.AllowUserToDeleteRows = false;
            this.dvgCliente.AllowUserToOrderColumns = true;
            this.dvgCliente.AutoGenerateColumns = false;
            this.dvgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCliente.DataSource = this.dBLOCADORADECARROSDataSetBindingSource;
            this.dvgCliente.Location = new System.Drawing.Point(12, 29);
            this.dvgCliente.Name = "dvgCliente";
            this.dvgCliente.ReadOnly = true;
            this.dvgCliente.Size = new System.Drawing.Size(513, 240);
            this.dvgCliente.TabIndex = 0;
            // 
            // dBLOCADORADECARROSDataSetBindingSource
            // 
            this.dBLOCADORADECARROSDataSetBindingSource.DataSource = this.dB_LOCADORADECARROSDataSet;
            this.dBLOCADORADECARROSDataSetBindingSource.Position = 0;
            // 
            // dB_LOCADORADECARROSDataSet
            // 
            this.dB_LOCADORADECARROSDataSet.DataSetName = "DB_LOCADORADECARROSDataSet";
            this.dB_LOCADORADECARROSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.Location = new System.Drawing.Point(25, 311);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionar.TabIndex = 1;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(450, 311);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 358);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.dvgCliente);
            this.Name = "frmConsultaCliente";
            this.Text = "frmConsultaCliente";
            this.Load += new System.EventHandler(this.frmConsultaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLOCADORADECARROSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_LOCADORADECARROSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dBLOCADORADECARROSDataSetBindingSource;
        private DB_LOCADORADECARROSDataSet dB_LOCADORADECARROSDataSet;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnCancelar;
        internal System.Windows.Forms.DataGridView dvgCliente;
    }
}