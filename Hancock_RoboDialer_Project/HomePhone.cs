namespace Hancock_RoboDialer_Project
{
    internal class HomePhone : Phone
    {
        public HomePhone(string PhoneNumber, string CompanyName, string PhoneType)
            : base(PhoneNumber, CompanyName, PhoneType)
        {

        }

        public override string Dial()
        {
            return base.Dial();
        }
    }
}