
using System;

namespace Tournament_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Participant p = new Participant();
            p.setName(" Jay ");

            Participant a = new Participant();
            p.setName(" Ross ");

            Team t = new Team();
            t.setName("Team 1");
            t.addParticipant(p);
            t.addParticipant(a);
            t.printTeam();

            Tournament tm = new Tournament();
            tm.addTeam(t);
            tm.addParticipant(p);

        }
    }      
}
