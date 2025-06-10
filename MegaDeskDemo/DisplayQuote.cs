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
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();
        }

        public void SetLabels(string name, string date, int width, int depth, int drawers, string material, int deliveryDays)
        {
            nameLabel.Text = name;
            dateLabel.Text = date;
            widthLabel.Text = width.ToString();
            depthLabel.Text = depth.ToString();
            drawerLabel.Text = (drawers != 1) ? drawers.ToString() + " drawers" : drawers.ToString() + " drawer";
            areaLabel.Text = $"{width * depth} in^2";
            materialLabel.Text = material;
            deliveryLabel.Text = deliveryDays.ToString() + " days";
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
    }
}
