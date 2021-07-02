using System;

namespace arayuzler_interface
{
    class Program
    {
        static void Main(string[] args)
        {
           FileLogger fileLogger = new FileLogger();
           fileLogger.WriteLog();

           DatabaseLogger databaseLogger = new DatabaseLogger();
           databaseLogger.WriteLog();

           SmsLogger smsLogger = new SmsLogger();
           smsLogger.WriteLog();

           LogManager logManager = new LogManager(new FileLogger());
           logManager.WriteLog();

           Focus focus=new Focus();
           Console.WriteLine(focus.HangiMarkaninAraci().ToString());
           Console.WriteLine(focus.KacTekerlektenOlusur());
           Console.WriteLine(focus.StandartRengiNe().ToString());

           Civic civic=new Civic();
           Console.WriteLine(civic.HangiMarkaninAraci().ToString());
           Console.WriteLine(civic.KacTekerlektenOlusur());
           Console.WriteLine(civic.StandartRengiNe().ToString());
        }
    }
}
