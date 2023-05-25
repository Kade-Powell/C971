using System;
namespace C971.Models
{
    public class Term
    {
        public string Title;
        public DateTime StartDate;
        public DateTime EndDate;

        public Term(string Title, DateTime StartDate, DateTime EndDate)
        {
            this.Title = Title;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
        }
    }
}

