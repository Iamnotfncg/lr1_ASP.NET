namespace pr1
{
    public class Company
    {
        public string? Name { get; set; }
        public string? Location { get; set; }
        public string? Description { get; set; }

        public override string ToString()
        {
            return $"Name:\t{Name}\nLocation:\t{Location}\nDescription:\t{Description}";
        }
    }
}
