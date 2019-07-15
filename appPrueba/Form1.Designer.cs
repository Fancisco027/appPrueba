namespace appPrueba
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Examinar = new System.Windows.Forms.OpenFileDialog();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.gvDatosExcel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatosExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // Examinar
            // 
            this.Examinar.FileName = "opfExcel";
            this.Examinar.FileOk += new System.ComponentModel.CancelEventHandler(this.Examinar_FileOk);
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(26, 38);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(75, 23);
            this.btnExaminar.TabIndex = 0;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // gvDatosExcel
            // 
            this.gvDatosExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDatosExcel.Location = new System.Drawing.Point(26, 83);
            this.gvDatosExcel.Name = "gvDatosExcel";
            this.gvDatosExcel.Size = new System.Drawing.Size(440, 150);
            this.gvDatosExcel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 311);
            this.Controls.Add(this.gvDatosExcel);
            this.Controls.Add(this.btnExaminar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gvDatosExcel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog Examinar;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.DataGridView gvDatosExcel;
    }
}

