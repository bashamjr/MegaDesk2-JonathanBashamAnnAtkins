using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace MegaDesk_4_JonathanBasham
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            surfMaterial.DataSource = Enum.GetValues(typeof(Desk.DeskMaterials));
        }

        public int DeskWidth;
        public int DeskDepth;
        public string CustomerName;
        public int Drawers;
        public string SurfaceMaterial;
        public int RushOrderDays;
        public int DeskQuoteTotal;
        
        

        private void cancelQuoteButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            this.Close();
        }

        private void addDisplayQuoteButton_Click(object sender, EventArgs e)
        {
            try
            {
                DeskWidth = int.Parse(txtWidth.Text);
                DeskDepth = int.Parse(txtDepth.Text);
                CustomerName = customerName.Text;
                Drawers = int.Parse(txtDrawers.SelectedItem.ToString());
                SurfaceMaterial = surfMaterial.SelectedItem.ToString();
                RushOrderDays = int.Parse(rushDays.SelectedItem.ToString());

                DeskQuote newQuoteOrder = new DeskQuote(DeskWidth, DeskDepth, Drawers, SurfaceMaterial, RushOrderDays);
                DeskQuoteTotal = newQuoteOrder.CalculateQuoteTotal();

                Desk.DeskObject deskObject;
                deskObject.CustomerName = CustomerName;
                deskObject.Width = DeskWidth;
                deskObject.Depth = DeskDepth;
                deskObject.surfMaterial = SurfaceMaterial;
                deskObject.numOfDrawers = Drawers;
                deskObject.RushOrderDays = RushOrderDays;
                deskObject.TotalQuote = DeskQuoteTotal;
                deskObject.CurrentDate = DateTime.Now.ToString("dd MMM yyyy");

                if (!File.Exists(@"quotes.json"))
                {
                    using (StreamWriter sw = File.CreateText("quotes.json"))
                    {
                        sw.WriteLine("[]");
                    }
                }
                var deskObjects = new List<Desk.DeskObject>();
                var serializer = new JsonSerializer();
                using (var reader = new StreamReader(@"quotes.json"))
                using (var jsonReader = new JsonTextReader(reader))
                {
                    deskObjects = serializer.Deserialize<List<Desk.DeskObject>>(jsonReader);
                }
                deskObjects.Add(deskObject);
                using (var writer = new StreamWriter(@"quotes.json"))
                using (var jsonWriter = new JsonTextWriter(writer))
                {
                     serializer.Serialize(jsonWriter, deskObjects);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Check input values");
            }


            #region Display
            var MainMenu = (MainMenu)Tag;
            DisplayQuote newOrderView = new DisplayQuote(CustomerName, DateTime.Now, DeskWidth, DeskDepth, Drawers, SurfaceMaterial, RushOrderDays, DeskQuoteTotal) { Tag = MainMenu };
            newOrderView.Show();
            this.Close();
            #endregion

            try
            {
                string DeskRecord = DateTime.Now.Date + ", " + CustomerName + ", " + DeskWidth + ", " + DeskDepth + ", " + Drawers + ", " + SurfaceMaterial + ", " + RushOrderDays + ", " + DeskQuoteTotal;
                
                string txtFile = @"quotes.txt";
                if (!File.Exists(txtFile))
                {
                    using (StreamWriter sw = File.CreateText("quotes.txt"))
                    {
                       sw.WriteLine("Quote Date, Customer Name, Desk Width, Desk Depth, Number of Drawers, Material, Rush Order Days, Desk Quote Total");
                    }
                }
                using (StreamWriter sw = File.AppendText("quotes.txt"))
                    {
                        sw.WriteLine(DeskRecord);
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Check input values unable to write to file");
            }
        }

        private void txtWidth_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(this.txtWidth.Text, out int number))
            {
                if (number < Desk.MINWIDTH || number > Desk.MAXWIDTH)
                {
                    errorMessage.ForeColor = Color.Red;
                    errorMessage.Text = "*Please enter a width between 24 and 96";
                    txtWidth.BackColor = Color.LightPink;
                    txtWidth.Focus();     
                }
                else
                {
                    txtWidth.BackColor = Color.White;
                    errorMessage.Text = String.Empty;
                }
            }
            else
            {
                errorMessage.ForeColor = Color.Red;
                errorMessage.Text = "*Please enter valid number";
                txtWidth.BackColor = Color.LightPink;
                txtWidth.Focus();
            }
        }

        private void txtDepth_Validating(object sender, CancelEventArgs e)
        {

            if (int.TryParse(this.txtDepth.Text, out int number))
            {
                if (number < Desk.MINDEPTH || number > Desk.MAXDEPTH)
                {
                    errorMessage.ForeColor = Color.Red;
                    errorMessage.Text = "*Please enter a depth between 12 and 48";
                    txtDepth.BackColor = Color.LightPink;
                    txtDepth.Focus();
                }
                else
                {
                    txtDepth.BackColor = Color.White;
                    errorMessage.Text = String.Empty;
                }
            }
            else
            {
                errorMessage.ForeColor = Color.Red;
                errorMessage.Text = "*Please enter valid number";
                txtDepth.BackColor = Color.LightPink;
                txtDepth.Focus();
            }

        }
    }
}
