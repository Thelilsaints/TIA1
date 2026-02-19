namespace TIA1
{
    partial class frmInformes
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
            this.cboTipoDeInforme = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpRangoDeFecha = new System.Windows.Forms.DateTimePicker();
            this.btnGenerarInforme = new System.Windows.Forms.Button();
            this.dgvVisualizarInforme = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarInforme)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTipoDeInforme
            // 
            this.cboTipoDeInforme.FormattingEnabled = true;
            this.cboTipoDeInforme.Location = new System.Drawing.Point(132, 57);
            this.cboTipoDeInforme.Name = "cboTipoDeInforme";
            this.cboTipoDeInforme.Size = new System.Drawing.Size(198, 21);
            this.cboTipoDeInforme.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Informe";
            // 
            // dtpRangoDeFecha
            // 
            this.dtpRangoDeFecha.Location = new System.Drawing.Point(353, 58);
            this.dtpRangoDeFecha.Name = "dtpRangoDeFecha";
            this.dtpRangoDeFecha.Size = new System.Drawing.Size(220, 20);
            this.dtpRangoDeFecha.TabIndex = 2;
            // 
            // btnGenerarInforme
            // 
            this.btnGenerarInforme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(122)))), ((int)(((byte)(95)))));
            this.btnGenerarInforme.Location = new System.Drawing.Point(36, 399);
            this.btnGenerarInforme.Name = "btnGenerarInforme";
            this.btnGenerarInforme.Size = new System.Drawing.Size(112, 47);
            this.btnGenerarInforme.TabIndex = 3;
            this.btnGenerarInforme.Text = "Generar Informe";
            this.btnGenerarInforme.UseVisualStyleBackColor = false;
            // 
            // dgvVisualizarInforme
            // 
            this.dgvVisualizarInforme.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(64)))), ((int)(((byte)(91)))));
            this.dgvVisualizarInforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizarInforme.Location = new System.Drawing.Point(36, 95);
            this.dgvVisualizarInforme.Name = "dgvVisualizarInforme";
            this.dgvVisualizarInforme.Size = new System.Drawing.Size(537, 288);
            this.dgvVisualizarInforme.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "REPORTES E INFORMES";
            // 
            // frmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(618, 458);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvVisualizarInforme);
            this.Controls.Add(this.btnGenerarInforme);
            this.Controls.Add(this.dtpRangoDeFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTipoDeInforme);
            this.Name = "frmInformes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizarInforme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTipoDeInforme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpRangoDeFecha;
        private System.Windows.Forms.Button btnGenerarInforme;
        private System.Windows.Forms.DataGridView dgvVisualizarInforme;
        private System.Windows.Forms.Label label2;
    }
}