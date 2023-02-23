using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RheolauArmsManagmentSystemPrototype
{
    struct ErrorMessage
    {
        public string Message { get; set; }
        public bool IsError { get; set; }  
    }
    internal class Validator
    {
        public ErrorMessage validateStaff(StaffInfo staffInfo) // validate staff info 
        {
            ErrorMessage errorMessage = new ErrorMessage();
            errorMessage.IsError = false;
            errorMessage.Message = "";


            if (staffInfo.surname == "")
            {
                errorMessage.IsError = true;
                errorMessage.Message = "Surname cannot be Empty !";
            }
            if (staffInfo.forename == "")
            {
                errorMessage.IsError = true;
                errorMessage.Message = "Forename cannot be Empty !";
            }
            if (staffInfo.adress == "")
            {
                errorMessage.IsError = true;
                errorMessage.Message = "Adress cannot be Empty !";
            }
            if(staffInfo.phonenumber.Length != 11)
            {
                errorMessage.IsError = true;
                errorMessage.Message = "phone number must be 11 characters long !";
            }
            if (staffInfo.phonenumber == "")
            {
                errorMessage.IsError = true;
                errorMessage.Message = "Phone number cannot be Empty !";
            }
            return errorMessage;
        }

        public ErrorMessage validateBooking(BookingInfo bookingInfo) // validate staff info 
        {
            ErrorMessage errorMessage = new ErrorMessage();
            errorMessage.IsError = false;
            errorMessage.Message = "";


            if (bookingInfo.numberOfPeople <= 0)
            {
                errorMessage.IsError = true;
                errorMessage.Message = "Surname cannot be Empty !";
            }
            if (bookingInfo.bookingDate == "")
            {
                errorMessage.IsError = true;
                errorMessage.Message = "Forename cannot be Empty !";
            }
            if (bookingInfo.bookingTime == "")
            {
                errorMessage.IsError = true;
                errorMessage.Message = "Adress cannot be Empty !";
            }
            return errorMessage;
        }

        public ErrorMessage validateCustomer(CustomerInfo customerInfo) // validate staff info 
        {
            ErrorMessage errorMessage = new ErrorMessage();
            errorMessage.IsError = false;
            errorMessage.Message = "";


            if (customerInfo.surname == "")
            {
                errorMessage.IsError = true;
                errorMessage.Message = "Surname cannot be Empty !";
            }
            if (customerInfo.forename == "")
            {
                errorMessage.IsError = true;
                errorMessage.Message = "Forename cannot be Empty !";
            }
            if (customerInfo.phoneNumber.Length != 11)
            {
                errorMessage.IsError = true;
                errorMessage.Message = "phone number must be 11 characters long !";
            }
            if (customerInfo.phoneNumber == "")
            {
                errorMessage.IsError = true;
                errorMessage.Message = "Phone number cannot be Empty !";
            }
            return errorMessage;
        }
    }
}
