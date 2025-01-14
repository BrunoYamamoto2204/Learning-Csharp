namespace Aula127_Excecoes.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        // Construtores 
        public DomainException(string message) : base (message)
        { 
        }
    }
}