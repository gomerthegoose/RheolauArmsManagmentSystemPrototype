namespace RheolauArmsManagmentSystemPrototype
{
    /// <summary>
    /// 
    /// each struct is used to store a single enty 
    /// an array will then be used to store the file in a easier way to access
    /// 
    /// </summary>
    struct BookingInfo
    {
        public string RawData; // raw single entry data from file
        public int bookingID; // primary key for booking entry
        public int customerID; // foreign key to identify related customer entry 
        public int numberOfPeople; // number of people on booking
        public string bookingDate; // the date of the booking 
        public string bookingTime; // the time of the booking 
    }
    struct CustomerInfo
    {
        public string RawData; // raw single entry data from file
        public int customerID; // primary key for customer entry
        public string surname; // customer surname
        public string forename; // customet forename 
        public string phoneNumber; // customer forename
        public string email; // customer email
    }
    struct StaffInfo
    {
        public string RawData; // raw single entry data from file
        public int staffID; // primary key for staff entry
        public int userID; // foreign key to identify related user entry 
        public string surname; // staff surname 
        public string forename; // staff forename
        public string adress; // staff adress
        public string phonenumber; // staff phone number
        public string DOB; // staff date of birth 
        public string email; // staff email
    }
    public struct UserInfo //used to store usr info
    {
        public string RawData; // raw single entry data from file
        public int UserID; // primary key for user entry
        public string Username; // users password
        public string password; // users password
        public int accessLevel; // users access level
    }
    struct StockInfo
    {
        public string RawData; // raw single entry data from file
        public int StockID; // primary key for stock entry
        public int ItemID; // foreign key to identify related item 
        public int Quantity; //     
    }
    struct ItemInfo
    {
        public string RawData; // raw single entry data from file
        public int ItemID; // primary key for stock entry
        public string Description; // item description
        public string location; // location of item
    }


}
