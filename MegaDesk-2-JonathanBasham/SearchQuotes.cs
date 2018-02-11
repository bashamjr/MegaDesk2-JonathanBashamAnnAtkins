using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace MegaDesk_4_JonathanBasham
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            surfMaterialComboBox.DataSource = Enum.GetValues(typeof(Desk.DeskMaterials));

            DataTable dt = new DataTable();
            string[] lines = File.ReadAllLines(path);
            if (lines.Length > 0)
            {
                // first line to create header
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }

                //for data

                for (int r = 1; r < lines.Length; r++)
                {
                    string[] dataWords = lines[r].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                }

            }

            if (dt.Rows.Count > 0)
            {
                dgvQuotes.DataSource = dt;
            }



        }

        private string path = @"C:\Users\Jonathan.Basham\source\repos\MegaDesk-2-JonathanBasham\MegaDesk-2-JonathanBasham\bin\Debug\quotes.txt";
        private string SurfaceMaterial;
        private void cancelSearchQuoteButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {

  
            string sortOption;
                if (dgvQuotes.Rows.Count != 0) // prevents user from sorting before datagridview is filled.
                {
                    sortOption = surfMaterialComboBox.Text;
                    
                    switch (sortOption)
                    {
                        case "Oak":
                            dgvQuotes.Sort(dgvQuotes.Columns[5],
                            ListSortDirection.Descending);
                            break;
                        case "Pine":
                            dgvQuotes.Sort(dgvQuotes.Columns[5],
                            ListSortDirection.Descending);
                            break;
                        case "Laminate":
                            dgvQuotes.Sort(dgvQuotes.Columns[5],
                            ListSortDirection.Descending);
                            break;
                        case "Rosewood":
                            dgvQuotes.Sort(dgvQuotes.Columns[5],
                            ListSortDirection.Descending);
                            break;
                        case "Veneer":
                            dgvQuotes.Sort(dgvQuotes.Columns[5],
                            ListSortDirection.Descending);
                            break;
                       default:
                            dgvQuotes.Sort(dgvQuotes.Columns[5],
                            ListSortDirection.Descending);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Check input values");
            }
        }

        private void surfMaterialComboBox_Click(object sender, EventArgs e)
        {

        }


    }
}
