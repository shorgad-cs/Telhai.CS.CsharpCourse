using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telhai.CS.CsharpCourse.Services.Logging;

namespace Telhai.CS.CsharpCourse._03_OOP
{
    public class PlayList
    {
        private List<string> songs;
        private string name;


        /// <summary>
        /// 
        /// </summary>
        public PlayList() : this("NO NAME")
        {
           Logger.Log("In Empty Ctor",LogLevel.Debug);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public PlayList(string name)
        {
           //--No Prperty with setter , go to field
           //--this.name = name;
            Name = name; //set
            songs = new List<string>();
            
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get { return name.ToUpper(); }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    name = "<NO PLAYYLIST NAME>";
                }
                name = value;
            }
        }

        /// <summary>
        /// Auto Properties
        /// </summary>
        public int Id { get; set; }

        public int MyProperty { get; set; }

        /// <summary>
        /// Get The Count Of The Songs
        /// </summary>
        public int Count
        {
            get => songs.Count;  
        }

       // public int Count => songs.Count;


    }
}
