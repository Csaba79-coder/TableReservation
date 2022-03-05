using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableReservation
{
    public partial class ApplyForm : Form
    {
        public ApplyForm()
        {
            InitializeComponent();
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbNameOfGuest.Text != "" &&
                dtbArrivalDate.Value >= DateTime.Now &&
                numArrivalHour.Value >= 10 &&
                numNumberOfGuest.Value > 0)
            {
                StreamWriter writer = new StreamWriter("tablereservation.txt", true); // true is needed!
                writer.WriteLine(tbNameOfGuest.Text);
                writer.WriteLine(numNumberOfGuest.Value);
                writer.WriteLine(cbRegularGuest.Checked);
                writer.WriteLine(numArrivalHour.Value);
                writer.WriteLine(dtbArrivalDate.Value);
                writer.Close();
                DialogResult = DialogResult.OK;
            } else
            {
                MessageBox.Show("There is no data fullfilled!");
            }
        }
    }
}
