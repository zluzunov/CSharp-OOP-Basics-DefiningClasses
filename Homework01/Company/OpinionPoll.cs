using System.Collections.Generic;
using System.Linq;
using Homework01.Company;

class OpinionPoll: Family
{
    public Person[] GetPersonsOlderThan(int age)
    {
        var filtered = members
            .Where(p => p.age > age)
            .OrderBy(p => p.name)
            .ToArray();

        return filtered;
    }
}
