using System;
using System.Collections.Generic;
using System.Text;

namespace Tournament_Assignment
{
    class Team
    {
        string teamname;
        List<Participant> members = new List<Participant>();

        public void setName(string s)
        {
            this.teamname = s;
        }

        public string getName()
        {
            return teamname;
        }
        public void addParticipant(Participant p)
        {
            if(members.Count >= 5)
            {
                Console.WriteLine("Team is already full");
            }
            else
            {
                members.Add(p);
            }


        }

        public void printTeam()
        {
            Console.WriteLine(" A team calld" + teamname);
            Console.WriteLine("It has the following members:");
            for (int i=0; i<members.Count; i++)
            {
                members[i].printParticipant();
            }
        }
    }
}
