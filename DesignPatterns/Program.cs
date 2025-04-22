using DesignPatterns.AbstractFactory;
using DesignPatterns.Adapter;
using DesignPatterns.Factory;
using DesignPatterns.Singleton;

class Program
{
    static void Main(string[] args)
    {


        #region AbstractFactory
        IUIFactory factory;

        string os = "mac";

        factory = os.ToLower() switch
        {
            "mac" => new MacUIFactory(),
            "windows" => new WindowsUIFactory(),
            _ => throw new ArgumentException("Unsupported Operating System")
        };

        var app = new Application(factory);
        app.RenderUI();

        #endregion

        #region Factory
        //Calling Factory method
        SendNotification("email", "John.William@gmail.com", "Hi John!");
        #endregion
            
        #region Singleton
        Console.WriteLine(GetStringFromConfiguration("AppName"));
        #endregion

        #region Adapter
        IPaymentProcessor payment = new StripeAdapter(new StripePayment());
        payment.Pay(24);

        #endregion
    }
    /// <summary>
    /// Send Notification based on the type. Factor Pattern
    /// </summary>
    /// <param name="type"></param>
    /// <param name="recepient"></param>
    /// <param name="message"></param>
    public static void SendNotification(string type, string recepient, string message)
    {
        var sender = NotificationFactory.CreateSender(type);
        sender.Send(recepient, message);
    }

    /// <summary>
    /// Get string fron configuration service using Singleton Pattern
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public static string GetStringFromConfiguration(string key)
    => AppConfigurationService.Instance.GetSetting(key);

}