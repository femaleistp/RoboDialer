// Brittany Hancock
// IT112
// NOTES: none
// BEHAVIORS NOT IMPLEMENTED AND WHY: n/a
namespace Hancock_RoboDialer_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] contactList = { "(303) 985-5060", "CompuTest", "1", "(603) 532-4123", "Curtis Manufacturing", "2", "(800) 876-2524", "Data Functions", "1", "(708) 397-3330", "Donnay Repair", "1", 
                "(360) 434-3894" , "ErgoNomic Inc", "1", "(800) 969-4374", "ErgoSource", "1", "(800) 874-8527", "Fox Bay Industries", "2", "(800) 545-6254", "Glare-Guard", "2", "(407) 783-6641", 
                "Hazard Comm Specialists", "2", "(714) 472-4409", "Komfort Support", "2" };

            Phone[] rolodex = new Phone[10];
            int rolodexIndex = -1;
            for (int i = 0; i < contactList.Length; i += 3)
            {
                rolodexIndex++;
                if (contactList[i + 2] == "1")
                    rolodex[rolodexIndex] = new HomePhone(contactList[i], contactList[i + 1], contactList[i + 2]);

                else
                {
                    rolodex[rolodexIndex] = new CellPhone(contactList[i], contactList[i + 1], contactList[i + 2]);
                }
            }

            for (int i = 0; i < rolodex.Length; i++)
            {
                Console.WriteLine(rolodex[i].Dial());
            }
        }
    }
}