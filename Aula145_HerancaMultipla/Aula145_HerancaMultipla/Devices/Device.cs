
namespace Aula145_HerancaMultipla.Devices
{
    abstract class Device
    {
        // Atributos
        public int SerialNumber { get; set; }
           
        // Métodos
        public abstract void ProcessDoc(string document);
    }
}
