namespace ProductosApp.Forms
{
    partial class FrmProductManage
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAdios = new System.Windows.Forms.Button();
            this.cmbFinder = new System.Windows.Forms.ComboBox();
            this.rtbProductView = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIdW = new System.Windows.Forms.TextBox();
            this.pnlId = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.nudToPrice = new System.Windows.Forms.NumericUpDown();
            this.pnlPriceRange = new System.Windows.Forms.Panel();
            this.nudFromPrice = new System.Windows.Forms.NumericUpDown();
            this.pnlMeasureUnit = new System.Windows.Forms.Panel();
            this.cmbMeasureUnit = new System.Windows.Forms.ComboBox();
            this.pnlCaducity = new System.Windows.Forms.Panel();
            this.dtpCaducity = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudToPrice)).BeginInit();
            this.pnlPriceRange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFromPrice)).BeginInit();
            this.pnlMeasureUnit.SuspendLayout();
            this.pnlCaducity.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Controls.Add(this.btnUpdate);
            this.flowLayoutPanel1.Controls.Add(this.btnNew);
            this.flowLayoutPanel1.Controls.Add(this.btnAdios);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(54, 401);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(722, 37);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(619, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(513, 2);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(407, 2);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 30);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnAdios
            // 
            this.btnAdios.Location = new System.Drawing.Point(318, 3);
            this.btnAdios.Name = "btnAdios";
            this.btnAdios.Size = new System.Drawing.Size(83, 29);
            this.btnAdios.TabIndex = 3;
            this.btnAdios.Text = "Salir ";
            this.btnAdios.UseVisualStyleBackColor = true;
            this.btnAdios.Click += new System.EventHandler(this.btnAdios_Click);
            // 
            // cmbFinder
            // 
            this.cmbFinder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFinder.FormattingEnabled = true;
            this.cmbFinder.Items.AddRange(new object[] {
            "Id",
            "Unidad de Medida",
            "Rango de Precio",
            "Fecha de Vencimiento"});
            this.cmbFinder.Location = new System.Drawing.Point(54, 11);
            this.cmbFinder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFinder.Name = "cmbFinder";
            this.cmbFinder.Size = new System.Drawing.Size(167, 24);
            this.cmbFinder.TabIndex = 1;
            this.cmbFinder.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // rtbProductView
            // 
            this.rtbProductView.Location = new System.Drawing.Point(54, 45);
            this.rtbProductView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbProductView.Name = "rtbProductView";
            this.rtbProductView.ReadOnly = true;
            this.rtbProductView.Size = new System.Drawing.Size(722, 354);
            this.rtbProductView.TabIndex = 5;
            this.rtbProductView.Text = "";
            this.rtbProductView.TextChanged += new System.EventHandler(this.rtbProductView_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIdW
            // 
            this.txtIdW.Location = new System.Drawing.Point(502, 15);
            this.txtIdW.Name = "txtIdW";
            this.txtIdW.Size = new System.Drawing.Size(271, 22);
            this.txtIdW.TabIndex = 7;
            // 
            // pnlId
            // 
            this.pnlId.Controls.Add(this.txtId);
            this.pnlId.Location = new System.Drawing.Point(231, 12);
            this.pnlId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlId.Name = "pnlId";
            this.pnlId.Size = new System.Drawing.Size(184, 25);
            this.pnlId.TabIndex = 2;
            this.pnlId.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(3, 0);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(181, 22);
            this.txtId.TabIndex = 3;
            // 
            // nudToPrice
            // 
            this.nudToPrice.Location = new System.Drawing.Point(171, 0);
            this.nudToPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudToPrice.Name = "nudToPrice";
            this.nudToPrice.Size = new System.Drawing.Size(12, 22);
            this.nudToPrice.TabIndex = 4;
            // 
            // pnlPriceRange
            // 
            this.pnlPriceRange.Controls.Add(this.nudToPrice);
            this.pnlPriceRange.Controls.Add(this.nudFromPrice);
            this.pnlPriceRange.Location = new System.Drawing.Point(227, 12);
            this.pnlPriceRange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlPriceRange.Name = "pnlPriceRange";
            this.pnlPriceRange.Size = new System.Drawing.Size(188, 25);
            this.pnlPriceRange.TabIndex = 3;
            this.pnlPriceRange.Visible = false;
            // 
            // nudFromPrice
            // 
            this.nudFromPrice.Location = new System.Drawing.Point(3, 0);
            this.nudFromPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudFromPrice.Name = "nudFromPrice";
            this.nudFromPrice.Size = new System.Drawing.Size(163, 22);
            this.nudFromPrice.TabIndex = 4;
            // 
            // pnlMeasureUnit
            // 
            this.pnlMeasureUnit.Controls.Add(this.cmbMeasureUnit);
            this.pnlMeasureUnit.Location = new System.Drawing.Point(229, 12);
            this.pnlMeasureUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMeasureUnit.Name = "pnlMeasureUnit";
            this.pnlMeasureUnit.Size = new System.Drawing.Size(186, 26);
            this.pnlMeasureUnit.TabIndex = 3;
            this.pnlMeasureUnit.Visible = false;
            // 
            // cmbMeasureUnit
            // 
            this.cmbMeasureUnit.FormattingEnabled = true;
            this.cmbMeasureUnit.Location = new System.Drawing.Point(3, 0);
            this.cmbMeasureUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMeasureUnit.Name = "cmbMeasureUnit";
            this.cmbMeasureUnit.Size = new System.Drawing.Size(183, 24);
            this.cmbMeasureUnit.TabIndex = 4;
            // 
            // pnlCaducity
            // 
            this.pnlCaducity.Controls.Add(this.dtpCaducity);
            this.pnlCaducity.Location = new System.Drawing.Point(227, 12);
            this.pnlCaducity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCaducity.Name = "pnlCaducity";
            this.pnlCaducity.Size = new System.Drawing.Size(183, 25);
            this.pnlCaducity.TabIndex = 4;
            this.pnlCaducity.Visible = false;
            // 
            // dtpCaducity
            // 
            this.dtpCaducity.Location = new System.Drawing.Point(-42, 1);
            this.dtpCaducity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpCaducity.Name = "dtpCaducity";
            this.dtpCaducity.Size = new System.Drawing.Size(230, 22);
            this.dtpCaducity.TabIndex = 5;
            this.dtpCaducity.ValueChanged += new System.EventHandler(this.dtpCaducity_ValueChanged_1);
            // 
            // FrmProductManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.txtIdW);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtbProductView);
            this.Controls.Add(this.pnlCaducity);
            this.Controls.Add(this.pnlMeasureUnit);
            this.Controls.Add(this.pnlPriceRange);
            this.Controls.Add(this.pnlId);
            this.Controls.Add(this.cmbFinder);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmProductManage";
            this.Text = "Gestion de productos";
            this.Load += new System.EventHandler(this.FrmProductManage_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlId.ResumeLayout(false);
            this.pnlId.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudToPrice)).EndInit();
            this.pnlPriceRange.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudFromPrice)).EndInit();
            this.pnlMeasureUnit.ResumeLayout(false);
            this.pnlCaducity.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cmbFinder;
        private System.Windows.Forms.RichTextBox rtbProductView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIdW;
        private System.Windows.Forms.Button btnAdios;
        private System.Windows.Forms.Panel pnlId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.NumericUpDown nudToPrice;
        private System.Windows.Forms.Panel pnlPriceRange;
        private System.Windows.Forms.NumericUpDown nudFromPrice;
        private System.Windows.Forms.Panel pnlMeasureUnit;
        private System.Windows.Forms.ComboBox cmbMeasureUnit;
        private System.Windows.Forms.Panel pnlCaducity;
        private System.Windows.Forms.DateTimePicker dtpCaducity;
    }
}