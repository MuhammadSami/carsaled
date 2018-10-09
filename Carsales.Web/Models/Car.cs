namespace Carsales.Web.Models
{
    public class Car : Vehicle
    {
        public string Engine { get; set; }
        public int Doors { get; set; }
        public int Wheels { get; set; }
        public BodyType BodyType { get; set;}
    }
}