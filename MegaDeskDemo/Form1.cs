using System.Data;

namespace MegaDeskDemo
{
    public partial class MainMenu : Form
    {
        DataTable table;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addQuoteButton_Click(object sender, EventArgs e)
        {
            AddQuote addQuote = new();
            addQuote.Tag = this;
            addQuote.Show();
            Hide();
        }

        private void viewQuoteButton_Click(object sender, EventArgs e)
        {
            ViewQuotes viewQuotes = new();
            viewQuotes.Tag = this;
            viewQuotes.Show();
            Hide();
        }

        private void searchQuoteButton_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotes = new();
            searchQuotes.Tag = this;
            searchQuotes.Show();
            Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            table = new();
            DataColumn orderIdColumn = table.Columns.Add("orderID", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Date", typeof(string));
            table.Columns.Add("Desk", typeof(Desk));
            table.Columns.Add("Price", typeof(int));
            table.PrimaryKey = new DataColumn[] { orderIdColumn };
        }

        public void AddDataRow(string name, string date, int width, int depth, int drawers, string material, int shipping, int price, bool display)
        {
            int newID = table.Rows.Count;
            Desk newDesk = new(width, depth, drawers, material, shipping);
            table.Rows.Add(newID, name, date, newDesk, price);
            if (display) { DisplayDataRow(newID); }
        }

        public void DisplayDataRow(int id)
        {
            DataRow? row = table.Rows.Find(id);
            if (row != null)
            {
                DisplayQuote displayQuote = new();
                displayQuote.Tag = this;
                Desk desk = (Desk)row["Desk"];
                displayQuote.SetLabels(
                    (string)row["Name"], (string)row["Date"],
                    desk.width, desk.depth, desk.drawers, desk.material, desk.shipping
                );
                displayQuote.Show();
            }
        }
    }
    public class Desk
    {
        public int width, depth, drawers, shipping;
        public string? material;
        
        public Desk(int width, int depth, int drawers, string material, int shipping)
        {
            this.width = width; this.depth = depth; this.drawers = drawers; this.shipping = shipping;
            this.material = material;
        }
    }
}
