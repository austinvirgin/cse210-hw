class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;
    public MathAssignment(string textbookSection, string problems, string studentName, string topic){
        _textbookSection = textbookSection;
        _problems = problems;
        SetStudentNameandTopic(studentName, topic);
    }
    public string GetHomeworkList(){
        return $"{_textbookSection} {_problems}";
    }
}