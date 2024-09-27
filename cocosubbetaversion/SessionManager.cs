using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocosubbetaversion
{
    public static class SessionManager
    {
        public static string UserName { get; set; }
        public static string Email { get; set; }

        public static int? menu_id { get; set; } // Change the type to nullable int

        // Add other user-related properties as needed

        public static void ClearSession()
        {
            UserName = null;
            Email = null;
            menu_id = null;

            // Clear other properties
        }
    }
}
