using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDeskDemo
{
    public partial class AddQuote : Form
    {
        public int width = 0;
        public AddQuote()
        {
            InitializeComponent();
        }

        private void return_to_main()
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void GoBack(object sender, EventArgs e)
        {
            return_to_main();
        }

        private void Validate_Form()
        {
            if ((!int.TryParse(widthInput.Text, out int width) || width < 24 || width > 96) ||
                (!int.TryParse(depthInput.Text, out int depth) || depth < 12 || depth > 48) ||
                (string.IsNullOrEmpty(drawerInput.Text) || string.IsNullOrEmpty(materialInput.Text) || string.IsNullOrEmpty(shippingInput.Text)))
            {
                addButton.Enabled = false;
            }
            else { addButton.Enabled = true; }
            dateLabel.Text = DateTime.Now.ToShortDateString();
        }

        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                errorProvider2.SetError(nameTextBox, "Must input a name.");
            }
            else { errorProvider2.SetError(nameTextBox, ""); }
            Validate_Form();

        }

        private void widthInputLeave(object sender, EventArgs e)
        {
            if (!int.TryParse(widthInput.Text, out int width) || width < 24 || width > 96)
            {
                errorProvider1.SetError(widthInput, "Please enter a number between 24 and 96.");
            }
            else { errorProvider1.SetError(widthInput, ""); }
            Validate_Form();
        }

        private void depthInput_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(depthInput.Text, out int depth) || depth < 12 || depth > 48)
            {
                errorProvider1.SetError(depthInput, "Please enter a number between 12 and 48.");
            }
            else { errorProvider1.SetError(depthInput, ""); }
            Validate_Form();
        }

        private void drawerInput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(drawerInput.Text))
            {
                errorProvider2.SetError(drawerInput, "Must select a value.");
            }
            else { errorProvider2.SetError(drawerInput, ""); }
            Validate_Form();
        }

        private void materialInput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(materialInput.Text))
            {
                errorProvider2.SetError(materialInput, "Must select a value.");
            }
            else { errorProvider2.SetError(materialInput, ""); }
            Validate_Form();
        }

        private void shippingInput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(shippingInput.Text))
            {
                errorProvider2.SetError(shippingInput, "Must select a value.");
            }
            else { errorProvider2.SetError(shippingInput, ""); }
            Validate_Form();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            Validate_Form();
            dateLabel.Text = DateTime.Now.ToShortDateString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Validate_Form();
            if (addButton.Enabled)
            {
                var mainMenu = (MainMenu)Tag;
                int width = int.Parse(widthInput.Text); int depth = int.Parse(depthInput.Text);
                int drawers = int.Parse(drawerInput.Text); int deliveryTime = int.Parse(shippingInput.Text);
                mainMenu.AddDataRow(nameTextBox.Text, DateTime.Now.ToShortDateString(), width, depth, drawers, materialInput.Text, deliveryTime, 0, true);
                Close();
            }
        }
    }
}
