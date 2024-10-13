namespace BirthdayProblem.Service;

public class BirthdayService
{
    private readonly DateTime _today;

    public BirthdayService(DateTime today)
    {
        _today = today;
    }

    public bool IsBirthdayToday(DateTime birthday)
    {
        return birthday.Month == _today.Month && birthday.Day == _today.Day;
    }
}
