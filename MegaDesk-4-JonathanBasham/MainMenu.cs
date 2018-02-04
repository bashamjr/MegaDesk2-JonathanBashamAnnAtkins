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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void openAddQuote_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }

        private void openViewAllQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotesForm = new ViewAllQuotes();
            viewAllQuotesForm.Tag = this;
            viewAllQuotesForm.Show(this);
            Hide();
        }

        private void openSearchQuote_Click(object sender, EventArgs e)
        {
            SearchQuotes viewSearchQuotesForm = new SearchQuotes();
            viewSearchQuotesForm.Tag = this;
            viewSearchQuotesForm.Show(this);
            Hide();
        }

        private void openExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
