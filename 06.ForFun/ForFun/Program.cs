using System;
//Play happybirthday by beep :)
//Looks like some tone wasn't correct.......just 4 fun.
namespace ForFun
{
    class Program
    {
        const int DO = 262;
        const int RE = 294;
        const int MI = 330;
        const int FA = 349;
        const int SO = 392;
        const int LA = 440;
        const int SI = 494;
        const int DO_H = 523;
        const int RE_H = 587;
        const int MI_H = 659;
        const int FA_H = 698;
        const int SO_H = 784;
        const int LA_H = 880;
        const int SI_H = 988;

        static void Main(string[] args)
        {
            int[] happyBirthday = { SO, SO,LA,SO,DO_H,SI,SO,SO,LA,RE_H,DO_H,SO,
                                        SO,SO_H,MI_H,DO_H,SI,LA,FA_H,FA_H,MI_H,DO_H,RE_H,DO_H };
            for (int i = 0; i < happyBirthday.Length; i++)
            {
                Console.Beep(happyBirthday[i],700);
            }
        }
    }
}
