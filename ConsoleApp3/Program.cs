using System.Collections.Generic; 
public class user
{
    private string name;
    private string login;
    private string password;
    public bool enter()
    {
        return true;
        Console.WriteLine($"Введите логин ");
        Console.WriteLine($"Введите пароль ");
    }
    public string getName()
    {
        return name;
    }
}
public class admin:user
{
    private string name;
    private string login;
    private string password;
    public void addUser()
    {
        Console.WriteLine($"Введите имя нового пользователя ");
        Console.WriteLine($"Введите логин нового пользователя ");
        Console.WriteLine("Пароль пользователя установлен по умолчанию на 123456 ");
    }
}
public class elector : user
{
    private string name;
    private bool voted;
    public bool isVoted()
    { return voted; }
    public void vote()
    { }
}

 public class candidate
{
    private string name;
    private int voices = 0;
    public string getName()
    {
        return name;
    }
    public void addVoice()
    {
        voices++;
    }
    public int getVoices()
    {
        return voices;
    }
    
}
public class Voting
{
    private string title;
    private List <candidate> canditats = new List<candidate>();
    public void voting()
    { }
}
public class votingSystem
{
    private static List<candidate> candidats = new List<candidate>();
    private Voting currentVoting;
    private user currentUser;
    public static void main(String[] args)
    {
        static user addUser()
        {
            return new user();
        }
        static user findUser()
        {
            return new user();
        }
        void save()
        {

        }
        void load()
        {

        }
        static List<candidate> getResult()
        {
            return candidats;
        }
    }
}