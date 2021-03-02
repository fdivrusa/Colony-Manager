using System;

namespace ColonyManager.Global
{
    public static class CurrentUser
    {
        public static long Id { get; set; }
        public static string Title { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string Email { get; set; }
        public static string Role { get; set; }
        public static DateTime CreatedDate { get; set; }
        public static bool IsVerified { get; set; }
        public static string JwtToken { get; set; }
    }
}
