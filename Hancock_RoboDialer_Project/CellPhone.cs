namespace Hancock_RoboDialer_Project
{
    internal class CellPhone : Phone
    {
        public CellPhone(string PhoneNumber, string CompanyName, string PhoneType)
    : base(PhoneNumber, CompanyName, PhoneType)
        {

        }

        public override string Dial()
        {
            return base.Dial().Replace(" using ", " using 1+");
        }
    }
}