using System;
using MarbleTecMobile.Base;

namespace MarbleTecMobile.Implementation.ViewModel
{
    public class ClockViewModel : ProjectBaseViewModel
    {
        public DateTime FullDate { get; set; }
        public string Hour 
        { 
            get { return FullDate.Hour.ToString(); }
        }
        public string Minute
        {
            get { return FullDate.Minute.ToString(); }
        }
        public string Second
        {
            get { return FullDate.Second.ToString(); }
        }
    }
}