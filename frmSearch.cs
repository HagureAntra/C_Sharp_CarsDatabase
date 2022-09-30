using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsDatabase
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void tblCarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblCarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            // TO_DO: This line of code loads data into the 'database1DataSet.TblCar' table. You can move, or remove it, as needed.
            this.tblCarTableAdapter.Fill(this.database1DataSet.TblCar);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            string answer = comboBox1.SelectedItem.ToString();

            string[] stringitem = { " = " };

            string[] intitem = {" = ", " > ", " < ", " <= ", " >= "};

            if (answer.Equals ("RentalPerDay") || answer.Equals ("DateRegistered")

            ){

                comboBox2.Items.AddRange(intitem);

            }
            else
            {
                comboBox2.Items.AddRange(stringitem);
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RunBtn_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text.Trim();
            string op = comboBox2.Text.ToString();
            string field = comboBox1.Text.ToString();
            string query;

            if(string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("No Value in a Vaule field");
            
            }

            else if(comboBox2.Items.Count == 1) 
            {

                query = string.Format("{0} Like '%{1}%'", field, value);

                tblCarBindingSource.Filter = query;
           
            }

            else
            {
                if(op.Equals("="))
                {
                    query = string.Format("{0} = {1}", field, value);
                    tblCarBindingSource.Filter = query;
                }
                else if (op.Equals(">"))
                {
                    query = string.Format("{0} > {1}", field, value);
                    tblCarBindingSource.Filter = query;
                }
                else if (op.Equals("<"))
                {
                    query = string.Format("{0} < {1}", field, value);
                    tblCarBindingSource.Filter = query;
                }
                else if (op.Equals(">"))
                {
                    query = string.Format("{0} > {1}", field, value);
                    tblCarBindingSource.Filter = query;
                }

                else if (op.Equals("<="))
                {
                    query = string.Format("{0} <= {1}", field, value);
                    tblCarBindingSource.Filter = query;
                }
                else if (op.Equals(">="))
                {
                    query = string.Format("{0} >= {1}", field, value);
                    tblCarBindingSource.Filter = query;
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
