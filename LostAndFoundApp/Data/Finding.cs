namespace LostAndFoundApp.Data
{
    public class Finding
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string About { get; private set; }
        public string KeyWords { get; private set; }
        public string Phone { get; private set; }
        public string Mail { get; private set; }

        public Finding(string name, string about, string keyWords, string phone, string mail)
        {
            Name = name;
            About = about;
            KeyWords = keyWords;
            Phone = phone;
            Mail = mail;
        }
    }
}
