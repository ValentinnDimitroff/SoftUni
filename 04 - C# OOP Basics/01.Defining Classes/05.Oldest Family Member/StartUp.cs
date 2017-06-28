namespace OldestFamilyMember
{
    using System;
    using System.Reflection;

    public class StartUp
    {
        public static void Main()
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

            var family = new Family();
            var numberOfPeople = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfPeople; i++)
            {
                var memberInfo = Console.ReadLine().Split(' ');
                family.AddMember(new Person(memberInfo[0], int.Parse(memberInfo[1])));
            }

            var oldestMember = family.GetOldestMember();
            Console.WriteLine($"{oldestMember.name} {oldestMember.age}");
        }
    }
}