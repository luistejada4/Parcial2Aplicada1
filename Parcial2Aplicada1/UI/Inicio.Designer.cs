namespace Parcial2Aplicada1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxEmpleadoIdDetalle = new System.Windows.Forms.MaskedTextBox();
            this.textBoxEmpleadoNombreDetalle = new System.Windows.Forms.TextBox();
            this.dateTimePickerEmpleadoNacDetalle = new System.Windows.Forms.DateTimePicker();
            this.textBoxEmpleadoSueldoDetalle = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonBuscarDetalle = new System.Windows.Forms.Button();
            this.dataGridViewEmpleadoRetencionesDetalle = new System.Windows.Forms.DataGridView();
            this.dataGridViewEmpleadoCorreosDetalle = new System.Windows.Forms.DataGridView();
            this.TipoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleadoRetencionesDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleadoCorreosDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(645, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            this.registrosToolStripMenuItem.Click += new System.EventHandler(this.registrosToolStripMenuItem_Click);
            // 
            // textBoxEmpleadoIdDetalle
            // 
            this.textBoxEmpleadoIdDetalle.Location = new System.Drawing.Point(76, 19);
            this.textBoxEmpleadoIdDetalle.Name = "textBoxEmpleadoIdDetalle";
            this.textBoxEmpleadoIdDetalle.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmpleadoIdDetalle.TabIndex = 1;
            // 
            // textBoxEmpleadoNombreDetalle
            // 
            this.textBoxEmpleadoNombreDetalle.Location = new System.Drawing.Point(76, 45);
            this.textBoxEmpleadoNombreDetalle.Name = "textBoxEmpleadoNombreDetalle";
            this.textBoxEmpleadoNombreDetalle.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmpleadoNombreDetalle.TabIndex = 2;
            // 
            // dateTimePickerEmpleadoNacDetalle
            // 
            this.dateTimePickerEmpleadoNacDetalle.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEmpleadoNacDetalle.Location = new System.Drawing.Point(76, 71);
            this.dateTimePickerEmpleadoNacDetalle.Name = "dateTimePickerEmpleadoNacDetalle";
            this.dateTimePickerEmpleadoNacDetalle.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerEmpleadoNacDetalle.TabIndex = 3;
            // 
            // textBoxEmpleadoSueldoDetalle
            // 
            this.textBoxEmpleadoSueldoDetalle.Location = new System.Drawing.Point(76, 97);
            this.textBoxEmpleadoSueldoDetalle.Name = "textBoxEmpleadoSueldoDetalle";
            this.textBoxEmpleadoSueldoDetalle.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmpleadoSueldoDetalle.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonBuscarDetalle);
            this.groupBox1.Controls.Add(this.dataGridViewEmpleadoRetencionesDetalle);
            this.groupBox1.Controls.Add(this.dataGridViewEmpleadoCorreosDetalle);
            this.groupBox1.Controls.Add(this.textBoxEmpleadoIdDetalle);
            this.groupBox1.Controls.Add(this.textBoxEmpleadoSueldoDetalle);
            this.groupBox1.Controls.Add(this.textBoxEmpleadoNombreDetalle);
            this.groupBox1.Controls.Add(this.dateTimePickerEmpleadoNacDetalle);
            this.groupBox1.Location = new System.Drawing.Point(49, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 356);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // buttonBuscarDetalle
            // 
            this.buttonBuscarDetalle.Location = new System.Drawing.Point(182, 19);
            this.buttonBuscarDetalle.Name = "buttonBuscarDetalle";
            this.buttonBuscarDetalle.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarDetalle.TabIndex = 9;
            this.buttonBuscarDetalle.Text = "buscar";
            this.buttonBuscarDetalle.UseVisualStyleBackColor = true;
            this.buttonBuscarDetalle.Click += new System.EventHandler(this.buttonBuscarDetalle_Click);
            // 
            // dataGridViewEmpleadoRetencionesDetalle
            // 
            this.dataGridViewEmpleadoRetencionesDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleadoRetencionesDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DescripcionColumn,
            this.ValorColumn});
            this.dataGridViewEmpleadoRetencionesDetalle.Location = new System.Drawing.Point(76, 240);
            this.dataGridViewEmpleadoRetencionesDetalle.Name = "dataGridViewEmpleadoRetencionesDetalle";
            this.dataGridViewEmpleadoRetencionesDetalle.Size = new System.Drawing.Size(250, 110);
            this.dataGridViewEmpleadoRetencionesDetalle.TabIndex = 7;
            // 
            // dataGridViewEmpleadoCorreosDetalle
            // 
            this.dataGridViewEmpleadoCorreosDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleadoCorreosDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmailColumn,
            this.TipoColumn});
            this.dataGridViewEmpleadoCorreosDetalle.Location = new System.Drawing.Point(76, 123);
            this.dataGridViewEmpleadoCorreosDetalle.Name = "dataGridViewEmpleadoCorreosDetalle";
            this.dataGridViewEmpleadoCorreosDetalle.Size = new System.Drawing.Size(250, 111);
            this.dataGridViewEmpleadoCorreosDetalle.TabIndex = 6;
            // 
            // TipoColumn
            // 
            this.TipoColumn.HeaderText = "Tipo";
            this.TipoColumn.Name = "TipoColumn";
            // 
            // EmailColumn
            // 
            this.EmailColumn.HeaderText = "Email";
            this.EmailColumn.Name = "EmailColumn";
            // 
            // DescripcionColumn
            // 
            this.DescripcionColumn.HeaderText = "Descripcion";
            this.DescripcionColumn.Name = "DescripcionColumn";
            // 
            // ValorColumn
            // 
            this.ValorColumn.HeaderText = "Valor";
            this.ValorColumn.Name = "ValorColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Id empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Sueldo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Emails";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Retenciones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 424);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleadoRetencionesDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleadoCorreosDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox textBoxEmpleadoIdDetalle;
        private System.Windows.Forms.TextBox textBoxEmpleadoNombreDetalle;
        private System.Windows.Forms.DateTimePicker dateTimePickerEmpleadoNacDetalle;
        private System.Windows.Forms.TextBox textBoxEmpleadoSueldoDetalle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonBuscarDetalle;
        private System.Windows.Forms.DataGridView dataGridViewEmpleadoRetencionesDetalle;
        private System.Windows.Forms.DataGridView dataGridViewEmpleadoCorreosDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

