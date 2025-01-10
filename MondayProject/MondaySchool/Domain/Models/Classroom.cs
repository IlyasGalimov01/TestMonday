namespace Domain.Models
{
    public class Classroom
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
    }
}