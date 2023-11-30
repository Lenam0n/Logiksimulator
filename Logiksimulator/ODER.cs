class ODER : GATTER
{
    private bool Y;

    public bool schalten() { return true; }

    public void addEingang(EINGANG e) { }
    public void addAusgang(AUSGANG a) { }
    public AUSGANG getAusgang() { return null; }
    public EINGANG getEingang() { return null; }

    public EINGANG getEingang(int e) { return null; }

    public void setConnector(CONNECTOR c) { }
    /*
    public bool schalten(List<bool> E)
    {
        int anz = E.Count;

        Y = false;

        if (anz < 2)
            Console.WriteLine("Die Liste muss mindestens 2 Parameter haben!");
        else
            foreach (bool b in E)
            {
                if (b)
                {
                    Y = true;
                    break;
                }
            }

        return Y;
    }

    */
}