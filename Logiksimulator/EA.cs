
using System.Text.Json;

class EINGANG
{
    private bool input;
    private GATTER ich_gehoere_zu;
    private CONNECTOR c2;

    public EINGANG()
    {

    }
    public EINGANG(GATTER ich_gehoere_zu)
    {
        ich_gehoere_zu.addEingang(this);
        this.ich_gehoere_zu = ich_gehoere_zu;
    }

    public void set(bool value) {
        input = value;
        if(ich_gehoere_zu is not null ) ich_gehoere_zu.schalten();
        if (c2 is not null) c2.schalten();
    }

    public bool get() {return this.input;}

    public void setConnector2(CONNECTOR c2)
    {
        this.c2 = c2;
    }

    public GATTER getGatter()
    {
        return ich_gehoere_zu;
    }

}

class AUSGANG
{
    private GATTER ich_gehoere_zu;
    private bool aus;

    public AUSGANG(GATTER ich_gehoere_zu)
    {
        ich_gehoere_zu.addAusgang(this);
        this.ich_gehoere_zu = ich_gehoere_zu;
    }

    public void set(bool val)
    {
        this.aus = val;
    }

    public bool get()
    {
        return this.aus;
    }    
}