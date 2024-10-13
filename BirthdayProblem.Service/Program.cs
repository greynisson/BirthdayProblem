namespace BirthdayProblem.Service;

class Program
{
    static void Main(string[] args)
    {
        var today = DateTime.Today;
        var birthdayService = new BirthdayService(today);

        List<Person> persons = PersonCsvAdapter.GetPersonsFromCsv(args[0]);

        foreach (Person p in persons)
        {
            if (birthdayService.IsBirthdayToday(p.DateOfBirth))
            {
                Console.WriteLine($"Happy Birthday, {p.Name}!");
            }
        }
    }
}
