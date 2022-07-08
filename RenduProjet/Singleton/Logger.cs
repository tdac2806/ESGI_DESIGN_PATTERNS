namespace Singleton;

public sealed class Logger
{
    private Logger()
    {
    }
    
    private static Logger _instance = null;
    private StreamWriter sr = null;
    public static Logger Instance()
    {
        if(null == _instance)
        {
            _instance = new Logger();
        }
        return _instance;
    }

    public void StartWriter(String path)
    {
        if(null == sr)
        {
            sr = new StreamWriter(path, true);
        }
    }
    
    public void Write(String str)
    {
        if(null != sr)
        {
            sr.WriteLine(str);
        }
    }
    public void Close()
    {
        if(null != sr)
        {
            sr.Flush();
            sr.Close();
            
            sr = null;
        }
    }
    
    public string Read(String path)
    {
        if(null != sr)
        {
            Close();
        }
        return File.ReadAllText(path);
    }
}