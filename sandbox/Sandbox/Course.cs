using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

class Course
{
    public string _courseCode;
    public string _courseName;
    public int _creditHours;
    public string _color;

    //methods
    public void Display() {
        Console.WriteLine($"{_courseCode} {_courseName} {_creditHours} {_color}");
    }
}