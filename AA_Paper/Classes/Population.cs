
namespace AA_Paper.Classes
{
    class Population
    {
        private readonly Element[] populationElements;
        private readonly int totalElements;

        public Population(int totalElements)
        {
            this.totalElements = totalElements;
            populationElements = new Element[totalElements];
            initializePopulation();
        }

        private void initializePopulation()
        {
            for (int i = 0; i < totalElements; i++)
            {
                populationElements[i] = new Element(i + 1, Direction.LEFT);
            }

            populationElements[0].direction = Direction.CENTER;
        }

        public bool doMagicStuff()
        {
            var allCenter = true;
            var indexBiggerNonZero = -1;
            var biggestValue = -1;

            for (int i = 0; i < totalElements; i++)
            {
                if (populationElements[i].direction != Direction.CENTER
                    && populationElements[i].value > biggestValue)
                {
                    allCenter = false;
                    indexBiggerNonZero = i;
                    biggestValue = populationElements[i].value;
                }
            }

            if (!allCenter)
            {
                Element aux;
                if (populationElements[indexBiggerNonZero].direction == Direction.LEFT)
                {
                    if (indexBiggerNonZero == 1 || populationElements[indexBiggerNonZero - 2].value>populationElements[indexBiggerNonZero].value)
                        populationElements[indexBiggerNonZero].direction = Direction.CENTER;
                    aux = populationElements[indexBiggerNonZero - 1];
                    populationElements[indexBiggerNonZero - 1] = populationElements[indexBiggerNonZero];
                    populationElements[indexBiggerNonZero] = aux;
                }
                else
                {
                    if (indexBiggerNonZero == totalElements - 2 || populationElements[indexBiggerNonZero + 2].value > populationElements[indexBiggerNonZero].value)
                        populationElements[indexBiggerNonZero].direction = Direction.CENTER;
                    aux = populationElements[indexBiggerNonZero + 1];
                    populationElements[indexBiggerNonZero + 1] = populationElements[indexBiggerNonZero];
                    populationElements[indexBiggerNonZero] = aux;
                }

                for (int i = 0; i < totalElements; i++)
                {
                    if (populationElements[i].value > biggestValue)
                    {
                        populationElements[i].direction = i < indexBiggerNonZero ? Direction.RIGHT : Direction.LEFT;
                    }
                }
            }

            return !allCenter;
        }

        public override string ToString()
        {
            string res = "";
            foreach (var populationElement in populationElements)
            {
                res += populationElement.value + " ";
            }

            return res;
        }
    }
}