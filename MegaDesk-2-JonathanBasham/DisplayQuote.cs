using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_4_JonathanBasham
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(string customerName, DateTime quoteDate, int width, int depth, int numOfDrawers, string surfMaterial, int rushOrderDays, int deskQuote ) 
        {
            InitializeComponent();
            displayName.Text = customerName;
            displayDate.Text = quoteDate.ToString("dd MMM yyyy");
            displayWidth.Text = width.ToString() + " inches";
            displayDepth.Text = depth.ToString() + " inches";
            displayDrawers.Text = numOfDrawers.ToString();
            displayMaterial.Text = surfMaterial;
            displayRushOrder.Text = rushOrderDays.ToString() + " days";
            displayTotalQuote.Text = String.Format("{0:C}", deskQuote);
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            this.Close();
        }
    }
}
