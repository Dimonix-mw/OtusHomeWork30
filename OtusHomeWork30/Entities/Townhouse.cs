using OtusHomeWork30.Interface;

namespace OtusHomeWork30.Entities
{
    public class Townhouse : House, IPrototype<Townhouse>, ICloneable
    {
        public int CountFlats { get; set; }

        public Townhouse(float square, int countRooms, decimal price, int floors, int floor, float squareRegion, int countFlats) 
            : base(square, countRooms, price, floors, floor, squareRegion)
        {
            CountFlats = countFlats;
        }

        public Townhouse(Townhouse townhouse) : base(townhouse.Square, townhouse.CountRooms, townhouse.Price, 
            townhouse.Floors, townhouse.Floor, townhouse.SquareRegion)
        {
            CountFlats = townhouse.CountFlats;
        }

        public override Townhouse Copy()
        {
            return new Townhouse(this);
        }
       
    }
}
