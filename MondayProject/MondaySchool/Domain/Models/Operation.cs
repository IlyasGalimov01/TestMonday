using System;

namespace Domain.Models
{
    public class Operation
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public DateTime DateOfCreate { get; set; }
        
        public int OperationTypeId { get; set; }
        public OperationType? OperationType { get; set; }
        
        public int? GroupId { get; set; }
        public Group? Group { get; set; }
        
        public int? ClassroomId { get; set; }
        public Classroom? Classroom { get; set; }
        
        public int? StudentId { get; set; }
        public Student? Student { get; set; }
    }
}