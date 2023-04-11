using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    public class BackBag
    {
        List<int> itemsIndex = new List<int>();
        List<double> itemsValue = new List<double>();
        List<double> itemsWeight = new List<double>();
        List<double> ratioList = new List<double>();
        int numberOfItems = 0;

        List<double> pickedItemsWeight = new List<double>();
        List<double> pickedItemsValues = new List<double>();

        int fullWeight = 0;

        public BackBag(int numberOfItems, int seed, int fullWeight)
        {
            Random rand = new Random();
            for (int i = 0; i < numberOfItems; i++)
            {
                this.itemsWeight.Add(rand.Next(seed, seed+10));
                if (this.itemsWeight[i] == 0)
                {
                    itemsWeight[i] = 1;
                }
                this.itemsValue.Add(rand.Next(seed, seed+10));
            }
            this.fullWeight = fullWeight;
            this.numberOfItems = numberOfItems;
        }

        public BackBag(int numberOfItems, int fullWeight, List<double> itemsValue, List<double> itemsWeight)
        {
            this.numberOfItems = numberOfItems;
            this.fullWeight = fullWeight;
            for(int i = 0;i < numberOfItems; i++)
            {
                if (itemsWeight[i] == 0)
                {
                    itemsWeight[i] = 1;
                }
                if (itemsValue[i] < 0)
                {
                    throw new ArgumentException("items value cannot be less then zero");
                }
                if (itemsWeight[i] < 0)
                {
                    throw new ArgumentException("items weight cannot be less then zero");
                }
            }
            this.itemsValue = itemsValue;
            this.itemsWeight = itemsWeight;
        }

        public override string ToString()
        {
            string str = "";
            return str;
        }

        public List<double> GetPickedItemsValue()
        {
            return this.pickedItemsValues;
        }

        public List<double> GetPickedItemsWeight()
        {
            return this.pickedItemsWeight;
        }

        public List<double> GetItemsValueList()
        {
            return this.itemsValue;
        }

        public List<double> GetItemsWeightList()
        {
            return this.itemsWeight;
        }

        public double GetFullValue()
        {
            double fullValue = this.pickedItemsValues.Sum();
            return fullValue;
        }

        public List<double> GetRatioList()
        {
            return this.ratioList;
        }

        public void InitRatioList()
        {
            for (int i = 0; i < this.numberOfItems; i++)
            {
                this.ratioList.Add(this.itemsValue[i] / this.itemsWeight[i]);
            }
        }

        public double GetFullWeight()
        {
            double fullWeight = this.pickedItemsWeight.Sum();
            return fullWeight;
        }

        public string FindBestResult()
        {
            this.InitRatioList();
            double sum = 0;
            string resultString = "";
            while (sum <= this.fullWeight)
            {
                if (this.ratioList.Count() == 0)
                {
                    break;
                }
                double maxRatio = this.ratioList.Max();
                int maxRatioIndex = this.ratioList.IndexOf(maxRatio);
                resultString += "w: " + this.itemsWeight[maxRatioIndex].ToString() + ", v: " + this.itemsValue[maxRatioIndex].ToString() + "\r\n";
                if((sum + this.itemsWeight[maxRatioIndex]) > this.fullWeight)
                {
                    break;
                }
                sum += this.itemsWeight[maxRatioIndex];
                this.pickedItemsWeight.Add(this.itemsWeight[maxRatioIndex]);
                this.pickedItemsValues.Add(this.itemsValue[maxRatioIndex]);
                this.itemsValue.RemoveAt(maxRatioIndex);
                this.itemsWeight.RemoveAt(maxRatioIndex);
                this.ratioList.RemoveAt(maxRatioIndex);
            };
            resultString += "Full Weight: " + this.GetFullWeight().ToString() + "\r\n";
            resultString += "Full Value: " + this.GetFullValue().ToString() + "\r\n";
            resultString += "Max Weight: " + this.fullWeight;
            return resultString;
        }
    }
}
