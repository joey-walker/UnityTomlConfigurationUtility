namespace ZCorp.ConfigurationUtilities
{
    public class BaseConfiguration
    {

        public BaseConfiguration()
        {
         Graphics = new Graphics();
        }

        public Graphics Graphics { set; get;  }
    }
}