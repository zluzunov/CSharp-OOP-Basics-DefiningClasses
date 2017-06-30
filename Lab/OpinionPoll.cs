using System.Collections.Generic;
using System.Linq;

class OpinionPoll: Family
{
    public Person[] GetPersonsOlderThan(int age)
    {
        var filtered = familyMembers
            .Where(p => p.age > age)
            .OrderBy(p => p.name)
            .ToArray();

        return filtered;
    }
}
