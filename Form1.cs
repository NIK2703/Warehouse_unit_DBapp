using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Warehouse_unit_DBapp
{
    public partial class Form1 : Form
    {
        static int currentExistMaterialID = 0;
        static int currentInvoicePersonID = 0;
        static int currentInvoiceMaterialID = 0;
        List<Object[]> existMaterialsEnum;
        List<Object[]> personEnum;
        List<Object[]> invoiceNewLines;
        public Form1()
        {
            InitializeComponent();
            updateForm();

            
            invoiceNewLines = new List<object[]>();
        }

        public void fillInvoiceTreeView()
        {
            tvInvoice.Nodes.Clear();
            List<Object[]> list = DatabaseRepository.getInvoiceList();
            foreach (Object[] o in list)
            {
                TreeNode invoice = new TreeNode(((DateTime)o[2]).Date + " - " + (String)o[1]);
                List<Object[]> invoiceRows = DatabaseRepository.getInvoiceLineList((Int32)o[0]);
                foreach(Object[] row in invoiceRows) {
                    invoice.Nodes.Add((String)row[0] + " " + (Double)row[1] + " " + (String)row[2]); 
                }
                tvInvoice.Nodes.Add(invoice);
            }
            
        }

        public void updateForm()
        {
            dgvMaterials.DataSource = DatabaseRepository.getMaterialsTable();
            existMaterialsEnum = DatabaseRepository.getMaterialsEnum();
            cbMaterialExistSelect.Items.Clear();
            cbInvoiceMaterialSelect.Items.Clear();
            foreach (Object[] me in existMaterialsEnum)
            {
                cbMaterialExistSelect.Items.Add((Int32)me[0] + " " + (String)me[1]);
                cbInvoiceMaterialSelect.Items.Add((Int32)me[0] + " " + (String)me[1]);
            }
            fillInvoiceTreeView();
            personEnum = DatabaseRepository.getPersonEnum();
            cbInvoiceNewPerson.Items.Clear();
            foreach (Object[] pe in personEnum)
            {
                cbInvoiceNewPerson.Items.Add((Int32)pe[0] + " " + (String)pe[1]);

            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseRepository.insertNewMaterial(tbMaterialsNewName.Text, Convert.ToDouble(tbMaterialsNewQuantity.Text),
                tbMaterialsNewMeasureUnit.Text, tbMaterialsNewProvider.Text);
            tbMaterialsNewName.Text = "";
            tbMaterialsNewQuantity.Text = "";
            tbMaterialsNewMeasureUnit.Text = "";
            tbMaterialsNewProvider.Text = "";
            updateForm();
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bMaterialNewClear_Click(object sender, EventArgs e)
        {
            tbMaterialsNewName.Text = "";
            tbMaterialsNewQuantity.Text = "";
            tbMaterialsNewMeasureUnit.Text = "";
            tbMaterialsNewProvider.Text = "";
        }

        private void cbMaterialExistSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentExistMaterialID = Convert.ToInt32(cbMaterialExistSelect.SelectedItem.ToString().Split(' ')[0]);
            foreach (Object[] o in existMaterialsEnum)
            {
                if (currentExistMaterialID == Convert.ToInt32(o[0]))
                {
                    lMaterialExistMeasureUnit.Text = Convert.ToString(o[2]);
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void bMaterialsExistAdd_Click(object sender, EventArgs e)
        {
            DatabaseRepository.updateMaterialQuantity(currentExistMaterialID, Convert.ToDouble(tbExistMaterialQuantity.Text));
            tbExistMaterialQuantity.Text = "";
            cbMaterialExistSelect.SelectedIndex = 0;
            dgvMaterials.DataSource = DatabaseRepository.getMaterialsTable();
            updateForm();
        }

        private void dgvMaterials_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cbInvoiceNewPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentInvoicePersonID = Convert.ToInt32(cbInvoiceNewPerson.SelectedItem.ToString().Split(' ')[0]);
        }

        private void cbInvoiceMaterialSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentInvoiceMaterialID = Convert.ToInt32(cbInvoiceMaterialSelect.SelectedItem.ToString().Split(' ')[0]);
            foreach (Object[] o in existMaterialsEnum)
            {
                if (currentInvoiceMaterialID == Convert.ToInt32(o[0]))
                {
                    lInvoiceMeasureUnit.Text = Convert.ToString(o[2]);
                }
            }
        }

        private void bInvoiceAddLine_Click(object sender, EventArgs e)
        {
            invoiceNewLines.Add(new Object[] { currentInvoiceMaterialID, Convert.ToDouble(tbInvoiceQuantity.Text) });
            lbInvoiceNewLines.Items.Add(cbInvoiceMaterialSelect.Text.Split(' ')[1] + " - " + tbInvoiceQuantity.Text + " " + lInvoiceMeasureUnit.Text);
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void bInvoiceAdd_Click(object sender, EventArgs e)
        {
            DatabaseRepository.addInvoice(currentInvoicePersonID, tbInvoiceNewDate.Text, invoiceNewLines);
            tbInvoiceNewDate.Text = "";
            cbInvoiceNewPerson.Text = "";
            lbInvoiceNewLines.Items.Clear();
            cbInvoiceMaterialSelect.Text = "";
            tbExistMaterialQuantity.Text = "";
            lInvoiceMeasureUnit.Text = "";
            updateForm();
        }

        private void bSqlQueryExecute_Click(object sender, EventArgs e)
        {
            if (DatabaseRepository.executeSqlQuery(rtbSqlQuery.Text))
            {
                lQueryResult.Text = "Запрос успешно выполнен";
                lQueryResult.ForeColor = Color.Green;
                updateForm();
            }
            else
            {
                lQueryResult.Text = "Ошибка выполнения запроса";
                lQueryResult.ForeColor = Color.Red;
            }
        }

        private void rtbSqlQuery_KeyPress(object sender, KeyPressEventArgs e)
        {
            lQueryResult.Text = "";
        }

        private void bInvoiceClear_Click(object sender, EventArgs e)
        {
            tbInvoiceNewDate.Text = "";
            cbInvoiceNewPerson.Text = "";
            lbInvoiceNewLines.Items.Clear();
            cbInvoiceMaterialSelect.Text = "";
            tbExistMaterialQuantity.Text = "";
            lInvoiceMeasureUnit.Text = "";
        }

        private void lInvoiceMeasureUnit_Click(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            rtbSqlQuery.Text = "";
            lQueryResult.Text = "";
        }
    }
}
