using OtusHomeWork30.Interface;

namespace OtusHomeWork30.Entities
{
    /// <summary>
    /// класс дом наследуется от класса квартира
    /// </summary>
    public class House : Flat, IPrototype<House>, ICloneable
    {
        public float SquareRegion { get; set; }

        public House() { }
        public House(float square, int countRooms, decimal price, int floors, int floor, float squareRegion) 
            : base(square, countRooms, price, floors, floor)
        {
            SquareRegion = squareRegion;
        }

        public House(House house) : base(house.Square, house.CountRooms, house.Price, house.Floors, house.Floor)
        {
            SquareRegion = house.SquareRegion;
        }

        public override House Copy()
        {
            return new House(this);
        }
       
    }
}
