using Objektorientierung07;


namespace TestTierheim
{
    public class TestTierheim   {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
        }

        [Test]
        public void AddAnimal_AddOneCatAndOneDog_ReturnsTwoAnimals()
        {
            Tierheim myTierheim = new Tierheim();
            myTierheim.AddAnimal(new Cat("Kitty", "white", new DateTime(2023, 07, 13)));
            myTierheim.AddAnimal(new Dog("Lessi", "grey", new DateTime(2023, 07, 13)));
            Assert.IsTrue(myTierheim.GetAnimalCount() == 2);
        }
        [Test]
        public void GetAverageAge_AddAnimals_ReturnsCorrectAverageAge()
        {
            Tierheim myTierheim = new Tierheim();
            myTierheim.AddAnimal(new Cat("OlderCat", "black", new DateTime(2015, 1, 1)));
            myTierheim.AddAnimal(new Dog("YoungerDog", "white", new DateTime(2020, 1, 1)));
            double averageAge = myTierheim.GetAverageAge();
            Assert.AreEqual(6.5, averageAge, 0.01, "Das Durchschnittsalter sollte 6.5 Jahre betragen.");
        }
    }
}