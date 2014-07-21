using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Hiscox.Data
{
    public class Repository : IRepository, IDisposable
    {
        private List<string> Stations = StationsList();

        public IEnumerable<string> GetAll()
        {
            return Stations;
        }

        public IEnumerable<string> GetSations(string searchTerm)
        {
            return Stations.Where(s => s.ToLower().Contains(searchTerm.ToLower()));
        }

        private static List<string> StationsList()
        {
            return new List<string>
            {
                "Abbey Wood" ,
                "Acton Central",
                "Acton Main Line[1]",
                "Albany Park",
                "Alexandra Palace[2]",
                "Amersham",
                "Anerley",
                "Angel Road",
                "Balham",
                "Banstead",
                "Barking",
                "Barnehurst",
                "Barnes",
                "Barnes Bridge",
                "Battersea Park[3]",
                "Beckenham Hill",
                "Beckenham Junction",
                "Bellingham",
                "Belmont",
                "Belvedere",
                "Berrylands",
                "Bethnal Green[4]",
                "Bexley",
                "Bexleyheath[5]",
                "Bickley",
                "Birkbeck",
                "BlackfriarsLondon",
                "Blackheath",
                "Blackhorse Road",
                "Bowes Park",
                "Brentford",
                "Brentwood",
                "Brimsdown",
                "Brixton",
                "Brockley",
                "Bromley North",
                "Bromley South",
                "Brondesbury",
                "Brondesbury Park",
                "Broxbourne",
                "Bruce Grove",
                "Bushey",
                "Bush Hill Park[6]",
                "Caledonian Road & Barnsbury",
                "Cambridge Heath",
                "Camden Road",
                "Canada Water",
                "Cannon StreetLondon",
                "Canonbury",
                "Carpenders Park",
                "Carshalton",
                "Carshalton Beeches[7]",
                "Castle Bar Park",
                "Caterham",
                "Catford",
                "Catford Bridge",
                "Chadwell Heath",
                "Chafford Hundred",
                "Chalfont & Latimer",
                "Charing CrossLondon",
                "Charlton",
                "Cheam",
                "Chelsfield",
                "Cheshunt",
                "Chessington North",
                "Chessington South",
                "Chingford",
                "Chipstead",
                "Chislehurst",
                "Chiswick[8]",
                "Chorleywood",
                "City ThameslinkLondon",
                "Clapham High Street",
                "Clapham Junction",
                "Clapton",
                "Clock House",
                "Coulsdon South",
                "Coulsdon Town",
                "Crayford",
                "Crews Hill[9]",
                "Cricklewood",
                "Crofton Park",
                "Crouch Hill",
                "Crystal Palace",
                "Dagenham Dock",
                "Dalston Junction",
                "Dalston Kingsland",
                "Dartford",
                "Denmark Hill",
                "Deptford",
                "Drayton Green[11]",
                "Drayton Park",
                "Ealing Broadway",
                "Earlsfield[12]",
                "East Croydon[13]",
                "East Dulwich",
                "Eden Park",
                "Edmonton Green",
                "Elephant & Castle[14]",
                "Elmers End",
                "Elmstead Woods",
                "Elstree & Borehamwood[15]",
                "Eltham",
                "Emerson Park",
                "Enfield Chase[9]",
                "Enfield Lock[16]",
                "Enfield Town[9]",
                "Epsom Downs",
                "Erith[17]",
                "Essex Road",
                "EustonLondon",
                "Ewell East",
                "Ewell West"
            };
        }


        protected void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Dispose Database connection

                //if (db != null)
                //{
                //    db.Dispose();
                //    db = null;
                //}
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }

}
