﻿namespace linq2
{
    public class Subject
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}