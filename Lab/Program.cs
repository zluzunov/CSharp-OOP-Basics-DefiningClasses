using System;
using System.Collections.Generic;
using System.Reflection;

public class Program
{
    static void Main()
    {
        MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
        MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
        if (oldestMemberMethod == null || addMemberMethod == null)
        {
            throw new Exception();
        }

        OpinionPoll poll = new OpinionPoll();

        int people = int.Parse(Console.ReadLine());

        for (int i = 0; i < people; i++)
        {
            var input = Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries);
            Person person = new Person(input[0], int.Parse(input[1]));
            poll.AddMember(person);
        }

        Person[] older = poll.GetPersonsOlderThan(30);

        foreach (Person person in older)
        {
            person.Print();
        }
    }
}


