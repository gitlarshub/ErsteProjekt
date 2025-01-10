using SWP_Test02;

namespace Tests
{
    public class SchuleTest
    {
        private Schule _schule;

        [SetUp]
        public void Setup()
        {
            _schule = new Schule();

            _schule.AddSch�ler(new Schueler("Burak Mustermann", "M�nnlich", new DateTime(2008, 1, 23), "3aWi"));
            _schule.AddSch�ler(new Schueler("Mark Peter", "M�nnlich", new DateTime(2005, 5, 15), "3bWi"));
            _schule.AddSch�ler(new Schueler("Anna Mayer", "Weiblich", new DateTime(2006, 7, 20), "3bWi"));
            _schule.AddSch�ler(new Schueler("Thomas Wayne", "M�nnlich", new DateTime(2004, 11, 10), "3aWi"));
            _schule.AddSch�ler(new Schueler("Erik Quelle", "M�nnlich", new DateTime(2006, 9, 1), "3bWi"));
            _schule.AddSch�ler(new Schueler("Maria Kolanovic", "Weiblich", new DateTime(2007, 1, 1), "3aWi"));
            _schule.AddSch�ler(new Schueler("Lars Veljava", "M�nnlich", new DateTime(2007, 11, 11), "3bWi"));
            _schule.AddSch�ler(new Schueler("Isabell Kopf", "Weiblich", new DateTime(2005, 4, 23), "3bWi"));

            _schule.AddKlassenraum(new Klassenraum("187", 50, 20, true));
            _schule.AddKlassenraum(new Klassenraum("181", 40, 15, false));
        }

        [Test]
        public void TestGetAnzahlSch�ler()
        {
            Assert.AreEqual(8, _schule.GetAnzahlSch�ler());
        }
        [Test]
        public void TestGetAnzahlSch�lerNachGeschlecht_M�nnlich()
        {
            Assert.AreEqual(5, _schule.GetAnzahlSch�lerNachGeschlecht("M�nnlich"));
        }
        [Test]
        public void TestGetAnzahlSch�lerNachGeschlecht_Weiblich()
        {
            Assert.AreEqual(3, _schule.GetAnzahlSch�lerNachGeschlecht("Weiblich"));
        }
        [Test]
        public void TestGetDurchschnittsalter()
        {
            double expectedAvgAge = 18.57;
            Assert.AreEqual(expectedAvgAge, _schule.GetDurchschnittsalter(), 0.1);
        }
        [Test]
        public void TestGetAnzahlKlassenr�ume()
        {
            Assert.AreEqual(2, _schule.GetAnzahlKlassenr�ume());
        }
        [Test]
        public void TestGetR�umeMitCynap()
        {
            var raeumeMitCynap = _schule.GetR�umeMitCynap();
            Assert.AreEqual(1, raeumeMitCynap.Count);
            Assert.AreEqual("187", raeumeMitCynap[0].RaumId);
        }
        [Test]
        public void TestGetFrauenanteilInKlasse()
        {
            string klasseAbfrage = "3bWi";
            double frauenanteil = _schule.GetFrauenanteil(klasseAbfrage);
            Assert.AreEqual(40.0, frauenanteil);
        }
        [Test]
        public void TestKannKlasseRaumNutzen()
        {
            string klasseAbfrage = "3aWi";
            string raumAbfrage = "187";
            bool kannUnterrichtetWerden = _schule.KannKlasseRaumNutzen(klasseAbfrage, raumAbfrage);
            Assert.IsTrue(kannUnterrichtetWerden);

            raumAbfrage = "181";
            kannUnterrichtetWerden = _schule.KannKlasseRaumNutzen(klasseAbfrage, raumAbfrage);
            Assert.IsTrue(kannUnterrichtetWerden);
        }
        public class PersonTests
        {
            private Person _person;

            [SetUp]
            public void Setup()
            {
                _person = new Person("John Doe", "M�nnlich", new DateTime(1990, 5, 15));
            }

            [Test]
            public void TestPersonProperties()
            {
                Assert.AreEqual("John Doe", _person.Name);
                Assert.AreEqual("M�nnlich", _person.Geschlecht);
                Assert.AreEqual(new DateTime(1990, 5, 15), _person.Geburtsdatum);
            }
            public class SchuelerTests
            {
                private Schueler _schueler;

                [SetUp]
                public void Setup()
                {
                    _schueler = new Schueler("Max Mustermann", "M�nnlich", new DateTime(2005, 8, 22), "3aWi");
                }

                [Test]
                public void TestSchuelerProperties()
                {
                    Assert.AreEqual("Max Mustermann", _schueler.Name);
                    Assert.AreEqual("M�nnlich", _schueler.Geschlecht);
                    Assert.AreEqual(new DateTime(2005, 8, 22), _schueler.Geburtsdatum);
                    Assert.AreEqual("3aWi", _schueler.Schulklasse);
                }
                public class KlassenraumTests
                {
                    private Klassenraum _klassenraum;

                    [SetUp]
                    public void Setup()
                    {
                        _klassenraum = new Klassenraum("101", 50, 25, true);
                    }

                    [Test]
                    public void TestKlassenraumProperties()
                    {
                        Assert.AreEqual("101", _klassenraum.RaumId);
                        Assert.AreEqual(50, _klassenraum.Groe�e);
                        Assert.AreEqual(25, _klassenraum.Plaetze);
                        Assert.IsTrue(_klassenraum.HatCynap);
                    }
                }
            }
        }
    }
}
