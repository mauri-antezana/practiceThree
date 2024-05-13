namespace UPB.AppLogic.Managers.Exceptions
{
    public class WrongInputException : Exception
    {
        public WrongInputException() { }
        public WrongInputException(string message) : base(message) { }

        public string GetExceptionMessage()
        {
            return "Wrong input exception: " + Message;
        }
    }
}
