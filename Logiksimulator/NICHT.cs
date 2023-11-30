class NICHT : GATTER
{
    
    private EINGANG e;
    private AUSGANG a;
    private CONNECTOR c;


    public NICHT()
    {
        this.e = new EINGANG(this);
        this.a = new AUSGANG(this);
    }

    public EINGANG getEingang()
    {
        return this.e;
    }

    public EINGANG getEingang(int e)
    {
        return getEingang();
    }

    public void setConnector(CONNECTOR c)
    {
        this.c = c;
    }

    public AUSGANG getAusgang()
    {
        return this.a;
    }
    public void addAusgang(AUSGANG a) {
        this.a = a;
    }

    public void addEingang(EINGANG e)
    {
        this.e = e;
    }

    public bool schalten()
    {
        bool ein = this.e.get();
        
        if (ein) { 
            this.a.set(false);
            if(c is not null) c.schalten();
        }
        else { 
            this.a.set(true);
            if (c is not null) c.schalten();
        }
        return this.a.get();
    }
    
}