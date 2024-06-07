class WritingAssignment : Assignment
{
    private string _title;
    public WritingAssignment(string title, string studentName, string topic){
        _title = title;
        SetStudentNameandTopic(studentName, topic);
    }
    public string GetWritingInformation(){
        return $"{_title}";
    }
}