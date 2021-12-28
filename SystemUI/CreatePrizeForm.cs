using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemLibrary;
using SystemLibrary.DataAccess;
using SystemLibrary.Models;

namespace SystemUI
{
    public partial class CreatePrizeForm : Form
    {
        IPrizeRequestor callingForm;
        public CreatePrizeForm(IPrizeRequestor caller)
        {
            InitializeComponent();

            callingForm = caller;
        }

        private void placeNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void placeNumberValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(placeNameValue.Text, placeNumberValue.Text, prizeAmountValue.Text, prizePercentageValue.Text);

                GlobalConfig.Connection.CreatePrize(model);

                callingForm.PrizeComplete(model);

                this.Close();

                //placeNameValue.Text = "";
                //placeNumberValue.Text = "";
                //prizeAmountValue.Text = "0";
                //prizePercentageValue.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(placeNumberValue.Text, out placeNumber);


            if (placeNumberValidNumber == false)
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if(placeNameValue.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValidAmount = decimal.TryParse(prizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValidPercentage = double.TryParse(prizePercentageValue.Text, out prizePercentage);

            if(prizeAmountValidAmount == false || prizePercentageValidPercentage == false)
            {
                output = false;
            }

            if(prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if(prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }
            return output;
        }

        private void CreatePrizeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
