namespace LastikFabrikasi
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Uretim u = new Uretim();
            u.BilgiAl();
            u.UretimYapılmayanGunBul();
            u.EnAzUretimYapilanGunBul();
            u.EnFazlaUretimYapilanHaftaBul();
        }
    }
}