namespace Task5
{
    internal sealed class Program
    {
        private static void Main()
        {
            var studentController = new StudentController(new Student() { Name = "Name", RollNo = "15" }, new StudentView());
            studentController.UpdateView();
            studentController.Name = "John";
            studentController.UpdateView();
        }
    }
}
