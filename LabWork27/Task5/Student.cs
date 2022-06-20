namespace Task5
{
    public sealed class Student
    {
        private string _rollNo;
        private string _name;

        public string RollNo
        {
            get => _rollNo;
            set => _rollNo = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }
}
