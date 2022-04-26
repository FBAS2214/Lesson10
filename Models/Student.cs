namespace Models
{
    public class Student : IComparable<Student>, IEquatable<Student>, IDisposable
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public StudentCard StudentCard { get; set; }
        public DateOnly Birthdate { get; set; }

        public int CompareTo(Student? other)
        {
            if (other?.Name == null)
                throw new ArgumentNullException();

            if (Name?.Length == other.Name.Length)
                return 0;
            else if (Name?.Length > other.Name.Length)
                return 1;
            else
                return -1;
        }

        public void Dispose()
        {
            // close
            Console.WriteLine("Dispose");
        }

        public bool Equals(Student? other)
            => 
            (Name, Surname, Birthdate) 
            == 
            (other?.Name, other?.Surname, other?.Birthdate);

        public override string ToString()
        => @$"
Name: {Name}
Surname: {Surname}
StudentCard: {StudentCard}
Birthdate: {Birthdate}";
    }
}