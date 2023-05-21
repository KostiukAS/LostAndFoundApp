namespace LostAndFoundApp.Data
{
    public class Filter
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public Filter(string name)
        {
            Name = name;
        }
    }
}
