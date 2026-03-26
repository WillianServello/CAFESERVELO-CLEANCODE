namespace models_dto.Models.Abstract
{
    public abstract class EntitidadeAbstract
    {
        
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Nome { get; private set; } = string.Empty;
        public DateTime DataCadastro { get; private set; } = DateTime.UtcNow;
        public DateTime DataUpdateCadastro { get; private set; } = DateTime.UtcNow;
        public bool IsActive { get; private set; } = true;
        protected EntitidadeAbstract(){}
        public void SetIsActive() => IsActive = true;
        public void SetIsInactive() => IsActive = false;
    }
}
