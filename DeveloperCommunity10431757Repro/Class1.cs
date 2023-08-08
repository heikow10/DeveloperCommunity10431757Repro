namespace DeveloperCommunity10431757Repro
{
    public class Class1
    {
        private readonly Dictionary<string, string?> _dictionary = new();

        public string? GetValue(string key)
        {
            if (_dictionary.ContainsKey(key))
            {
                return _dictionary[key];
            }

            return null;
        }
    }
}
