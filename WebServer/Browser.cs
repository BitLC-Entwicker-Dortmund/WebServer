using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServer {
    internal class Browser {
        public Browser(WebServer ws) {
            Console.WriteLine(  ws.Suchen("index") );
        }
        public Browser(WebServer ws, string seitenkennung) {
            Console.WriteLine(ws.Suchen(seitenkennung));
        }

        public void HoleSeitenInhaltVon(WebServer ws, string kennung) {
            Console.WriteLine(ws.Suchen(kennung)); 
        }
    }
}
