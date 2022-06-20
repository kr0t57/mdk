namespace Task5
{
    public sealed class StudentController
    {
        private Student _student;
        private StudentView _studentView;

        public StudentController(Student student, StudentView studentView)
        {
            _student = student;
            _studentView = studentView;
        }

        public string Name 
        { 
            get => _student.Name; 
            set => _student.Name = value;
        }

        public string RollNo
        {
            get => _student.RollNo;
            set => _student.RollNo = value;
        }

        public void UpdateView()
        {
            _studentView.PrintStudentDetails(_student);
        }
    }
}
