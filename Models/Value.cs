namespace ADMIN.Desktop.netcoreangular6.BT1.Models
{
    public class Value
    {
        public Value(int id, int name)
        {
            this.Id = id;
            this.Name = name;

        }
        public int Id { get; set; }

        public int Name { get; set; }
    }
}