using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_C_sharp
{
    class carShop
    {
        public int numberOfDepart;
        public int numberOfEmloyeers { get; set; }
        public string nameOfShop;
        public string shopAdress;
        public double averageIncomeShop;
        public double expenses;
        public double numberOfNames;
        public double IncomeEmpls;
        public double[] mas = new double[3];
        
        
        
        
        public carShop(int numofdep, int numofempl,string nameshop,string adress, double numberNames, double avgincomeshop, double expns,double incomeEmpl)
        {
            numberOfDepart = numofdep;
            numberOfEmloyeers = numofempl;
            nameOfShop = nameshop;
            shopAdress = adress;
            averageIncomeShop = avgincomeshop;
            expenses = expns;
            numberOfNames = numberNames;
            IncomeEmpls = incomeEmpl;
            mas[0] = avgincomeshop;
            mas[1] = incomeEmpl;
            mas[2] = expns;

        }
        public double this[int index]
        {
            get
            {
                if (index >= 0 && index < mas.Length)
                    return mas[index]; 
                else
                    throw new ArgumentOutOfRangeException(); 
            }
        }

        public static carShop operator ++(carShop car)
        {
            car.numberOfEmloyeers++;
            return car;
        }
        public static carShop operator --(carShop car)
        {
            if (car.numberOfEmloyeers>0)
                car.numberOfEmloyeers--;
            return car;
        }


        public string IncomeMounth()
        {
            return averageIncomeShop.ToString();
        }
        public string IncomeYear()
        {
            return (averageIncomeShop*12).ToString();
        }

        public double nalog()
        {
            var nal = ((averageIncomeShop * 12) * 0.18) - (((averageIncomeShop * 12) - expenses - 1240) * 0.18);
            return nal;
        }


        public int CompareTo(carShop obj)
        {
            if (this.averageIncomeShop > obj.averageIncomeShop )
                return 1;
            if (this.averageIncomeShop < obj.averageIncomeShop)
                return -1;
            else
                return 0;
        }




    }
}
