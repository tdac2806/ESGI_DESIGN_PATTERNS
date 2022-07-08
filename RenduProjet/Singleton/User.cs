namespace Singleton;

public class User
{
    private Logger logger;
    
    public User()
    {
        logger = Logger.Instance();
    }
    
    public void Write(string message)
    {
        logger.Write(message);
    }
    public void Close()
    {
        logger.Close();
    }
    
    public string Read(string path)
    {
        return logger.Read(path);
    }
    
    public void StartWriter(string path)
    {
        logger.StartWriter(path);
    }
}