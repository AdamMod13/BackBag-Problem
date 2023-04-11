using LAB1;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OneProductOverloadingBackbagWeight()
        {
            //Arrange items
            List<int> itemsValue = new List<int>();
            List<int> itemsWeight = new List<int>();
            itemsValue.Add(1);
            itemsWeight.Add(20);
            //Arrange full weigth
            int fullWeight = 10;
            //Arrange seed
            int seed = 20;

            //Act
            BackBag backBag = new BackBag(1, seed, fullWeight);
            backBag.FindBestResult();
            Assert.AreEqual(0, backBag.GetPickedItemsValue().Count(), "Items Value is not correct");
            Assert.AreEqual(0, backBag.GetPickedItemsWeight().Count(), "Items weight is not correct");        
        }

        [TestMethod]
        public void CheckIfBestValuesProductsWasAdded()
        {
            //Arrange items
            List<double> itemsValue = new List<double>()
            {
                100,
                1,
                1,
                60,
                1,
                1
            };
            List<double> itemsWeight = new List<double>()
            {
                1,
                10,
                10,
                5,
                10,
                10
            };

            //Arrange full weigth
            int fullWeight = 10;
            
            //Act
            BackBag backBag = new BackBag(6, fullWeight, itemsValue, itemsWeight);
            backBag.FindBestResult();
            Assert.IsTrue(backBag.GetPickedItemsValue().Contains(100));
            Assert.IsTrue(backBag.GetPickedItemsValue().Contains(60));
            Assert.IsTrue(backBag.GetPickedItemsWeight().Contains(1));
            Assert.IsTrue(backBag.GetPickedItemsWeight().Contains(5));
        }

        [TestMethod]
        public void CheckAllRatios()
        {
            List<double> itemsValue = new List<double>()
            {
                100,
                80,
                60,
                40,
                20,
                0
            };
            List<double> itemsWeight = new List<double>()
            {
                10,
                20,
                30,
                40,
                50,
                100
            };

            int fullWeight = 10;
            BackBag backBag = new BackBag(6, fullWeight, itemsValue, itemsWeight);
            List<double> ratioExpectation = new List<double>()
            {
                10.0,
                4.0,
                2.0,
                1.0,
                0.4,
                0.0
            };
            backBag.InitRatioList();
            List<double> resultRatio = backBag.GetRatioList();
            Assert.IsTrue(ratioExpectation.SequenceEqual(resultRatio));
        }

        [TestMethod]
        public void CheckIfWeightIsNotZero()
        {
            List<double> itemsValue = new List<double>()
            {
                100,
                80,
                60,
                40,
                20,
                0
            };
            List<double> itemsWeight = new List<double>()
            {
                10,
                0,
                30,
                0,
                50,
                100
            };

            int fullWeight = 10;
            BackBag backBag = new BackBag(6, fullWeight, itemsValue, itemsWeight);
            Assert.IsTrue(!backBag.GetItemsWeightList().Contains(0));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IllegalArgumentOfWeight()
        {
            List<double> itemsValue = new List<double>()
            {
                -100,
                80,
                60,
                40,
                20,
                0
            };
            List<double> itemsWeight = new List<double>()
            {
                10,
                0,
                30,
                0,
                50,
                100
            };

            int fullWeight = 10;
            BackBag backBag = new BackBag(6, fullWeight, itemsValue, itemsWeight);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IllegalArgumentOfValue()
        {
            List<double> itemsValue = new List<double>()
            {
                100,
                80,
                60,
                40,
                20,
                0
            };
            List<double> itemsWeight = new List<double>()
            {
                -10,
                0,
                30,
                0,
                50,
                100
            };

            int fullWeight = 10;
            BackBag backBag = new BackBag(6, fullWeight, itemsValue, itemsWeight);
        }

        [TestMethod]
        public void CompareItemsRatioAreEqual()
        {
            List<double> itemsValue = new List<double>()
            {
                100,
                50           
            };
            List<double> itemsWeight = new List<double>()
            {
                4,
                2,
            };

            int fullWeight = 10;
            BackBag backBag = new BackBag(itemsValue.Count(), fullWeight, itemsValue, itemsWeight);
            backBag.InitRatioList();
            Assert.AreEqual(backBag.GetRatioList()[0], backBag.GetRatioList()[1]);
        }

        [TestMethod]
        public void CompareItemsRatioArentEqual()
        {
            List<double> itemsValue = new List<double>()
            {
                100,
                50
            };
            List<double> itemsWeight = new List<double>()
            {
                4,
                1,
            };

            int fullWeight = 10;
            BackBag backBag = new BackBag(itemsValue.Count(), fullWeight, itemsValue, itemsWeight);
            backBag.InitRatioList();
            Assert.AreNotEqual(backBag.GetRatioList()[0], backBag.GetRatioList()[1]);
        }

        [TestMethod]
        public void CompareOrderOfItems()
        {
            //Arrange items
            List<double> itemsValue1 = new List<double>()
            {
                100,
                1,
                1,
                60,
                1,
                1
            };
            List<double> itemsWeight1 = new List<double>()
            {
                1,
                10,
                10,
                5,
                10,
                10
            };

            List<double> itemsValue2 = new List<double>()
            {
                60,
                1,
                1,
                100,
                1,
                1
            };
            List<double> itemsWeight2 = new List<double>()
            {
                5,
                10,
                10,
                1,
                10,
                10
            };

            //Arrange full weigth
            int fullWeight = 10;

            //Act
            BackBag backBag1 = new BackBag(6, fullWeight, itemsValue1, itemsWeight1);
            BackBag backBag2 = new BackBag(6, fullWeight, itemsValue2, itemsWeight2);
            backBag1.FindBestResult();
            backBag2.FindBestResult();
            Assert.AreEqual(backBag1.GetPickedItemsValue().IndexOf((double)100), backBag2.GetPickedItemsValue().IndexOf((double)100));
            Assert.AreEqual(backBag1.GetPickedItemsValue().IndexOf((double)60), backBag2.GetPickedItemsValue().IndexOf((double)60));
            Assert.AreEqual(backBag1.GetPickedItemsWeight().IndexOf((double)1), backBag2.GetPickedItemsWeight().IndexOf((double)1));
            Assert.AreEqual(backBag1.GetPickedItemsWeight().IndexOf((double)5), backBag2.GetPickedItemsWeight().IndexOf((double)5));

        }
    }
}