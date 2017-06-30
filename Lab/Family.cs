using System.Collections.Generic;
using System.Linq;

class Family
{
    protected List<Person> members;

    public Family()
    {
        members = new List<Person>();
    }

    public void AddMember(Person person)
    {
        members.Add(person);
    }

    public Person GetOldestMember()
    {
        int oldesAge = members.Select(p => p.age).Max();

        return members.FirstOrDefault(p => p.age == oldesAge);
    }

}
