using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace MegaDesk_4_JonathanBasham
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            surfMaterial.DataSource = Enum.GetValues(typeof(Desk.DeskMaterials));
        }

        private int DeskWidth;
        private int DeskDepth;
        private string CustomerName;
        private int Drawers;
        private string SurfaceMaterial;
        private int RushOrderDays;
        private int DeskQuoteTotal;

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
                List<DeskQuote> deskOrders = new List<DeskQuote>();
                deskOrders.Add(newQuoteOrder);
               

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
                string DeskRecord = DateTime.Now.Date + ", " + CustomerName + ", " + DeskWidth + ", " + DeskDepth + ", " + Drawers + ", " + SurfaceMaterial + ", " + RushOrderDays + ", " + DeskQuoteTotal + ", ";
                
                string txtFile = @"quotes.txt";
                if (!File.Exists(txtFile))
                {
                    using (StreamWriter sw = File.CreateText("quotes.txt"))
                    {
                       // sw.WriteLine("MegaDesk Quote Orders");
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
