namespace ModelLibrary
{
    public class VersionInfo
    {
        private int id;
        public int Id { get => id; }

        public void SetId(int value)
        {
            id = value;
        }

        private string name;
        public string Name { get => name;}

        public void SetName(string value)
        {
            name = value;
        }


    }
}
