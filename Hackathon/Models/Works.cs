﻿namespace Hackathon.Models
{
    public class Works
    {
        public int Id { get; set; }
        public string Details { get; set; }
        public virtual Status Status { get; set; }
        public int StatusId { get; set; }
        public virtual Pins Pin { get; set; }
        public int PinId { get; set; }
        public virtual Departments Department { get; set; }
        public int DepartmentId { get; set; }
    }
}
