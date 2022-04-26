namespace Models
{
    public struct StudentCard
    {
        public int Number { get; set; }
        public string? Series { get; set; }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        => $"Number: {Number}    Series: {Series}";
    }
}