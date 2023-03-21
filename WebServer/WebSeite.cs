using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServer {
    internal class WebSeite {
        private string kennung;
        private string inhalt;

        public void SetKennung(string k) {
            kennung = k;
        }
        public string GetKennung() {
            return kennung; 
        }
        public string GetInhalt() {
            return inhalt; 
        }
        public void SetInhalt(string inhalt) {
            this.inhalt = inhalt;
        }

        public WebSeite(string kennung, String inhalt) {
            this.kennung = kennung;
            this.inhalt = inhalt;
        }
        public WebSeite() {
            kennung = "index";
            inhalt = "It works";
        }
    }
}
