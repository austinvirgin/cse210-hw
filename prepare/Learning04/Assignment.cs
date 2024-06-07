using System.Security.Cryptography.X509Certificates;

class Assignment
{
    private string _studentName;
    private string _topic;
    protected void SetStudentNameandTopic(string studentName, string topic){
        _studentName = studentName;
        _topic = topic;
    }
    public string GetSummary(){
        return $"{_studentName} - {_topic}";
    }
}