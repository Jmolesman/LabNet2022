namespace Lab.Ejercicio004.EF.Utils
{
    public static class CategoriesValidation
    {
        public static bool ValidateCategory(string categoryName, string categoryDescription)
        {
            if (!ValidateCategoryName(categoryName))
            {
                return false;
            }

            if (!ValidateCategoryDescription(categoryDescription))
            {
                return false;
            }

            return true;
        }

        private static bool ValidateCategoryName(string categoryName)
        {
                if (categoryName.Length > 15)
                {
                    return false;
                }
            return true;
        }

        private static bool ValidateCategoryDescription(string categoryDescription)
        {
            if (categoryDescription.Length > 1_073_741_823)
            {
                return false;
            }
            return true;
        }
    }
}
