
namespace PasswordLibrary
{
    public class PasswordValidator
    {
        public static bool IsValidation(string password)
        {
            if(string.IsNullOrEmpty(password)) return false;

            if(password.Length < 8) return false;

            bool hasDigit =password.Any(char.IsDigit);
            if(!hasDigit) return false;

            bool hasLetter = password.Any(c => (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'));
            if(!hasLetter) return false;

            return true;
        }
    }

}
