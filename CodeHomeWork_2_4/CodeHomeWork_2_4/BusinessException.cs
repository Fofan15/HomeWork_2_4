namespace CodeHomeWork_2_4
{
    public class BusinessException : Exception
    {
        public string ExceptionMessage { get; set; }

        public BusinessException(string message)
        {
            ExceptionMessage = message;
        }
    }
}
