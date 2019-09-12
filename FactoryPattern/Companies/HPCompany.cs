
namespace Factory.Companies
{
    public class HPCompany : ICompany
    {
        private string _name;
        public HPCompany(string name)
        {
            _name = name;
        }
        public string DoWork() => $"object successfully created from {_name}";

    }
}
