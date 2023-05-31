namespace Домашка_от_28._04_3;

public class Enrollee
{
    public string SecondName { get; }
    public int AdmissionYear { get; }
    public int SchoolNumber { get; }
    public Enrollee(string secondName, int admissionYear, int schoolNumber)
    {
        SecondName = secondName;
        AdmissionYear = admissionYear;
        SchoolNumber = schoolNumber;
    }
}