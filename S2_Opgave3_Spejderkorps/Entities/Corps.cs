using System;
using System.Collections.Generic;

namespace Entities
{
    public class Corps
    {
        private Scout captain;
        private List<Group> groups;
        private int totalMarks;

        public Corps(Scout captain, List<Group> groups)
        {
            this.captain = captain;
            this.groups = groups;
            groups.ForEach(x => TotalMarks += x.TotalMarks);
            TotalMarks += this.captain.Marks;
        }

        public Scout Captain { get => captain; set => captain = value; }
        public List<Group> Groups { get => groups; set => groups = value; }
        public int TotalMarks { get => totalMarks; set => totalMarks = value; }

        public void AddGroup(Group groupToAdd)
        {
            Groups.Add(groupToAdd);
        }

        public void RemoveGroup(Group groupToRemove)
        {
            Groups.Remove(groupToRemove);
        }

        public Scout[] FindScoutsWith(byte marksToFind)
        {
            List<Scout> result = new List<Scout>();
            Groups.ForEach(x => result.AddRange(x.FindScoutsWith(marksToFind)));
            return result.ToArray();
        }

        public override string ToString()
        {
            return $"Captain: {Captain.FirstName} {Captain.LastName}, Groups: {Groups.Count}, Marks: {TotalMarks}";
        }
    }
}