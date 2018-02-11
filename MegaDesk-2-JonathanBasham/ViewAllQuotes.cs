using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MegaDesk_4_JonathanBasham
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();

             var quotes = new List<Desk.DeskObject>();

             var serializer = new JsonSerializer();
             using (var reader = new StreamReader(@"quotes.json"))
             using (var jsonReader = new JsonTextReader(reader))
             {
                   quotes = serializer.Deserialize<List<Desk.DeskObject>>(jsonReader);
             }
            int counterRow = 0;
            int counterCell = 0;
            foreach (var quote in quotes)
            {
                    string dateQuote = quote.CurrentDate;
                    string customerName = quote.CustomerName;
                    int width = quote.Width;
                    int depth = quote.Depth;
                    int drawers = quote.numOfDrawers;
                    string material = quote.surfMaterial;
                    int rushOrderDays = quote.RushOrderDays;
                    int totalQuote = quote.TotalQuote;
                    dgvAllQuotes.Rows.Add();
                    
                    dgvAllQuotes.Rows[counterRow].Cells[counterCell].Value = dateQuote;
                    counterCell++;

                    dgvAllQuotes.Rows[counterRow].Cells[counterCell].Value = customerName;
                    counterCell++;

                    dgvAllQuotes.Rows[counterRow].Cells[counterCell].Value = width;
                    counterCell++;

                    dgvAllQuotes.Rows[counterRow].Cells[counterCell].Value = depth;
                    counterCell++;

                    dgvAllQuotes.Rows[counterRow].Cells[counterCell].Value = drawers;
                    counterCell++;

                    dgvAllQuotes.Rows[counterRow].Cells[counterCell].Value = material;
                    counterCell++;

                    dgvAllQuotes.Rows[counterRow].Cells[counterCell].Value = rushOrderDays;
                    counterCell++;

                    dgvAllQuotes.Rows[counterRow].Cells[counterCell].Value = totalQuote;
                    counterCell++;

                    counterRow++;
                    counterCell = 0;

            }
            
        }
        private void cancelViewAllQuotesButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }
    }
}
