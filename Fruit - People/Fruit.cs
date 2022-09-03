

namespace FruitPeople
{
    internal class Fruit
    {
        public string fruit { get; set; }
        public string size { get; set; }
        public string color { get; set; }

        public Fruit()
        {
            fruit = String.Empty;
            size = String.Empty;
            color = String.Empty;
        }

        public Fruit(string _fruit, string _size, string _color)
        {
            fruit = _fruit;
            size = _size;
            color = _color;
        }

        public override string ToString()
        {
            return $"fruit [{fruit}], Size [{size}], Color [{color}] ";
        }
    }
}
