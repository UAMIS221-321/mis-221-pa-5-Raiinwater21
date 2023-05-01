namespace mis_221_pa_5_Raiinwater21
{
    public class Booking
    {
        public string BookingViewAvailableSessions;
        public string BookingBookASession; 
//Session should be tracked in a transaction file
//Session should include session ID, customer name, customer email, training date, trainer ID, trainer name and status. 
        public string status;
//Status should be initially set to booked, but should be updated to completed after the session or to cancelled if the customer cancels or no shows the appointment.
//The transaction file should be named transactions.txt and should be # delimited.
        // public static string ManageBooking();
        // public void SetViewAvailableSessions(string BookingViewAvailableSessions){
        //     this.BookingViewAvailableSessions = ViewSessions;
        }
    }
