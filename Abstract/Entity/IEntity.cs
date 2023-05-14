namespace CommServices.Core.Abstract.EntityCore
{
    public interface IEntity<T> where T : struct
    {
        T id { get; set; }
    }
}
