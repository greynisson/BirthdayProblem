namespace BirthdayProblem.Service;

class Program
{
    static void Main(string[] args)
    {
        string filePath = args[0];

        var today = DateTime.Today;
        var birthdayService = new BirthdayService(today);

        var persons = GetPersons(filePath);

        foreach (Person p in persons)
        {
            if (birthdayService.IsBirthdayToday(p.DateOfBirth))
            {
                Console.WriteLine($"Happy Birthday, {p.Name}!");
            }
        }
    }

    private static List<Person> GetPersons(string filePath)
    {
        bool isFilePathMissing = string.IsNullOrEmpty(filePath);

        if (isFilePathMissing)
        {
            return new List<Person>();
        }

        string dataSourceType = filePath.Split('.').LastOrDefault() ?? "";

        if (dataSourceType.Equals("json", StringComparison.OrdinalIgnoreCase))
        {
            return PersonJsonAdapter.GetPersonsFromJson(filePath);
        }

        return PersonCsvAdapter.GetPersonsFromCsv(filePath);
    }
}
