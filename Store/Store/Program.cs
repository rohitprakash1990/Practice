using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BillingSystem objBillingSystem = new BillingSystem();
            Console.WriteLine("UserTyep 1= employee \n UserTyep 2=affiliate \n UserTyep 2=2 years Customer");
            Console.WriteLine("Please Enter User Type:");
            objBillingSystem.UserType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Total Bill Amount:" );
            objBillingSystem.TotalBill =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Please Enter Groceries Amount:");
            objBillingSystem.GroceriesAmount = Convert.ToInt32(Console.ReadLine());
            
            
            CalculateDiscount objCalculateDiscount = new CalculateDiscount();
            objBillingSystem.FinalBill=objCalculateDiscount.CalculateBill(objBillingSystem);
            
            Console.WriteLine("Total Amount {0} ", objBillingSystem.TotalBill);
            Console.WriteLine("GroceriesAmount {0} ", objBillingSystem.GroceriesAmount);
            Console.WriteLine("Net Payable Amount Before $5 discount {0}", objBillingSystem.FinalBill);
            FinalBill objFinalBill = new FinalBill();
            objBillingSystem.FinalBill=objFinalBill.CalculateBill(objBillingSystem);
            Console.WriteLine("Net Payable Amount After $5 discount {0}", objBillingSystem.FinalBill);

            Console.ReadLine();
        }

       

        }
}
