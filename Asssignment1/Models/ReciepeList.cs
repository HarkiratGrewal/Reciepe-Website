using System.Collections.Generic;

namespace Asssignment1.Models
{
    public class ReciepeList
    {
        private static readonly List<ReciepeModel> reciepes = new List<ReciepeModel>();

        public static IEnumerable<ReciepeModel> Reciepes => reciepes;

        public static void AddReciepe(ReciepeModel reciepe)
        {
            reciepes.Add(reciepe);
        }

        //Adding few models
    }
}
