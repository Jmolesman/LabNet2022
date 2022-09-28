using System;

namespace Lab.Ejercicio004.EF.Utils
{
    public static class ProductsValidation
    {
        public static bool ValidateProduct(string productName, string quantityPerUnit, string unitPrice)
        {
            if (!ValidateProductName(productName))
            {
                return false;
            }

            if (!ValidateQuantityPerUnit(quantityPerUnit))
            {
                return false;
            }
            if (!ValidateUnitPrice(unitPrice))
            {
                return false;
            }

            return true;
        }

        private static bool ValidateProductName(string productName)
        {
            if (productName.Length > 40)
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(productName))
            {
                return false;
            }
            return true;
        }

        private static bool ValidateQuantityPerUnit(string quantityPerUnit)
        {
            if (quantityPerUnit.Length > 20)
            {
                return false;
            }
            return true;
        }

        private static bool ValidateUnitPrice(string unitPrice)
        {
            decimal price;
            if (string.IsNullOrWhiteSpace(unitPrice))
            {
                return true;
            }
            if (unitPrice.Contains("-"))
            {
                return false;
            }
            try
            {
                return decimal.TryParse(unitPrice, out price);
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public static int? ValidateComboBoxNullItem(object oItem)
        {
            string item = oItem.ToString();
            if (item.Contains("-"))
            {
                item = item.Substring(0, item.IndexOf('-'));
            }

            try
            {
                if (item == "No Category" || item == "No Supplier")
                {
                    return null;
                }
                else
                {
                    return int.Parse(item);
                }
            }
            catch (Exception)
            {

            }
            return null;
        }
    }
}
