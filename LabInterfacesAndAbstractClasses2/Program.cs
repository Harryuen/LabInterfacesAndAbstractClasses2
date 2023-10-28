namespace LabInterfacesAndAbstractClasses2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Step 4: Test with a Dog object
            Console.Write("Enter a dog's name: ");
            string dogName = Console.ReadLine();

            Dog dog = new Dog();
            dog.SetName(dogName);
            dog.SetColour("Brown");
            dog.SetAge(3);

            Console.WriteLine("Dog's Name: " + dog.GetName());
            Console.WriteLine("Dog's Colour: " + dog.GetColour());
            Console.WriteLine("Dog's Age: " + dog.GetAge());

            Console.Write("Dog's Eating Habit: ");
            dog.Eat();

            // Step 5: Test with a Cat object
            Console.Write("Enter a cat's name: ");
            string catName = Console.ReadLine();

            Cat cat = new Cat();
            cat.SetName(catName);
            cat.SetColour("Gray");
            cat.SetAge(2);

            Console.WriteLine("Cat's Name: " + cat.GetName());
            Console.WriteLine("Cat's Colour: " + cat.GetColour());
            Console.WriteLine("Cat's Age: " + cat.GetAge());

            Console.Write("Cat's Eating Habit: ");
            cat.Eat();
        }
    }
}