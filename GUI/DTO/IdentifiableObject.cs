namespace DTO
{
    public abstract class IdentifiableObject
    {
        public string ID { get; }

        public abstract string GetValueForInsertIntoSQL();

        public IdentifiableObject(string ID)
        {
            this.ID = ID;
        }
    }
}