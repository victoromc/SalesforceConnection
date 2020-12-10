using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerifyWSDLTest.sforce;

namespace VerifyWSDLTest
{
    class Program
    {
        private static SoapClient client;
        private static LoginResult loginResult;

        private static bool login()
        {
            client = new SoapClient();
            string acctName = "victoroliver@devaltostratus.com";
            string acctPw = "Crm@2020GbmqCF4k7IZsq27XYjjYfQzVo";
            try
            {
                loginResult = client.login(null, acctName, acctPw);
            }
            catch (Exception e)
            {
                Console.WriteLine("Mensagem de erro:  " + e.Message);
                Console.WriteLine(e.StackTrace);
                Console.Read();
                return false;
            }
            
            return true; //logado com sucesso
            

        }
        static void Main(string[] args)
        {
            if (login())
            {
                Console.WriteLine("Logado");
                // display some current login settings
                Console.Write("Service endpoint: " + loginResult.serverUrl + "\n");
                Console.Write("Username: " + loginResult.userInfo.userName + "\n");
                Console.Write("SessionId: " + loginResult.sessionId + "\n");
                Console.Write("Press any key to continue:\n");
                Console.ReadKey();
            }
        }
    }
}
