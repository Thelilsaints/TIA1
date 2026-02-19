namespace TIA1
{
    partial class frmAyuda
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
            this.rtbAyuda = new System.Windows.Forms.RichTextBox();
            this.btnBuscarTema = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trvIndice = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // rtbAyuda
            // 
            this.rtbAyuda.Location = new System.Drawing.Point(61, 162);
            this.rtbAyuda.Name = "rtbAyuda";
            this.rtbAyuda.Size = new System.Drawing.Size(287, 207);
            this.rtbAyuda.TabIndex = 0;
            this.rtbAyuda.Text = "";
            this.rtbAyuda.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnBuscarTema
            // 
            this.btnBuscarTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(122)))), ((int)(((byte)(95)))));
            this.btnBuscarTema.Location = new System.Drawing.Point(145, 385);
            this.btnBuscarTema.Name = "btnBuscarTema";
            this.btnBuscarTema.Size = new System.Drawing.Size(96, 39);
            this.btnBuscarTema.TabIndex = 1;
            this.btnBuscarTema.Text = "Buscar";
            this.btnBuscarTema.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "DOCUMENTACIÓN INTERNA";
            // 
            // trvIndice
            // 
            this.trvIndice.Location = new System.Drawing.Point(61, 59);
            this.trvIndice.Name = "trvIndice";
            this.trvIndice.Size = new System.Drawing.Size(287, 97);
            this.trvIndice.TabIndex = 3;
            this.trvIndice.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // frmAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(399, 452);
            this.Controls.Add(this.trvIndice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarTema);
            this.Controls.Add(this.rtbAyuda);
            this.Name = "frmAyuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayuda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbAyuda;
        private System.Windows.Forms.Button btnBuscarTema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView trvIndice;
    }
}