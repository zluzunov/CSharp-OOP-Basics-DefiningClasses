using System.Collections.Generic;
using System.Linq;

class Family
{
    private List<Person> familyMembers;

    public Family()
    {
        familyMembers = new List<Person>();
    }

    public void AddMember(Person person)
    {
        familyMembers.Add(person);
    }

    public Person GetOldestMember()
    {
        int oldesAge = familyMembers.Select(p => p.age).Max();

        return familyMembers.FirstOrDefault(p => p.age == oldesAge);
    }

}
