using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel.Models
{
    public class PreviousBooking
    {
        public int Id { get; set; }
        public int PreviousClientId { get; set; }
        public Client PreviousClient { get; set; }

        
        public int PreviousRoomNumber { get; set; }
        public Room PreviousRoom { get; set; }
    }
}
