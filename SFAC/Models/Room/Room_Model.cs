namespace SFAC.Models.Room
{
    public class Room_Model
    {
        public Guid id { get; set; } = Guid.NewGuid();
        public bool IsUsed { get; set; } = false;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime Removal_Time { get; set; } = DateTime.Now.AddHours(4);


    }
}
