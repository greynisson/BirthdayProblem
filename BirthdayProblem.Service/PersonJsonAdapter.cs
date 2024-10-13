
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace BirthdayProblem.Service
{
    public class PersonJsonAdapter
    {
        public static List<Person> GetPersonsFromJson(string filePath)
        {
            var jsonOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            using (StreamReader file = File.OpenText(filePath))
            {
                string jsonString = file.ReadToEnd();
                var persons = JsonSerializer.Deserialize<List<Person>>(jsonString, jsonOptions) ?? new();

                return persons;
            }
        }
    }

}
