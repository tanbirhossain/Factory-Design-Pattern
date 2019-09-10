
namespace Factory.Companies
{
    public class AppleCompany : ICompany
    {
        private string _name;
        public AppleCompany(string name)
        {
            _name = name;
        }

        public string DoWork() => $"object successfully created from {_name}";

    }
}
