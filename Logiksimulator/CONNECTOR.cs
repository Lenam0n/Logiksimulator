using System.Collections;

class CONNECTOR { 

    private EINGANG eingang;
    private EINGANG ausgang;
    private List<GATTER> liste;
    private int sw;

    private AUSGANG a1;
    
    public CONNECTOR(GATTER e, GATTER a)
    {
        sw = 3;
        this.a1 = e.getAusgang();
        this.ausgang = a.getEingang();
        e.setConnector(this);
    }
    public CONNECTOR(EINGANG e, List<GATTER> l)
    {
        sw = 2;
        this.eingang = e;
        this.liste = l;
        e.setConnector2(this);
    }

    public CONNECTOR(EINGANG e, GATTER a)
    {
        sw = 1;
        this.eingang = e;
        this.ausgang = a.getEingang();
        e.setConnector2(this);
    }

    public CONNECTOR(EINGANG e, EINGANG a)
    {
        sw = 4;
        this.eingang = e;
        this.ausgang = a;
        this.a1 = a.getGatter().getAusgang();
        e.setConnector2(this);
    }
    public void schalten()
    {
        if (sw == 1)
        {
            bool val = this.eingang.get();
            this.ausgang.set(val);
        }
        else if (sw == 2)
        {
            bool val = this.eingang.get();
            foreach (NICHT n in liste)
            {
                n.getEingang().set(val);
            }

        }
        else if (sw == 3)
        {
            bool val = this.a1.get();
            this.ausgang.set(val);
        }
        else if (sw == 4)
        {
            bool val = this.eingang.get();
            this.a1.set(val);
        }
    }
}