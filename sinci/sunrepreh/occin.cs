public class SecureKeyManager
{
    private readonly string _key;

    public SecureKeyManager(string key)
    {
        if (string.IsNullOrEmpty(key))
        {
            throw new ArgumentException("Key cannot be null or empty.", nameof(key));
        }

        _key = key;
    }

    public string GetKey()
    {
        return _key;
    }
}
