using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiary
{
    public enum DayMark
    {
        Unknown ,Awful, Bad, Good, Happiness
    }


    public class Note
    {
        private DateTime TimeOfCreation { get; set; }
        public string Text { get; set; }
        public DayMark Mark { get; set; }

        public Note() { }
        // Всі дані
        public Note(string text, DayMark mark)
        {
            Text = text;
            TimeOfCreation = DateTime.Now;
            Mark = mark;
        }
        //Текст і час створення
        public Note(string text)
        {
            Text = text;
            TimeOfCreation = DateTime.Now;
        }
    }
}
