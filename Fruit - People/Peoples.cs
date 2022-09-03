
namespace FruitPeople
{
    internal class Peoples
    {
        public List<Peop> people { get; set; } = new List<Peop>();
        public Peoples()
        {

        }
        public void Show()
        {
            foreach (Peop peop in people)
            {
                Console.WriteLine(peop);
            }
        }


    }
}
