namespace StudentWebAPI.Entities
{
    public class Student
    {
        public int Student_Id { get; set; }

        public string Student_Name { get; set; }

        public string Student_Email { get; set; }
        public string Mobile_Number { get; set; }
        public string Student_Address { get; set;}

        public DateTime Admission { get; set; }

        public int Fees { get; set; }
        public string Status { get; set; }
    }
}
