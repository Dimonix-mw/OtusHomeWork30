namespace OtusHomeWork30.Entities
{
    /// <summary>
    /// абстрактный класс жилье
    /// </summary>
    public abstract class Housing
    {
        public float Square { get; set; }
        public int CountRooms { get; set; }
        public decimal Price { get; set; }
        public int Floors { get; set; }
        public Housing(float square, int countRooms, decimal price, int floors)
        {
            Square = square;
            CountRooms = countRooms;
            Price = price;
            Floors = floors;
        }
        public Housing() { }
    }
}
