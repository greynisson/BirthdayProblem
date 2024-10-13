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
        bool isLeapyearBirthday = CheckLeapyearBirthday(birthday);

        if (isLeapyearBirthday)
        {
            bool isFebruaryLastDay = CheckFebruaryLastDay();

            return isFebruaryLastDay;
        }

        return birthday.Month == _today.Month && birthday.Day == _today.Day;
    }

    private bool CheckLeapyearBirthday(DateTime birthday)
    {
        return birthday.Month == 2 && birthday.Day == 29;
    }

    private bool CheckFebruaryLastDay()
    {
        return _today.Month < _today.AddDays(1).Month;
    }
}
