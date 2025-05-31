namespace PetShopConsoleApp1.Compartilhado
{
    public abstract class EntidadeBase
    {
        public int Id { get; set; }
        public abstract void AtualizarRegistro(EntidadeBase registroEditado);

        public abstract string Validar();
    }

    public abstract class EntidadeBase<TEntidade> : EntidadeBase where TEntidade : EntidadeBase<TEntidade>
    {
        public override void AtualizarRegistro(EntidadeBase registroEditado)
        {
            AtualizarRegistro((TEntidade)registroEditado);
        }
        public abstract void AtualizarRegistro(TEntidade registroEditado);
    }

}
