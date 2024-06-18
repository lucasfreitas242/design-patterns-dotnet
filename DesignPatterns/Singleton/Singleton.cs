namespace Singleton
{
    public class Singleton
    {
        private static Singleton instance = new Singleton();

        public int value = 0;

        private Singleton()
        {
            Random rnd = new Random();
            value = rnd.Next(20);
        }

        public static Singleton Instance { get { return instance; } }
    }
}
