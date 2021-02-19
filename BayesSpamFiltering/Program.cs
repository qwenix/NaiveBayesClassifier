﻿using BayesSpamFiltering.Models;
using System;
using System.Windows.Forms;

namespace BayesSpamFiltering {
    static class Program {

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm form = new MainForm(new MainFormModel());
            Application.Run(form);
        }
    }
}
