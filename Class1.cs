namespace BasicCodes
{
    internal class Guess
    {
        public static void Secret()
        {
            int a = 0;
            int secret = 24;

            Random rnd = new Random();
            a = rnd.Next(1, 10);

            while (true)
            {

                Console.WriteLine("Enter the value for a:");
                a = Convert.ToInt32(Console.ReadLine());


                if (a != secret)
                {
                    if (a < secret)
                    {
                        Console.WriteLine("Too Low");

                    }
                    else
                    {
                        Console.WriteLine("Too High");

                    }


                }
                else
                {
                    Console.WriteLine("Correct");
                    break;

                }
            }
        }
    }
}
