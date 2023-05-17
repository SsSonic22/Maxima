namespace Домашка_от_28._04_3;

public class School
{
    public School(List<Enrollee> enrollees)
    {
        Enrollees = enrollees;
    }

    public List<Enrollee> Enrollees { get; }
}