using System.Text;

namespace LostAndFoundApp.Data
{
    public class WorkWithData
    {
        public static bool IsValidPhone(string phone)
        {
            if (phone == null || phone.Length != 13)
            {
                return false;
            }
            
            char[] phoneChars = phone.ToCharArray();
            
            if (phoneChars[0] != '+')
            {
                return false;
            }
            else
            {
                phoneChars[0] = '0';
            }

            if (!phoneChars.All(char.IsDigit))
            {
                return false;
            }

            return true;
        }

        public static bool IsValidEmail(string email)
        {
            int counter = 0;

            foreach (char c in email)
            {
                if (c == '@') counter++;
            }

            if (counter == 0 || counter > 1 || email[0] == '@' || email.Last() == '@') return false;

            return true;
        }

        public static string FormatToKeyWords(string[] filters)
        {
            StringBuilder sb = new();

            for (int i = 0; i < filters.Length; i++)
            {
                sb.Append(filters[i]);

                if (i != filters.Length - 1)
                {
                    sb.Append(',');
                }
            }

            return sb.ToString();
        }
    }
}
