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
    public partial class frmCars : Form
    {
        public frmCars()
        {
            InitializeComponent();
        }

        private void tblCarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblCarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void frmCars_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.TblCar' table. You can move, or remove it, as needed.
            this.tblCarTableAdapter.Fill(this.database1DataSet.TblCar);
            toolTip1.SetToolTip(this.AddBtn, "Add a new form");
        }

        private void vehicleRegNoLabel_Click(object sender, EventArgs e)
        {

        }

        private void rentalPerDayLabel_Click(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are quiting the program");
            Application.Exit();
        }

        private void FirstBtn_Click(object sender, EventArgs e)
        {
            bindingNavigatorMoveFirstItem.PerformClick();
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            bindingNavigatorMovePreviousItem.PerformClick();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            bindingNavigatorMoveNextItem.PerformClick();
        }

        private void LastBtn_Click(object sender, EventArgs e)
        {
            bindingNavigatorMoveLastItem.PerformClick();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bindingNavigatorAddNewItem.PerformClick();
            }
            catch (Exception)
            {
                MessageBox.Show("You have clicked the wrong button.Please click the previous button to save.");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem.PerformClick();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
           
            try
            {
                tblCarBindingNavigatorSaveItem.PerformClick();
            }
            catch
            {
                MessageBox.Show(e.ToString(), " Check input");
            }

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            frmSearch f2 = new frmSearch(); 
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            vehicleRegNoTextBox.Text = "";

            makeTextBox.Text = "";

            engineSizeTextBox.Text = "";

            rentalPerDayTextBox.Text = "";

            this.tblCarTableAdapter.Fill(this.database1DataSet.TblCar);

        }

        private void engineSizeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
