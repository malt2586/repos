using System;
using System.Collections.Generic;

namespace Entities
{
    public class Group
    {
        //FIELDS
        private string name;
        private Scout leader;
        private List<Scout> members;
        private ushort totalMarks;

        //CONSTRUCTORS
        public Group(string name, Scout leader, List<Scout> members)
        {
            this.name = name;
            this.leader = leader;
            this.members = members;
            members.ForEach(x => TotalMarks += x.Marks);
            TotalMarks += this.leader.Marks;
        }

        //PROPERTIES
        public string Name { get { return name; } set { name = value; } }
        public ushort TotalMarks { get { return totalMarks; } set { totalMarks = value; } }
        public Scout Leader { get { return leader; } set { leader = value; } }
        public List<Scout> Members { get {return members; } set {members = value; } }

        //METHODS
        public void AddScout(Scout scoutToAdd)
        {
            Members.Add(scoutToAdd);
        }

        public void RemoveScout(Scout scoutToRemove)
        {
            Members.Remove(scoutToRemove);
        }

        public Scout[] FindScoutsWith(byte marksToFind)
        {
            List<Scout> result = Members.FindAll(
                delegate (Scout scout)
                {
                    if (scout.Marks == marksToFind)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                });
            return result.ToArray();
        }

        public override string ToString()
        {
            return $"Name: {Name}, Leader: {Leader.FirstName} {Leader.LastName}, Members: {Members.Count}";
        }
    }
}