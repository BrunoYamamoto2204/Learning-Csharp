namespace Aula128_Fixacao.Entities.Exceptions
{
    class DomainException : ApplicationException
    {   
        // Heradada, não é ncessário atribuir novamente o message 

        // Construtores 
        public DomainException(string message) : base (message)
        { 
        }
    }
}