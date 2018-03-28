

namespace AA_Paper.Classes
{
    class Element
    {
        public int value;
        public Direction direction;

        public Element(int value, Direction direction)
        {
            this.value = value;
            this.direction = direction;
        }

        public override string ToString()
        {
            return value.ToString() + " " + direction;
        }
    }
}
