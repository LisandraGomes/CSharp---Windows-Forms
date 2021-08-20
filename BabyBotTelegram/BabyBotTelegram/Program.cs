using System;
using Telegram.Bot;
using Telegram.Bot.Args;
using System.Threading.Tasks;
using System.Threading;

namespace BabyBotTelegram
{
    class Program
    {
        private static TelegramBotClient conecBot = new TelegramBotClient("1959736770:AAG9UMDj4VhOcEyM60R_Wy7C-7yTrxGQdmo");
        
        static void Main(string[] args)
        {
            conecBot.OnMessage += ConectionBot_OnMensage;
            conecBot.StartReceiving();
            Thread.Sleep(Timeout.Infinite);
            conecBot.StopReceiving();
        }
        private static void ConectionBot_OnMensage(object sender, MessageEventArgs e)
        {
            Console.WriteLine("Mensagem:' "+e.Message.Text+"'  ID: "+ e.Message.Chat.Id);
            if(e.Message.Text.ToUpper() == "OI")
            {
                if (e.Message.Chat.Id == 1638301066)
                {
                    conecBot.SendTextMessageAsync(e.Message.Chat.Id, "Olá, Mamãe!");
                    conecBot.SendTextMessageAsync(e.Message.Chat.Id, "Como vai você?");
                }
                else
                {
                    conecBot.SendTextMessageAsync(e.Message.Chat.Id, $"Olá, {e.Message.From.FirstName}");
                    conecBot.SendTextMessageAsync(e.Message.Chat.Id, "Como vai você?");
                }
            }
            if(e.Message.Text.ToUpper() == "Bem")
            {

            }
        }
    }
}
