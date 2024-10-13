namespace BirthdayProblem.Tests;

using BirthdayProblem.Service;

public class PersonCsvAdapterTests
{
    [Fact]
    [Trait("Category", "Unit")]
    public void GetPersonsFromCsv_TestCsv_ReturnsPersonList()
    {
        // Arrange
        string fileName = "test.csv";
        string name1Expected = "John Doe";
        var dateOfBirth1Expected = DateTime.Parse("1999-01-14");
        string name2Expected = "Jane Doe";
        var dateOfBirth2Expected = DateTime.Parse("2006-12-15");

        // Act
        List<Person> result = PersonCsvAdapter.GetPersonsFromCsv(fileName);

        // Assert
        Assert.True(result.Count == 2);
        Assert.Equal(name1Expected, result[0].Name);
        Assert.Equal(dateOfBirth1Expected, result[0].DateOfBirth);
        Assert.Equal(name2Expected, result[1].Name);
        Assert.Equal(dateOfBirth2Expected, result[1].DateOfBirth);
    }
}
