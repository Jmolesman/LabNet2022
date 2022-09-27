namespace Lab.Ejercicio004.EF.Utils
{
    public static class SuppliersValidation
    {
        public static bool ValidateSupplier(string companyName, string contactName, string contactTitle)
        {
            if (!ValidateCompanyName(companyName))
            {
                return false;
            }

            if (!ValidateContactName(contactName))
            {
                return false;
            }
            if (!ValidateContactTitle(contactTitle))
            {
                return false;
            }
            
            return true;
        }

        private static bool ValidateCompanyName(string companyName)
        {
            if (companyName.Length > 40)
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(companyName))
            {
                return false;
            }
            return true;
        }

        private static bool ValidateContactName(string contactName)
        {
            if (contactName.Length > 30)
            {
                return false;
            }
            return true;
        }
        private static bool ValidateContactTitle(string contactTitle)
        {
            if (contactTitle.Length > 30)
            {
                return false;
            }
            return true;
        }
    }
}
