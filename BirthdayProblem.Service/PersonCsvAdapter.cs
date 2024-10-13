using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;

namespace BirthdayProblem.Service;

public class PersonCsvAdapter : ClassMap<Person>
{
    public PersonCsvAdapter()
    {
        Map(x => x.Name).Name("Name");
        Map(x => x.DateOfBirth).Name("DateOfBirth").TypeConverterOption.Format("yyyy-MM-dd");
    }

    public static List<Person> GetPersonsFromCsv(string filePath)
    {
        using var reader = new StreamReader(filePath);
        using var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = true });
        csv.Context.RegisterClassMap<PersonCsvAdapter>();

        return csv.GetRecords<Person>().ToList();
    }
}
