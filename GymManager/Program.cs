namespace GymManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member m1 = new Member("asd", 5, true);
            Member m2 = new Member("as", 10, false);

            m1.CheckIn();
            Console.WriteLine(m1.Describe());
            Console.WriteLine(m2.Describe());
        }
    }
}
