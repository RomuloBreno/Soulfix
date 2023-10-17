namespace Soulfix.Metods
{
	public class MetodsCalendar : IMetodsCalendar
	{


		public DateTime EndDayMonth() { 
		
		DateTime date = DateTime.Now;
		DateTime endDayMonth = new DateTime(1, date.Month + 1, date.Year).AddMonths(-1);

			return endDayMonth;
		
		}	
	}
}
