using System;

namespace Lab.Ejercicio004.EF.Utils
{
    public static class Helpers
    {
        public static int GetIdFromObject(object id)
        {
            try
            {
                return int.Parse(id.ToString());
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static bool ExecuteEntityLogic(int id)
        {
            return id == -1 ? false: true;
        }
    }
}
