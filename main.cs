
using System;
class Values {
  static void Main() {
            int number;
            int age;
            string phonenumber;
            string mail;
            int total=0;
            Console.Write("How many personnel will be recorded =");
            total = Convert.ToInt32(Console.ReadLine());
            if(total>0){
                
            }
            else{
                Console.Write("How many personnel will be recorded =");
                total = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine();
            string[] valuepersonnel = new string[total];
            
            int n = 0;
            
            for(int i=0;i<total;i++)
            {
                Console.WriteLine("-----Personnel-----");
                Console.Write("Personnel 1 enter your name =");
                valuepersonnel[i]=Console.ReadLine();
                Console.Write("Personnel 1 enter your surnamename =");
                valuepersonnel[i]=Console.ReadLine();
                Console.Write("Personnel 1 enter your age =");
                age=Convert.ToInt32(Console.ReadLine());
                if(age > 0){
                    
                }
                else{
                    Console.Write("Personnel 1 enter your age =");
                    age=Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("Personnel 1 enter your mail =");
                mail=Console.ReadLine();
                if(mail.Contains("@") && mail.Contains(".com")){
                    
                }
                else{
                    Console.WriteLine("Personnel 1 enter your mail =");
                    mail=Console.ReadLine();
                    continue ;
                }
                Console.Write("Personnel 1 enter your phone number =");
                phonenumber=Console.ReadLine();
                if(phonenumber.Length == 11){
                    
                }
                else{
                    Console.WriteLine("Entered Phone Number is Invalid = ");
                    Console.Write("Personnel 1 enter your phone number =");
                    phonenumber=Console.ReadLine();
                    continue;
                }
                
                Console.WriteLine(++n + "kişi KAYDEDİDİLDİ");
                
                string fileName = $@"{Directory.GetCurrentDirectory()}\Records.txt";
                string writeText = ""; //Dosyaya eklenecek metinFileStream 
                fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                fs.Close();
                File.AppendAllText(fileName, Environment.NewLine + writeText);
                
                
            }
 
  }
}