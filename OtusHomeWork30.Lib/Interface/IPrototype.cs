namespace OtusHomeWork30.Interface
{
    /// <summary>
    /// дженерик интерфейс IPrototype для реализации шаблона "Прототип"
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPrototype<T>
    {
        T Copy();
    }
}
