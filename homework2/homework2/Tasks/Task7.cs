using System;
using System.Collections.Generic;
using System.Text;

namespace homework2.Tasks;

public class Task7
{
    static int ParseAge(string input)
    {
        int age = int.Parse(input);

        if (age < 0 || age > 150)
        {
            throw new InvalidAgeException(age, "Возраст должен быть в диапазоне от 0 до 150 лет.");
        }

        return age;
    }
}

public class InvalidAgeException : Exception
{
    public int Age { get; }

    public InvalidAgeException(int age, string message) : base(message)
    {
        Age = age;
    }
}


