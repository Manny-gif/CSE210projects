
// class Program
// {
//     public static void Main(string[] args)
//     {
//         WordCounter wordcounter = new WordCounter("Hello World! This is a test. Hello again.");
//         wordcounter.DisplayWords();

//         int count = wordcounter.CountSingleWord("Hello");
//         Console.WriteLine($"The word 'Hello' appears {count} times.");
//     }

// }
  

public class User
{
    private string _username;
    private int _password;

    public User(string username, string password)
    {
        _username = username;
        _password = userPassword(password);
    }

    private int userPassword(string password)
    {
        return password.GetHashCode();
    }

    public bool Authenticate(string passwordAttempt)
    {
            return _password == userPassword(passwordAttempt);
        }
    
        public string GetUsername()
        {
            return _username;
        }
    }