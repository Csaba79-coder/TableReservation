namespace TableReservation
{
    internal class Reservation
    {
        string nameOfGuest;
        int numberOfGuest;
        DateTime arrivalDate;
        int arrivalHour;
        bool isRegularGuest;


        public string NameOfGuest
        {
            get { return nameOfGuest; }
            set { nameOfGuest = value; }
        }

        public int NumberOfGuest
        {
            get { return numberOfGuest; }
            set { numberOfGuest = value; }
        }

        public DateTime ArrivalDate
        {
            get { return arrivalDate; }
            set { arrivalDate = value; }
        }

        public int ArrivalHour
        {
            get { return arrivalHour; }
            set { arrivalHour = value; }
        }

        public bool IsRegularGuest
        {
            get { return isRegularGuest; }
            set { isRegularGuest = value; }
        }
    }
}
