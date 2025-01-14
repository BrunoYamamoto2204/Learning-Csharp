namespace Aula128_Fixacao.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        // Construtores 
        public DomainException(string message) : base (message)
        { 
        }
    }
}