﻿using System;
using SQLite;

namespace Notes.Models
{
    public class Note
    {
        // attributes?
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}