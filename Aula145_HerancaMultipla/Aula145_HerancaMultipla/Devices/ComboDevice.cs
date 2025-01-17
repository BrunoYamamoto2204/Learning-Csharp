
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace Aula145_HerancaMultipla.Devices
{
    class ComboDevice : Device, IScanner, IPrinter {


        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Combodevice processing " + document); 
        }
        public string Scan() {
            return "Combodevice scan result";
        }
        public void Print(string document) {
            Console.WriteLine("Combo Device print " + document);
        }
    }
}
