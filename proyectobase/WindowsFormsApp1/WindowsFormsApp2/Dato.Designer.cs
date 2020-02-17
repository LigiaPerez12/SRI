namespace WindowsFormsApp2
{
    partial class Dato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dato));
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.fechaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreapellidoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalessumaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalegresoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formudosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sriDataSet1 = new WindowsFormsApp2.sriDataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreapellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formusietBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sriDataSet = new WindowsFormsApp2.sriDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.formusietTableAdapter = new WindowsFormsApp2.sriDataSetTableAdapters.formusietTableAdapter();
            this.formudosTableAdapter = new WindowsFormsApp2.sriDataSet1TableAdapters.formudosTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formudosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sriDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formusietBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sriDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn1,
            this.nombreapellidoDataGridViewTextBoxColumn1,
            this.cedulaDataGridViewTextBoxColumn1,
            this.totalessumaDataGridViewTextBoxColumn,
            this.totalegresoDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.formudosBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(5, 273);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(804, 113);
            this.dataGridView3.TabIndex = 26;
            // 
            // fechaDataGridViewTextBoxColumn1
            // 
            this.fechaDataGridViewTextBoxColumn1.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn1.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn1.Name = "fechaDataGridViewTextBoxColumn1";
            this.fechaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nombreapellidoDataGridViewTextBoxColumn1
            // 
            this.nombreapellidoDataGridViewTextBoxColumn1.DataPropertyName = "nombre_apellido";
            this.nombreapellidoDataGridViewTextBoxColumn1.HeaderText = "nombre_apellido";
            this.nombreapellidoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nombreapellidoDataGridViewTextBoxColumn1.Name = "nombreapellidoDataGridViewTextBoxColumn1";
            this.nombreapellidoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nombreapellidoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // cedulaDataGridViewTextBoxColumn1
            // 
            this.cedulaDataGridViewTextBoxColumn1.DataPropertyName = "cedula";
            this.cedulaDataGridViewTextBoxColumn1.HeaderText = "cedula";
            this.cedulaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.cedulaDataGridViewTextBoxColumn1.Name = "cedulaDataGridViewTextBoxColumn1";
            this.cedulaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.cedulaDataGridViewTextBoxColumn1.Width = 125;
            // 
            // totalessumaDataGridViewTextBoxColumn
            // 
            this.totalessumaDataGridViewTextBoxColumn.DataPropertyName = "totales_suma";
            this.totalessumaDataGridViewTextBoxColumn.HeaderText = "totales_suma";
            this.totalessumaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalessumaDataGridViewTextBoxColumn.Name = "totalessumaDataGridViewTextBoxColumn";
            this.totalessumaDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalessumaDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalegresoDataGridViewTextBoxColumn
            // 
            this.totalegresoDataGridViewTextBoxColumn.DataPropertyName = "total_egreso";
            this.totalegresoDataGridViewTextBoxColumn.HeaderText = "total_egreso";
            this.totalegresoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalegresoDataGridViewTextBoxColumn.Name = "totalegresoDataGridViewTextBoxColumn";
            this.totalegresoDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalegresoDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // formudosBindingSource
            // 
            this.formudosBindingSource.DataMember = "formudos";
            this.formudosBindingSource.DataSource = this.sriDataSet1;
            // 
            // sriDataSet1
            // 
            this.sriDataSet1.DataSetName = "sriDataSet1";
            this.sriDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn,
            this.nombreapellidoDataGridViewTextBoxColumn,
            this.cedulaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.formusietBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 127);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(429, 113);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreapellidoDataGridViewTextBoxColumn
            // 
            this.nombreapellidoDataGridViewTextBoxColumn.DataPropertyName = "nombre_apellido";
            this.nombreapellidoDataGridViewTextBoxColumn.HeaderText = "nombre_apellido";
            this.nombreapellidoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreapellidoDataGridViewTextBoxColumn.Name = "nombreapellidoDataGridViewTextBoxColumn";
            this.nombreapellidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreapellidoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cedulaDataGridViewTextBoxColumn
            // 
            this.cedulaDataGridViewTextBoxColumn.DataPropertyName = "cedula";
            this.cedulaDataGridViewTextBoxColumn.HeaderText = "cedula";
            this.cedulaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cedulaDataGridViewTextBoxColumn.Name = "cedulaDataGridViewTextBoxColumn";
            this.cedulaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cedulaDataGridViewTextBoxColumn.Width = 125;
            // 
            // formusietBindingSource
            // 
            this.formusietBindingSource.DataMember = "formusiet";
            this.formusietBindingSource.DataSource = this.sriDataSet;
            // 
            // sriDataSet
            // 
            this.sriDataSet.DataSetName = "sriDataSet";
            this.sriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "FORMULARIO 102";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "FORMULARIO 107";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(586, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(223, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // formusietTableAdapter
            // 
            this.formusietTableAdapter.ClearBeforeFill = true;
            // 
            // formudosTableAdapter
            // 
            this.formudosTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 36);
            this.button1.TabIndex = 27;
            this.button1.Text = "VOLVER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Dato";
            this.Text = "Dato";
            this.Load += new System.EventHandler(this.Dato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formudosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sriDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formusietBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sriDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private sriDataSet sriDataSet;
        private System.Windows.Forms.BindingSource formusietBindingSource;
        private sriDataSetTableAdapters.formusietTableAdapter formusietTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreapellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn;
        private sriDataSet1 sriDataSet1;
        private System.Windows.Forms.BindingSource formudosBindingSource;
        private sriDataSet1TableAdapters.formudosTableAdapter formudosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreapellidoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalessumaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalegresoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}