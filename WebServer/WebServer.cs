using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServer {
    internal class WebServer {
        private List<WebSeite> seitenListe = new List<WebSeite>();
        public WebServer() {
            seitenListe.Add(new WebSeite());
        }

        public string Suchen(string kennung) {
            string ergebnis = null;

            foreach (WebSeite eintrag in seitenListe) {
                if (eintrag.GetKennung() == kennung) {
                    ergebnis = eintrag.GetInhalt();

                    break;
                } else {
                    ergebnis = "Fehler 404 - Seite nicht gefunden";
                }
            }
            return ergebnis;
        }

        public void AddWebSeite(WebSeite ws) {
            this.seitenListe.Add(ws);
        }

        internal void GetSeitenKennungenVomServer() {
            foreach (WebSeite eineWebSeite in seitenListe) {
                Console.WriteLine(  eineWebSeite.GetKennung());
            }
        }
    }
}
