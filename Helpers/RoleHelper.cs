namespace SysObiOnline.Helpers
{
    public static class RoleHelper
    {
        public static string GetRoleName(string role)
        {
            return role switch
            {
                "Admin" => "Administrator",
                "User" => "Regular User",
                _ => "Unknown Role"
            };
        }
    }
}
