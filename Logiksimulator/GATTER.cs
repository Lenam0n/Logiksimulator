using System.Collections;
interface GATTER
{
    public bool schalten();
    public void addEingang(EINGANG e);
    public void addAusgang(AUSGANG a);
    public AUSGANG getAusgang();
    public EINGANG getEingang();
    public EINGANG getEingang(int e);

    public void setConnector(CONNECTOR c);

}