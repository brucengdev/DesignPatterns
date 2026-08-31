namespace AbstractFactory.FileSystemRepo;

public class FileSystemUserRepository : IUserRepository
{
    public void Create(string name, int age)
    {
        if(!Directory.Exists("data"))
        {
            Directory.CreateDirectory("data");
        }
        var filePath = $"data{Path.DirectorySeparatorChar}user-{name}.txt";
        File.WriteAllText(filePath, age.ToString());
    }

    public IList<User> GetUsers()
    {
        var files = Directory.GetFiles("data", "user-*.txt");
        return files.Select(fileName =>
        {
            var username = fileName.Split(Path.DirectorySeparatorChar)[1].Split(".")[0].Split("-")[1];
            var age = Convert.ToInt32(File.ReadAllText($"{fileName}"));
            return new User(username, age);
        }).ToList();
    }
}