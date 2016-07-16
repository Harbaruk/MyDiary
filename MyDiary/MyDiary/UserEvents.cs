using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiary
{
    public class UserEvents
    {
        private DateTime TimeOfCreation { get; set; }
        public string Text { get; set; }
        public DayMark Mark { get; set; }
        public bool NeedToNotify { get; set; }

        public UserEvents() { }
        //Всі дані
        public UserEvents(string text, DayMark mark, bool needToNotify, DateTime timeOfCreation)
        {
            Text = text;
            TimeOfCreation = timeOfCreation;
            Mark = mark;
            NeedToNotify = needToNotify;
        }

    }

}
