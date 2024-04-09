namespace ConsoleApp16
{
    struct Student
    {
        public string Name;
        public int GroupNumber;
        public int[] Grades;

        public Student(string Name, int GroupNumber, int[] Grades)
        {
            this.Name = Name;
            this.GroupNumber = GroupNumber;
            this.Grades = Grades;

        }
        public double AverageGrade
        {
            get { return Grades.Average(); }
        }
    }
}
