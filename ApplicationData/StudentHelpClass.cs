using System;

namespace WorldSkills.ApplicationData
{
    public static class StudentHelpClass
    {
        public static int Id { get; set; }
        public static string Name { get; set; }
        public static string Date { get; set; } = DateTime.Now.ToString();
    }
}