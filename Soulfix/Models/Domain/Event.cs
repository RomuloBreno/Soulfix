namespace Soulfix.Models.Domain
{
    public class Event
    {
        private Guid IdEvent { get; set; }
        private string Name { get; set; }
        private string Description { get; set; }
        private Category Category { get; set; }
        private DateTime Date { get; set; }
        private Guid UserOwner { get; set; }
        private List<Guid> IdClientes { get; set; }
        private int Beens { get; set; }


        public Event(Guid idEvent, string name, string description, Category category, DateTime date, Guid userOwner, List<Guid> idClientes, int beens)
        {
            IdEvent = idEvent;
            Name = name;
            Description = description;
            Category = category;
            Date = date;
            UserOwner = userOwner;
            IdClientes = idClientes;
            Beens = beens;


        }


        public void CreateEvents(Event eventObject)
        {
            //eventObject.CreateInDataBase();
        }


        public void DeletEvent(Event eventObject)
        {
            //eventObject.CreateInDataBase();
        }

    }



}
