﻿using kayıt_ol.kütüphane;
using System;
using System.Windows.Forms;

namespace kayıt_ol
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GirisYap());
        }
    }
}
