
class UND : GATTER
{

    private AUSGANG Y;
    private EINGANG a1;
    private EINGANG a2;

    public UND()
    {
        Y = new AUSGANG(this);
        a1 = new EINGANG(this);
        a2 = new EINGANG(this);
    }
    public bool schalten() {
        bool ein_1 = this.a1.get();
        bool ein_2 = this.a2.get();

        if (ein_1 == false) return false;
        if (ein_2 == false) return false;

        return true; 
    }

    public void addEingang(EINGANG e) { }
    public void addAusgang(AUSGANG a) { }
    public AUSGANG getAusgang() 
    { 
        return this.Y; 
    }
    public EINGANG getEingang()
    { 
        return this.a1; 
    }
    public EINGANG getEingang(int e = 1)
    {
        if (e == 1) return this.a1;
        else return this.a2;
        
    }

    public void setConnector(CONNECTOR c) { }

   
}