﻿namespace BrailleTestApp.Models
{
    public class Braille
    {
        public int Id { get; set; }
        public string Shape { get; set; }
        public string Pattern { get; set; }

        public Braille()
        {


        }

    }
    public class FAQViewModel
    {
        public List<FAQItem> Questions { get; set; }
    }

    public class FAQItem
    {
        public string Title { get; set; }
        public string Answer { get; set; }
    }

}
