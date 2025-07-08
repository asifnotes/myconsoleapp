using MyConsoleApp.Models;
using MyConsoleApp.Services;
using MyConsoleApp.Helpers;

class Index
{
    static void Main(string[] args)
    {
        IStudentService service = new StudentService();
        var students = service.GetAllStudents();
        PrintHelper.PrintStudents(students);
    }
}