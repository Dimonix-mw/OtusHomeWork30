using OtusHomeWork30.Interface;

namespace OtusHomeWork30.Entities
{
    public class Flat : Housing, IPrototype<Flat>, ICloneable
    {
        public int Floor { get; set; }

        public Flat(float square, int countRooms, decimal price, int floors, int floor) : base(square, countRooms, price, floors)
        {
            Floor = floor;
        }

        public Flat(Flat flat) : base(flat.Square, flat.CountRooms, flat.Price, flat.Floors)
        {
            Floor = flat.Floor;
        }

        public object Clone()
        {
            return Copy();
        }

        public virtual Flat Copy()
        {
            return new Flat(this);
        }
    }
}
