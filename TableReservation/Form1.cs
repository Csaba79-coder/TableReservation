namespace TableReservation
{
    public partial class Form1 : Form
    {
        List<Reservation> reservations = new List<Reservation>();
        public Form1()
        {
            InitializeComponent();
            ReadData();
            WriteToFile();
        }

        private void ReadData()
        {
            reservations.Clear();
            StreamReader reader = new StreamReader("tablereservation.txt");
            while (!reader.EndOfStream)
            {
                Reservation reservation = new Reservation();
                reservation.NameOfGuest = reader.ReadLine();
                reservation.NumberOfGuest = Convert.ToInt32(reader.ReadLine());
                reservation.IsRegularGuest = Convert.ToBoolean(reader.ReadLine());
                reservation.ArrivalHour = Convert.ToInt32(reader.ReadLine());
                reservation.ArrivalDate = Convert.ToDateTime(reader.ReadLine());
               reservations.Add(reservation);
            }
            reader.Close();
        }

        private void WriteToFile()
        {
            lbReservation.Items.Clear();
            foreach(Reservation reservation in reservations)
            {
                lbReservation.Items.Add(reservation.NameOfGuest + " reserved for " + reservation.NumberOfGuest + " person!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbGuestName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ApplyForm applyForm = new ApplyForm();
            applyForm.ShowDialog();
            if (applyForm.DialogResult == DialogResult.OK)
            {
                ReadData();
                WriteToFile();
            }
        }

        private void lbReservation_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbRegularGuest.Checked = false;
            if (lbReservation.SelectedIndex >= 0)
            {
                tbGuestName.Text = reservations[lbReservation.SelectedIndex].NameOfGuest;
                tbNumberOfPerson.Text = reservations[lbReservation.SelectedIndex].NumberOfGuest.
                    ToString();
                tbArrivalHour.Text = reservations[lbReservation.SelectedIndex].ArrivalHour.ToString();
                tbArrivalDate.Text = reservations[lbReservation.SelectedIndex].ArrivalDate.ToString();
                bool isRegularGuest = reservations[lbReservation.SelectedIndex].IsRegularGuest;

                if (isRegularGuest)
                {
                    cbRegularGuest.Checked = true;
                }
                else
                {
                    cbRegularGuest.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("No selected guest");
            }
        }
    }
}