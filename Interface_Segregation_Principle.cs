using System;

namespace Interface_Segregation_Principle
{

    public class Documents
    {

    }

    public interface IMachine
    {
        void Print(Documents d);
        void Scan(Documents d);
        void Fax(Documents d);
    }
    public interface IPrinter
    {
        void Print(Documents d);
    }

    public interface IScanner
    {
        void Scan(Documents d);
    }
    public interface IMultiFunctionalmachine:IScanner,IPrinter //...
    {

    }
    public class MultiFunctionalMachine : IMultiFunctionalmachine
    {
        private IPrinter printer;
        private IScanner scanner;
        public MultiFunctionalMachine(IPrinter printer, IScanner scanner)
        {
            if(printer == null)
            {
                throw new ArgumentNullException(paramName: nameof(printer));
            }
            if(scanner == null)
            {
                throw new ArgumentNullException(paramName: nameof(scanner));
            }
            this.printer = printer;
            this.scanner = scanner;
        }
        public void Print(Documents d)
        {
            printer.Print(d);
        }
        public void Sacn(Documents d)
        {
            scanner.Scan(d);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
