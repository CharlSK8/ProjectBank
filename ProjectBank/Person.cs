namespace ProjectBank
{
    public abstract class Person
    {
        public abstract string GetName();

        public string GetCountry()
        {
            return "Colombia"; 
        }
    }
}