namespace Hancock_RoboDialer_Project
{
    internal abstract class Phone
    {
        string[] _phoneNumber = new string[10];
        string[] _companyName = new string[10];
        string[] _phoneType = new string[10];
        int contactIndex = -1;

        public Phone(string PhoneNumber, string CompanyName, string PhoneType)
        {
            contactIndex++;
            _phoneNumber[contactIndex] = PhoneNumber;
            _companyName[contactIndex] = CompanyName;
            _phoneType[contactIndex] = PhoneType;
        }

        public virtual string Dial()
        {
            return _companyName[contactIndex] + " is being dialed using " + _phoneNumber[contactIndex] + "...";
        }
    }
}