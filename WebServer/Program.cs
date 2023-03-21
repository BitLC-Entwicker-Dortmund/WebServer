namespace WebServer {
    internal class Program {
        static void Main(string[] args) {
           // Console.WriteLine("Hello, Web!");
           WebServer wserver = new WebServer();
            WebSeite ws3 = new WebSeite("seite3","Inhalt Seite3");
            wserver.AddWebSeite (new WebSeite("Seite2","Inhalt von Seite2 "));
            wserver.AddWebSeite(ws3);

            //wserver.GetSeitenKennungenVomServer();
            //Console.WriteLine(  wserver.Suchen("Seite2"));

            Browser meinBrowser = new Browser(wserver);
            meinBrowser = new Browser(wserver, "Seite2");
            meinBrowser = new Browser(wserver, "seite3");

            Console.WriteLine(  "-----------------------");
            meinBrowser.HoleSeitenInhaltVon(wserver, "index");
            meinBrowser.HoleSeitenInhaltVon(wserver, "seite3");
            meinBrowser.HoleSeitenInhaltVon(wserver, "Seite2");


            Console.ReadLine();
        }
    }
}