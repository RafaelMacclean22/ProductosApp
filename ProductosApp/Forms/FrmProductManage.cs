using Domain.Enums;
using Infraestructure.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosApp.Forms
{
    public partial class FrmProductManage : Form
    {
        private ProductoModel productoModel;
        public FrmProductManage()
        {
            productoModel = new ProductoModel();
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFinder.SelectedIndex)
            {
                case 0:
                    pnlId.Visible = true;
                    pnlMeasureUnit.Visible = false;
                    pnlPriceRange.Visible = false;
                    pnlCaducity.Visible = false;
                    break;
                case 1:
                    pnlId.Visible = false;
                    pnlMeasureUnit.Visible = true;
                    pnlPriceRange.Visible = false;
                    pnlCaducity.Visible = false;
                    break;
                case 2:
                    pnlId.Visible = false;
                    pnlMeasureUnit.Visible = false;
                    pnlPriceRange.Visible = true;
                    pnlCaducity.Visible = false;
                    break;
                case 3:
                    pnlId.Visible = false;
                    pnlMeasureUnit.Visible = false;
                    pnlPriceRange.Visible = false;
                    pnlCaducity.Visible = true;
                    break;
            }
        }

        private void FrmProductManage_Load(object sender, EventArgs e)
        {
            cmbMeasureUnit.Items.AddRange(Enum.GetValues(typeof(UnidadMedida))
                                              .Cast<object>().ToArray()
                                         );
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto();
            frmProducto.ProductoModel = productoModel;
            frmProducto.ShowDialog();

            rtbProductView.Text = productoModel.GetProductosAsJson();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FormProductodelete formProductodelete = new FormProductodelete();
            formProductodelete.ProductoModel = productoModel;
            formProductodelete.ShowDialog();

            rtbProductView.Text = productoModel.GetProductosAsJson();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] words = txtIdW.Text.Split();
            foreach (String word in words)
            {
                int startIndex = 0;
                while (startIndex < rtbProductView.Text.Length)
                {

                    int wordStartIndex = rtbProductView.Find(word, startIndex, RichTextBoxFinds.None);
                    if (wordStartIndex != -1)
                    {
                        rtbProductView.SelectionStart = wordStartIndex;
                        rtbProductView.SelectionLength = word.Length;
                        rtbProductView.SelectionBackColor = System.Drawing.Color.Yellow;
                    }
                    else
                        break;
                    startIndex += wordStartIndex + word.Length;

                }
            }
    }

        private void btnAdios_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpCaducity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpCaducity_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void rtbProductView_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
