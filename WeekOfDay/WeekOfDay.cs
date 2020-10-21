using System;
using System.Windows.Forms;

namespace WeekOfDay
{
    public partial class weekOfDay : Form
    {
        public weekOfDay()
        {
            InitializeComponent();
        }

        private void txtInputMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtInputDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void txtInputYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblOutputDayOfWeek.Text = "";
            numMonth.Minimum = 1;
            numMonth.Maximum = 12;
            numMonth.Increment = 1; 
            numMonth.TextAlign = HorizontalAlignment.Right;
            numDay.Minimum = 1;
            numDay.Maximum = 31;
            numDay.Increment = 1;
            numDay.TextAlign = HorizontalAlignment.Right;
        }

        private void btnCalculation_Click(object sender, EventArgs e)
        {
            string year = txtInputYear.Text;
            string month = txtInputMonth.Text;
            string day = txtInputDay.Text;
            Judge judge = new Judge();
            string endOfweek = judge.EndofWeekChecker(year, month, day);
            lblOutputDayOfWeek.Text = endOfweek;

        }

        
    }
}
