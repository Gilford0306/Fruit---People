
namespace FruitPeople
{
    internal class Peop
    {

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string number { get; set; }

        public Peop()
        {
            firstName = String.Empty;
            lastName = String.Empty;
            gender = String.Empty;
            age = 0;
            number = String.Empty;
        }
        public Peop(string first, string last, string _gender, int _age, string numb)
        {
            firstName = first;
            lastName = last;
            gender = _gender;
            age = _age;
            number = numb;
        }
        public override string ToString()
        {
            return $"Firstname [{firstName}], Lastname [{lastName}],Gender [{gender}] ,Age [{age}], Number [{number}]";
        }

    }
}
