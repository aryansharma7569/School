namespace SchoolWebsite.Entity
{
    public class School
    {
        public int Id { get; set; }
        public string SchoolName { get; set; }
        public string SchoolAddress { get; set; }
        public int TotalClasses { get; set; }
        public int TotalTeachers { get; set; }
        public int CapacityOfStudents { get; set; }
        public string Type { get; set; }
        
    }
}
