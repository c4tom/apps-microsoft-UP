using RegistroPonto.Models;

namespace RegistroPonto.DAL
{
    class SingletonContext
    {
        private SingletonContext() { }

        private static Context ctx;

        public static Context GetInstance()

        {
            if (ctx == null)
            {
                ctx = new Context();
            }
            return ctx;
        }
    }
}
