
namespace ProductosApp.Forms
{
    partial class FrmActualizar
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
            this.brnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID1 = new System.Windows.Forms.TextBox();
            this.txtNME2 = new System.Windows.Forms.TextBox();
            this.txtETA3 = new System.Windows.Forms.TextBox();
            this.txtPRC4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // brnAceptar
            // 
            this.brnAceptar.Location = new System.Drawing.Point(110, 237);
            this.brnAceptar.Name = "brnAceptar";
            this.brnAceptar.Size = new System.Drawing.Size(75, 34);
            this.brnAceptar.TabIndex = 0;
            this.brnAceptar.Text = "Aceptar ";
            this.brnAceptar.UseVisualStyleBackColor = true;
            this.brnAceptar.Click += new System.EventHandler(this.brnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Existencia";
            // 
            // txtID1
            // 
            this.txtID1.Location = new System.Drawing.Point(110, 27);
            this.txtID1.Name = "txtID1";
            this.txtID1.Size = new System.Drawing.Size(100, 22);
            this.txtID1.TabIndex = 4;
            // 
            // txtNME2
            // 
            this.txtNME2.Location = new System.Drawing.Point(110, 75);
            this.txtNME2.Name = "txtNME2";
            this.txtNME2.Size = new System.Drawing.Size(100, 22);
            this.txtNME2.TabIndex = 5;
            // 
            // txtETA3
            // 
            this.txtETA3.Location = new System.Drawing.Point(110, 132);
            this.txtETA3.Name = "txtETA3";
            this.txtETA3.Size = new System.Drawing.Size(100, 22);
            this.txtETA3.TabIndex = 6;
            // 
            // txtPRC4
            // 
            this.txtPRC4.Location = new System.Drawing.Point(110, 187);
            this.txtPRC4.Name = "txtPRC4";
            this.txtPRC4.Size = new System.Drawing.Size(100, 22);
            this.txtPRC4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Precio";
            // 
            // FrmActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 305);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPRC4);
            this.Controls.Add(this.txtETA3);
            this.Controls.Add(this.txtNME2);
            this.Controls.Add(this.txtID1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brnAceptar);
            this.Name = "FrmActualizar";
            this.Text = "FrmActualizar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button brnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID1;
        private System.Windows.Forms.TextBox txtNME2;
        private System.Windows.Forms.TextBox txtETA3;
        private System.Windows.Forms.TextBox txtPRC4;
        private System.Windows.Forms.Label label4;
    }
}