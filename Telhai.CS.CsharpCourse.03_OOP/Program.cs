namespace Telhai.CS.CsharpCourse._03_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayList l1 = new PlayList();
            Type type =  l1.GetType();
            type.ToString();

            //--We Need Validation Here
            // l1.name = string.Empty

            l1.Name = "CHIL_OUT";//set
            var name_playList = l1.Name;//get
            l1.Name += " Playlist";
            l1.Name = l1.Name +" Playlist";

            int count = l1.Count;


            PlayList l2 = new PlayList();
            l2.Name = "TECHNO";
            l2.Id = 1000;

            PlayList l3 = new PlayList("AMBIENT");

            //--Initializer
            PlayList l4 = new PlayList { Id=1001, Name="LOAZIT"};


            Console.ReadKey();
        }
    }
}
