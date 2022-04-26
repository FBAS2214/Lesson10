using System.Collections;

namespace Models
{
    public class Group : IEnumerable
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Student[]? Students { get; set; }

        public IEnumerator GetEnumerator()
            => Students.GetEnumerator();
    }
}