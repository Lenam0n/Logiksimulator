/*
XOR
A|B|Y
-+-+-
0|0|0
0|1|1
1|0|1
1|1|0

A  B
|  |   +----+
|  +---| &  |   Y1
|  |   |    +-----+     +-----+
+--|--O|    |     |     | =>1 |
|  |   +----+     +-----|     |
|  |   +----+     +-----|     +----- Y
|  +--O| &  |   Y2|     |     |
|  |   |    +-----+     +-----+
+--|---|    |
|  |   +----+

     +---+
O   -| 1 |o-
     +---+

A  B
|  |         +----+
|  +---------+ &  |   
|  |         |    |     
|  |         |    |  Y1 +-----+
|  |  +---+  |    +-i#o-+     |
+--|--| 1 |o-+    |     | =>1 |
|  |  +---+  |    |     |     +----- Y
|  |         +----+     |     |
|  |         +----+     |     |     
|  |  +---+  |    |     |     |
|  +--| 1 |o-+ &  |  Y2 |     |    
|  |  +---+  |    |     |     |
|  |         |    +--#--+     |
+--|---------+    |     +-----+
|  |         +----+

*/
using System.Security.Cryptography;

class LogikSimulator
{
    public static void Main()
    {
        EINGANG A = new EINGANG();
        EINGANG B = new EINGANG();
        UND u1 = new UND();

        CONNECTOR c1 = new CONNECTOR(A, u1.getEingang(1));
        CONNECTOR c2 = new CONNECTOR(B, u1.getEingang(2));

        A.set(false);
        B.set(false);

        Console.WriteLine(u1.getAusgang().get());
    }
}