namespace ConsoleApp2
{
    public class Car
    {
        private int _price;
        public string name;
        protected string number;
        internal bool electric;
        protected internal string marka;

        public Car(string a)
        {
            
        }
        public Car()
        {
            
        }
    }
    public class BMW : Car
    {
        public BMW(string b, string c) : base(b)
        {

        }
        public BMW()
        {
            
        }
    }
    public class Mercedes
    {
        
    }
}
