namespace Objects.Services
{
    public class TimeService
    {
        public string GetTime()
        {
            return DateTime.Now.ToString("HH:mm:ss"); 
        }
    }
}
