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

            _schule.AddSchüler(new Schueler("Burak Mustermann", "Männlich", new DateTime(2008, 1, 23), "3aWi"));
            _schule.AddSchüler(new Schueler("Mark Peter", "Männlich", new DateTime(2005, 5, 15), "3bWi"));
            _schule.AddSchüler(new Schueler("Anna Mayer", "Weiblich", new DateTime(2006, 7, 20), "3bWi"));
            _schule.AddSchüler(new Schueler("Thomas Wayne", "Männlich", new DateTime(2004, 11, 10), "3aWi"));
            _schule.AddSchüler(new Schueler("Erik Quelle", "Männlich", new DateTime(2006, 9, 1), "3bWi"));
            _schule.AddSchüler(new Schueler("Maria Kolanovic", "Weiblich", new DateTime(2007, 1, 1), "3aWi"));
            _schule.AddSchüler(new Schueler("Lars Veljava", "Männlich", new DateTime(2007, 11, 11), "3bWi"));
            _schule.AddSchüler(new Schueler("Isabell Kopf", "Weiblich", new DateTime(2005, 4, 23), "3bWi"));

            _schule.AddKlassenraum(new Klassenraum("187", 50, 20, true));
            _schule.AddKlassenraum(new Klassenraum("181", 40, 15, false));
        }

        [Test]
        public void TestGetAnzahlSchüler()
        {
            Assert.AreEqual(8, _schule.GetAnzahlSchüler());
        }
        [Test]
        public void TestGetAnzahlSchülerNachGeschlecht_Männlich()
        {
            Assert.AreEqual(5, _schule.GetAnzahlSchülerNachGeschlecht("Männlich"));
        }
        [Test]
        public void TestGetAnzahlSchülerNachGeschlecht_Weiblich()
        {
            Assert.AreEqual(3, _schule.GetAnzahlSchülerNachGeschlecht("Weiblich"));
        }
        [Test]
        public void TestGetDurchschnittsalter()
        {
            double expectedAvgAge = 18.57;
            Assert.AreEqual(expectedAvgAge, _schule.GetDurchschnittsalter(), 0.1);
        }
        [Test]
        public void TestGetAnzahlKlassenräume()
        {
            Assert.AreEqual(2, _schule.GetAnzahlKlassenräume());
        }
        [Test]
        public void TestGetRäumeMitCynap()
        {
            var raeumeMitCynap = _schule.GetRäumeMitCynap();
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
                _person = new Person("John Doe", "Männlich", new DateTime(1990, 5, 15));
            }

            [Test]
            public void TestPersonProperties()
            {
                Assert.AreEqual("John Doe", _person.Name);
                Assert.AreEqual("Männlich", _person.Geschlecht);
                Assert.AreEqual(new DateTime(1990, 5, 15), _person.Geburtsdatum);
            }
            public class SchuelerTests
            {
                private Schueler _schueler;

                [SetUp]
                public void Setup()
                {
                    _schueler = new Schueler("Max Mustermann", "Männlich", new DateTime(2005, 8, 22), "3aWi");
                }

                [Test]
                public void TestSchuelerProperties()
                {
                    Assert.AreEqual("Max Mustermann", _schueler.Name);
                    Assert.AreEqual("Männlich", _schueler.Geschlecht);
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
                        Assert.AreEqual(50, _klassenraum.Groeße);
                        Assert.AreEqual(25, _klassenraum.Plaetze);
                        Assert.IsTrue(_klassenraum.HatCynap);
                    }
                }
            }
        }
    }
}
