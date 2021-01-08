namespace datingStuff
{
    static class Data
    {
        public static string connString { get; set; } = Properties.Settings.Default["dating_stuffConnectionString"].ToString();

        public static string currentUser { get; set; } = "admin";
    }
}
