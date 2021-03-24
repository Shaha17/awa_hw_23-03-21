namespace DZ_23_03_21
{
    static class Memory
    {
        private static double memory = 0;

        public static void Clear()
        {
            memory = 0;
        }
        public static double Recall()
        {
            return memory;
        }
        public static void Store(double num)
        {
            memory = num;
        }
        public static void Plus(double num)
        {
            memory += num;
        }
    }
}
