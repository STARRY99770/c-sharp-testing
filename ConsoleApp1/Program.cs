
using System;
using System.Collections.Generic;

namespace UniversitySystem
{
    // Base class UniversityMember (Question 1)
    public class UniversityMember
    {
        // Properties
        public string MemberID { get; set; }
        public string Name { get; set; }

        // Constructor
        public UniversityMember(string memberID, string name)
        {
            MemberID = memberID;
            Name = name;
        }

        // Virtual method for polymorphism
        public virtual string GetDetails()
        {
            return $"ID: {MemberID}, Name: {Name}";
        }
    }

    // Derived class Student (Question 2)
    public class Student : UniversityMember
    {
        // Additional property
        public string GroupName { get; set; }

        // Constructor
        public Student(string groupName, string name, string memberID)
            : base(memberID, name)
        {
            GroupName = groupName;
        }

        // Override GetDetails method
        public override string GetDetails()
        {
            return $"Student - Group: {GroupName}, Name: {Name}, ID: {MemberID}";
        }
    }

    // Derived class Lecturer (Question 2)
    public class Lecturer : UniversityMember
    {
        // Additional properties
        public string Department { get; set; }
        public string Designation { get; set; }

        // Constructor
        public Lecturer(string memberID, string name, string department, string designation)
            : base(memberID, name)
        {
            Department = department;
            Designation = designation;
        }

        // Override GetDetails method
        public override string GetDetails()
        {
            return $"Lecturer - {base.GetDetails()}, Department: {Department}, Designation: {Designation}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Question 3: Demonstrating polymorphism
            
            // Create a collection of UniversityMember objects
            List<UniversityMember> members = new List<UniversityMember>();
            
            // Add Student instances (you would add your actual group members here)
            members.Add(new Student("THE CODEX", "ANGELA NGUI", "BCS24090021"));
            members.Add(new Student("THE CODEX", "ANGELA NGUI", "BCS24090021"));
            members.Add(new Student("THE CODEX", "ANGELA NGUI", "BCS24090021"));
            
            // Add a Lecturer instance
            members.Add(new Lecturer("L001", "Alan Ting", "Computer Science", "Professor"));
            
            // Iterate through the collection and print details
            Console.WriteLine("=== University Members Details ===");
            foreach (var member in members)
            {
                // Polymorphism in action - correct overridden method is called based on actual object type
                Console.WriteLine(member.GetDetails());
            }
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}