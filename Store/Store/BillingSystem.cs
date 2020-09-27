using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
  public  class BillingSystem
    {
       public int UserType { get; set; }
        public double TotalBill { get; set; }
        public double GroceriesAmount { get; set; }
        public double FinalBill { get; set; }
    }

    public class IBilling
    {
        
        public virtual double CalculateBill(BillingSystem ObjBillingSystem)
        {
            return 0;
        }
    }
   
    public class CalculateDiscount : IBilling
    {
        public override double CalculateBill(BillingSystem ObjBillingSystem)
        {
            double discountableAmount = ObjBillingSystem.TotalBill - ObjBillingSystem.GroceriesAmount;
           
            switch (ObjBillingSystem.UserType)
            {
                case 1:
                    ObjBillingSystem.FinalBill = discountableAmount - (discountableAmount * 0.30 );
                    break;
                case 2:
                    ObjBillingSystem.FinalBill = discountableAmount - (discountableAmount * 0.10 );
                    break;
                case 3:
                    ObjBillingSystem.FinalBill = discountableAmount - (discountableAmount * 0.5);
                    break;
               
                default:
                    ObjBillingSystem.FinalBill = ObjBillingSystem.TotalBill;
                    break;
            }

           return ObjBillingSystem.FinalBill;
        }
    }
   
    public class FinalBill : IBilling
    {
        public override double CalculateBill(BillingSystem ObjBillingSystem)
        {
           
            int discountableAmount = Convert.ToInt32(ObjBillingSystem.FinalBill / 100) * 5;
           
          return  ObjBillingSystem.FinalBill = ObjBillingSystem.FinalBill- discountableAmount;

            
        }
    }
}
