using KeyAuth;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Console = Colorful.Console;

namespace LicenseSystem
{
    internal class Program
    {
        public static api KeyAuthApp = new api(
    name: "", //your name
    ownerid: "", //your ownerid
    secret: "", //your secret
    version: "" //your version (For example 1.0)
);

        static void Main(string[] args)
        {
            Console.Title = "License System | Console";
            ascii();
            Console.Write("Init...", Color.Red);
            KeyAuthApp.init(); // fix the KeyAuthApp.init(); Error
            ascii();
            Console.Write("Enter your License Key >>> ", Color.Red);
            string key = Console.ReadLine();
            KeyAuthApp.license(key);

            if (!KeyAuthApp.response.success) //when the key is not valid
            {
                Console.WriteLine(KeyAuthApp.response.message, Color.Red);
                Thread.Sleep(2500);
                Environment.Exit(0);
            } 

            Console.WriteLine("Valid Licnese!", Color.Green); //when the key is valid
            Thread.Sleep(2500);
            Menu();
            Console.ReadLine();
        }

        static void Menu()
        {
            ascii();
            Console.Write("[1] ...\n[2] ...\n[3] ...\n\n>>> ", Color.BlueViolet);
            string input = Console.ReadLine();
            switch(input)
            {
                case "1":
                    // Do anything
                    break;
                case "2":
                    // Do anything
                    break;
                case "3":
                    // Do anything
                    break;
                default:
                    Console.WriteLine("Invalid Option!", Color.Red);
                    Thread.Sleep(2500);
                    Menu();
                    break;
            }
        }

        static void ascii()
        {
            Console.Clear();
            Console.WriteLine(@"
$$\   $$\                           $$$$$$\                        $$\                             
$$ | $$  |                         $$  __$$\                       $$ |                            
$$ |$$  / $$$$$$\  $$\   $$\       $$ /  \__|$$\   $$\  $$$$$$$\ $$$$$$\    $$$$$$\  $$$$$$\$$$$\  
$$$$$  / $$  __$$\ $$ |  $$ |      \$$$$$$\  $$ |  $$ |$$  _____|\_$$  _|  $$  __$$\ $$  _$$  _$$\ 
$$  $$<  $$$$$$$$ |$$ |  $$ |       \____$$\ $$ |  $$ |\$$$$$$\    $$ |    $$$$$$$$ |$$ / $$ / $$ |
$$ |\$$\ $$   ____|$$ |  $$ |      $$\   $$ |$$ |  $$ | \____$$\   $$ |$$\ $$   ____|$$ | $$ | $$ |
$$ | \$$\\$$$$$$$\ \$$$$$$$ |      \$$$$$$  |\$$$$$$$ |$$$$$$$  |  \$$$$  |\$$$$$$$\ $$ | $$ | $$ |
\__|  \__|\_______| \____$$ |       \______/  \____$$ |\_______/    \____/  \_______|\__| \__| \__|
                   $$\   $$ |                $$\   $$ |                                            
                   \$$$$$$  |                \$$$$$$  |                                            
                    \______/                  \______/                                             
", Color.BlueViolet); //get at https://patorjk.com/software/taag/

        }
    }
}
