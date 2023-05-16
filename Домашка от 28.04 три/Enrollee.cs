namespace Домашка_от_28._04_три;

public class Enrollee
{
    public string SecondName { get; set; }
    public int AdmissionYear { get; set; }
    public int SchoolNumber { get; set; }
    public Enrollee(string secondName, int admissionYear, int schoolNumber)
    {
        SecondName = secondName;
        AdmissionYear = admissionYear;
        SchoolNumber = schoolNumber;
    }
}