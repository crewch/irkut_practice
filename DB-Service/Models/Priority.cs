﻿namespace DB_Service.Models
{
    public class Priority: BaseEntity
    {
        public string Title { get; set; } = String.Empty;
        public int Value { get; set; }
        public ICollection<Process> Processes { get; set; } = new List<Process>();
    }
}
