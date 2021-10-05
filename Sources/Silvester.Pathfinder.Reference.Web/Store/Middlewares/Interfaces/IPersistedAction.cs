namespace Silvester.Pathfinder.Reference.Web.Store.Middlewares.Interfaces
{
    public interface IPersistedAction
    {
        string Identifier { get; }

        public string CreatePersistenceKey()
        {
            return $"{GetType().FullName}~{Identifier}";
        }
    }
}
