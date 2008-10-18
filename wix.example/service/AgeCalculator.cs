using System;
using wix.example.exception;

namespace wix.example.service
{
    public class AgeCalculator
    {
        public DateTime Birthday { get;  set; }
        public DateTime ToDate { get; set; }

        public AgeCalculator(DateTime birthday)
        {
            Birthday = birthday;
        }

        public AgeCalculator(DateTime birthday, DateTime toDate) : this(birthday)
        {
            ToDate = toDate;
        }

        public int RenderAge()
        {
            if(Birthday > DateTime.Now) 
                throw new InvalidBirthdayException("Birthday can't be date greater than today");
            return (DateTime.Now - Birthday).Days / 365;
        }
    }
}