namespace Chain_Of_Responsability;

public abstract  class Handler
{
    protected Handler next;
    
    public Handler setNext(Handler next)
    {
        this.next = next;
        
        return next;
    }
    
    public abstract void Handle(string request);
}
