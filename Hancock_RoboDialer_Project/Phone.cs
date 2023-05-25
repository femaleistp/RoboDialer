namespace Hancock_RoboDialer_Project
{
    internal abstract class Phone
    {
        string[] _phoneNumber = new string[10];
        string[] _companyName = new string[10];
        string[] _phoneType = new string[10];
        int c = -1; //_contactCount

        public Phone(string PhoneNumber, string CompanyName, string PhoneType)
        {
            c++;
            _phoneNumber[c] = PhoneNumber;
            _companyName[c] = CompanyName;
            _phoneType[c] = PhoneType;
        }

        public virtual string Dial()
        {
            return _companyName[c] + " is being dialed using " + _phoneNumber[c] + "...";
        }
    }
}