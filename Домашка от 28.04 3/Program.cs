

// Исходная последовательность содержит сведения об абитуриентах. Каждый элемент
// последовательности включает следующие поля:
// <Фамилия> <Год поступления> <Номер школы>
// Для каждой школы вывести общее число абитуриентов за все годы и фамилию первого из абитуриентов
// этой школы, содержащихся в исходном наборе данных (вначале указывать номер школы, затем число
// абитуриентов, затем фамилию). Сведения о каждой школе выводить на новой строке и упорядочивать
// по возрастанию номеров школ.

using Домашка_от_28._04_3;

public class Program
{
    static void Main()
    {
        #region Абитура
        var enrolle1  = new Enrollee("Yankov", 1999, 1503);
        var enrolle2  = new Enrollee("Kirillov", 2004, 1099);
        var enrolle3  = new Enrollee("Osipova", 2007, 1201);
        var enrolle4  = new Enrollee("Borodkin", 2007, 1201);
        var enrolle5  = new Enrollee("Chukareva", 2007, 1709);
        var enrolle6  = new Enrollee("Nikitin", 1998, 1503);
        var enrolle7  = new Enrollee("Paputin", 2010, 1099);
        var enrolle8  = new Enrollee("Lupin", 2011, 1201);
        var enrolle9  = new Enrollee("Mamaeva", 2011, 1201);
        var enrolle10 = new Enrollee("Romanova", 2011, 1709);
        var enrolle11 = new Enrollee("Shushkova", 2013, 1503);
        var enrolle12 = new Enrollee("Romanova", 2004, 1709);
        var enrolle13 = new Enrollee("Kuprin", 2005, 1709);
        var enrolle14 = new Enrollee("Lolaeva", 1997, 1201);
        var enrolle15 = new Enrollee("Rakhovskyi", 2011, 1503);
        var enrolle16 = new Enrollee("Khokhlov", 2011, 1201);
        var enrolle17 = new Enrollee("Buninskyi", 1997, 1201);
        var enrolle18 = new Enrollee("Lapin", 2005, 1503);
        var enrolle19 = new Enrollee("Ivanov", 2002, 1709);
        var enrolle20 = new Enrollee("Riamin", 1997, 1503);
        var enrolle21 = new Enrollee("Chtchtyan", 2011, 1709);
        var enrolle22 = new Enrollee("Lyashin", 2002, 1709);
        var enrolle23 = new Enrollee("Li", 2000, 1099);
        var enrolle24 = new Enrollee("Noskova", 2009, 1099);
        #endregion
        
        var Enrollees = 
            new List<Enrollee>()
            { 
                enrolle1, enrolle2, enrolle3, enrolle4, 
                enrolle5, enrolle6, enrolle7, enrolle8, enrolle9, enrolle10,
                enrolle11, enrolle12, enrolle13, enrolle14, enrolle15, enrolle16, 
                enrolle17, enrolle18, enrolle19, enrolle20, enrolle21, enrolle22,
                enrolle23, enrolle24
            }.ToArray();
        
        //впервые используется анонимный тип 
        var schoolGrouping = Enrollees
            .GroupBy(e => e.SchoolNumber)
            .Select(e => new
            {
                school = e.Key, 
                count = e.Count(), 
                first = e.First()
            })
            .OrderBy(s => s.school);

        foreach (var school in schoolGrouping)
        {
            Console.WriteLine($"school number {school.school}, " +
                              $"amount of enrollees {school.count}, " +
                              $"first enrollee {school.first.SecondName}");
        }

    }
}