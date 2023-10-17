namespace Soulfix.Models
{
    public class EventModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public CategoryModel? Category { get; set; }
        public DateTime? Date { get; set; }
        public int? UserOwner { get; set; }
        public string? IdClientes { get; set; }
        public int Beens { get; set; }




    }




}
