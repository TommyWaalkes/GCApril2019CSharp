namespace AnimalAbstract
{
    class Dog : Animal
    {
        public override string MakeSound()
        {
            return "woof";
        }

        public override string GetFood()
        {
            return "treats";
        }

    }
}