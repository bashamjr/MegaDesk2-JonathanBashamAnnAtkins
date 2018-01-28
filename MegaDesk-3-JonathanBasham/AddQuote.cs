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

namespace MegaDesk_3_JonathanBasham
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void cancelQuoteButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void addDisplayQuoteButton_Click(object sender, EventArgs e)
        {
            DisplayQuote addNewDisplayQuoteForm = new DisplayQuote();
            addNewDisplayQuoteForm.Tag = this;
            addNewDisplayQuoteForm.Show(this);
            Hide();
        }

        private void width_TextChanged(object sender, EventArgs e)
        {
            
   
        }

        private void validWidth_TextChanged(object sender, EventArgs e)
        {
            Regex r = new Regex("^[a-zA-Z]*$");
            if (r.IsMatch(validWidth.Text))
            {
                errorMessage.ForeColor = Color.Red;
                errorMessage.Text = "Must enter a number";
            }
            else
            {
                int validateWidth = int.Parse(validWidth.Text);
                if (validateWidth < 24 || validateWidth > 96)
                {
                    errorMessage.ForeColor = Color.Red;
                    errorMessage.Text = "Width must be between 24 and 96.";
                }
                else
                {
                    errorMessage.Text = "";
                }
            }
        }



        private void depth_KeyPress(object sender, KeyPressEventArgs e)
        {
            int i;
            if (!int.TryParse(e.KeyChar.ToString(), out i))
            {
                errorMessage.ForeColor = Color.Red;
                errorMessage.Text = "Please enter a number.";
            }
            else
            {
                errorMessage.Text = "";
            }
        }
    }
}
