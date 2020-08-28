﻿using System;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Team myTeam = new Team();
            int luckValue = new Random().Next(-10, 11);
            int difficultyLevel = 100 + luckValue;

            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine(" 1) Add a Team Member");
                Console.WriteLine(" 2) Print out Team Members");
                Console.WriteLine(" 3) Skill Level");
                Console.WriteLine(" 4) Exit");
                Console.WriteLine();
                Console.Write("> ");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("Plan Your Heist!");
                        // Console.WriteLine("Enter team name");
                        // string teamName = Console.ReadLine();
                        Console.WriteLine("Enter team member's name");
                        string name = Console.ReadLine();
                        if (name == "")
                        {
                            myTeam.SumOfMembers();
                            myTeam.ListTeamMembers();

                            // return;

                        }
                        Console.WriteLine("Enter team member's skill level");
                        string skillLevel = Console.ReadLine();
                        Console.WriteLine("Enter team member's courage factor");
                        string courageFactor = Console.ReadLine();

                        TeamMember aNewTeamMember = new TeamMember(name, skillLevel, courageFactor);
                        myTeam.addTeamMember(aNewTeamMember);
                        break;
                    case "2":
                        myTeam.ListTeamMembers();
                        break;
                    case "3":
                        //if skillLevelSum is greater than difficulty level will be successful, otherwise will fail;
                        int skillLevelSum = myTeam.SumSkillLevel();
                        Console.WriteLine($"Team's Skill Level: {skillLevelSum}");
                        Console.WriteLine($"Bank's difficulty Level: {difficultyLevel}");
                        if (skillLevelSum >= difficultyLevel)
                        {
                            Console.WriteLine("You will succeed in your heist!");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, you will fail");
                        }
                        break;
                    case "4":
                        return;
                    default:
                        // if the "choice" variable didn't match any "case" we inform the user that they
                        //  didn't choose a valid option
                        Console.WriteLine("Invalid Menu Option. You should know better.");
                        break;
                }

            }
        }
    }
}