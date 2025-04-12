using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class Program
    {
        partial class PaymentForm
        {
            public int x;

            public PaymentForm()
            {
                
            }
            public PaymentForm(int amount)
            {
                validPayment(amount);
            }

            partial void validPayment(int amount);
      

        }
        partial class PaymentForm
        {
            public int y;

            partial void validPayment(int amount)
            {
                if (amount > 1000)
                {
                    Console.WriteLine("Payment is valid");
                }
                else
                {
                    Console.WriteLine("Amount is too low");
                }


            }
            static void Main(string[] args)
            {
                PaymentForm form = new PaymentForm(900);
                //Console.WriteLine(form);

            }
        }
        
    }
}
