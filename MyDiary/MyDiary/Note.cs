﻿using System;
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
    }
}
