using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;


class Program
{
    static void Main(string[] args)
    {
        // Find your Account SID and Auth Token at twilio.com/console
        // and set the environment variables. See http://twil.io/secure
        string accountSid = "TWILIO_ACCOUNT_SID";
        string authToken = "TWILIO_AUTH_TOKEN";

        TwilioClient.Init(accountSid, authToken);

        var message = MessageResource.Create(
            body: "You have a message from EnTech.",
            from: new Twilio.Types.PhoneNumber("+XXXXXXXXXXXX"),
            to: new Twilio.Types.PhoneNumber("+XXXXXXXXXXXX")
        );

        Console.WriteLine(message.Sid);
    }
}