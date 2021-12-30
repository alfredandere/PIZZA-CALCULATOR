using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PizzaCalculator
{
    class Pizza : Menu_Item
    {

        public string Size { get; set; }

        public String CrustType { get; set; }

        public float Price { get; set; }

        public int NumberOfToppings { get; set; }

        private const float Price_Small = 6.00F;
        private const float Price_Medium = 8.00F;
        private const float Price_Large = 10.00F;
        private const float Price_XtraLarge = 12.00F;

        private const float Crust_Hand_Tossed = 0.00F;
        private const float Crust_Thin = 1.00F;
        private const float Crust_Pan = 1.50F;
        private const float Crust_Brooklyn = 2.00F;

        private const float Topping = 0.50F;


        internal static float CalculatePriceOfPizza(Pizza customerPizza)
        {

            float toppingCost = 0F;
            float pizzaPrice = 0F;



            switch(customerPizza.Size)
            {
                case "Small":

                    toppingCost = customerPizza.NumberOfToppings * Topping;
                    if(customerPizza.CrustType == "Crunchy Thin")

                    {

                        pizzaPrice = Price_Small + Crust_Thin + toppingCost;

                    }

                    else if(customerPizza.CrustType == "Hand Tossed")
                        {

                        pizzaPrice = Price_Small + Crust_Hand_Tossed + toppingCost;

                         }
                    else
                    {


                        pizzaPrice = Price_Small + Crust_Pan + toppingCost;

                    }

                    break;


                case "Medium":
                    toppingCost = (customerPizza.NumberOfToppings * Topping) * 1.25F;
                    if(customerPizza.CrustType == "Crunchy Thin")

                    {
                        pizzaPrice = Price_Medium + Crust_Thin + toppingCost;


                    }else if(customerPizza.CrustType == "Hang Tosed")
                        {

                        pizzaPrice = Price_Medium + Crust_Hand_Tossed + toppingCost;

                    }else
                    {

                        pizzaPrice = Price_Medium + Crust_Pan + toppingCost;

                    }

                    break;

                case "Large":
                    toppingCost = (customerPizza.NumberOfToppings * Topping) * 1.50F;
                    if (customerPizza.CrustType == "Crunchy Thin")

                    {
                        pizzaPrice = Price_Large + Crust_Thin + toppingCost;


                    }
                    else if(customerPizza.CrustType == "Hang Tosed")
                        {

                        pizzaPrice = Price_Large + Crust_Hand_Tossed + toppingCost;

                    }else
                    {

                        pizzaPrice = Price_Large + Crust_Pan + toppingCost;

                    }

                    break;


                case "xtra Large":
                    toppingCost = (customerPizza.NumberOfToppings * Topping) * 2.00F;
                    if (customerPizza.CrustType == "Crunchy Thin")

                    {
                        pizzaPrice = Price_XtraLarge + Crust_Thin + toppingCost;


                    }
                    else if(customerPizza.CrustType == "Hang Tosed")
                        {

                        pizzaPrice = Price_XtraLarge + Crust_Hand_Tossed + toppingCost;

                    }else
                    {

                        pizzaPrice = Price_XtraLarge + Crust_Pan + toppingCost;

                    }

                    break;


            }
            return pizzaPrice;


        }





    }

}
