namespace ChatRESTAPI.Core
{
    public interface ISerializable<T>
    {
        string Serialize(T obj);

        T Deserialize(string value);
    }
}