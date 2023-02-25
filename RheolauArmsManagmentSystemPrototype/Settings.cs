namespace RheolauArmsManagmentSystemPrototype
{
    //constant file locations
    internal class Settings
    {
        public string UserDetailsFile { get; } = @"DataBase\User.txt";
        public string StaffDetailsFile { get; } = @"DataBase\Staff.txt";
        public string SundayBookingsFile { get; } = @"DataBase\SundayBookings.txt";
        public string ThursdayBookingsFile { get; } = @"DataBase\ThursdayBookings.txt";
        public string CustomersFile { get; } = @"DataBase\Customer.txt";
        public string StockFile { get; } = @"DataBase\Stock.txt";
        public string ItemFile { get; } = @"DataBase\Items.txt";
    }
}
