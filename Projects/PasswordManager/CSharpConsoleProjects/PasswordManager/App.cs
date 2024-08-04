using System.Text;

namespace CSharpConsoleProjects.PasswordManager;

public class App
{
    /* [ Password Manager]
     1. List all passwords
     2. Add or change password
     3. Get password
     4. Delete password
     */
    
    private static readonly Dictionary<string, string> _passwordEnteries = new();
    public static void Run(string[] args)
    {
        ReadPasswords();
        while (true)
        {
            Console.WriteLine("Please Select an option:");
            Console.WriteLine("1. List all passwords:");
            Console.WriteLine("2. Add/change password:");
            Console.WriteLine("3. Get password");
            Console.WriteLine("4. Delete password");

            var selectedOption = Console.ReadLine();
            if (selectedOption == "1")
                ListALlPasswords();
            else if (selectedOption == "2")
                AddOrChangePassword();
            else if (selectedOption == "3")
                GetPassword();
            else if (selectedOption == "4")
                DeletePassword();
            else
            {
                Console.WriteLine("Invalid Option");
            }
            
            Console.WriteLine("-----------------------------");
        }
    }

    private static void ReadPasswords()
    {
        if (File.Exists("passwords.txt"))
        {
            var passwordLines = File.ReadAllText("passwords.txt");
            foreach (var line in passwordLines.Split(Environment.NewLine))
            {
                if (!string.IsNullOrEmpty(line))
                {
                    var index = passwordLines.IndexOf('=');
                    var appName = line.Substring(0, index);
                    var password = line.Substring(index + 1);
                    _passwordEnteries.Add(appName, password);
                }
            }
        }
    }

    private static void SavePasswords()
    {
        var sb = new StringBuilder();
        foreach (var entry in _passwordEnteries)
            sb.AppendLine($"{entry.Key} = {entry.Value} ");
        
        File.WriteAllText("passwords.txt", sb.ToString());
    }

    private static void DeletePassword()
    {
        Console.Write("Please Enter website/app name: ");
        var appName = Console.ReadLine();
        if (_passwordEnteries.ContainsKey(appName))
        {
            _passwordEnteries.Remove(appName);
            SavePasswords();
        }
        else
        {
            Console.WriteLine("Password not found!");
        }
    }

    private static void GetPassword()
    {
        Console.Write("Please Enter website/app name: ");
        var appName = Console.ReadLine();
        if(_passwordEnteries.ContainsKey(appName))
            Console.WriteLine($"Your password is: {_passwordEnteries[appName]}");
        else
        {
            Console.WriteLine("Password not found!");
        }
    }

    private static void AddOrChangePassword()
    {
        Console.Write("Please Enter website/app name: ");
        var appName = Console.ReadLine();
        Console.Write("Please Enter the new password:");
        var password = Console.ReadLine();

        if (_passwordEnteries.ContainsKey(appName))
        {
            _passwordEnteries[appName] = password;
        }
        else
            _passwordEnteries.Add(appName, password);
        SavePasswords();
        
    }

    private static void ListALlPasswords()
    {
        foreach (var entry in _passwordEnteries)
        {
            Console.WriteLine($"{entry.Key} = {entry.Value}");
        }
    }
}