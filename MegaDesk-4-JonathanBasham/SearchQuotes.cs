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

            StreamReader sr = new StreamReader(path);
            string fileContent = sr.ReadToEnd();
            string[] fileItems = fileContent.Split(',');
            sr.Dispose();

            ListViewItem lv = new ListViewItem();
            lv.Text = fileItems[0].ToString();
            lv.SubItems.Add(fileItems[1].ToString());
            lv.SubItems.Add(fileItems[2].ToString());
            lv.SubItems.Add(fileItems[3].ToString());
            lv.SubItems.Add(fileItems[4].ToString());
            lv.SubItems.Add(fileItems[5].ToString());
            lv.SubItems.Add(fileItems[6].ToString());
            lv.SubItems.Add(fileItems[7].ToString());
            listView.Items.Add(lv);

        }

        private string path = @"C:\Users\Jonathan.Basham\source\repos\MegaDesk-4-JonathanBasham\MegaDesk-4-JonathanBasham\bin\Debug\quotes.txt";
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
               
                SurfaceMaterial = surfMaterialComboBox.SelectedItem.ToString();
                listView.Sort();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Check input values");
            }
        }
    }
}
