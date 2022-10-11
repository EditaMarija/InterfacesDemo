namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chair officeChair = new Chair("Brown", "Plastic");
            Chair gamingChair = new Chair("Red", "Wood");

            Car damagedCar = new Car(80f, "Blue");

            //add chairs to list of objects nearby the car,so they get destroyed with a car
            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(gamingChair);

            //destroy the car
            damagedCar.Destroy();
        }
    }
}