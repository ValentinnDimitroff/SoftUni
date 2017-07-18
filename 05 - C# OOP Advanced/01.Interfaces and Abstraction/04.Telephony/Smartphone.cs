namespace _04.Telephony
{
    using System.Linq;

    public class Smartphone : ICallable, IBrowsable
    {
        public string Call(string number)
        {
            if (!this.ValidatePhoneNumber(number))
            {
                return "Invalid number!";
            }

            return $"Calling... {number}";
        }

        public string Browse(string url)
        {
            if (!this.ValidateURL(url))
            {
                return "Invalid URL!";
            }

            return $"Browsing: {url}!";
        }

        private bool ValidatePhoneNumber(string number)
        {
            if (!number.Any(char.IsDigit))
            {
                return false;
            }

            return true;
        }

        private bool ValidateURL(string url)
        {
            if (url.Any(char.IsDigit))
            {
                return false;
            }

            return true;
        }
    }
}
