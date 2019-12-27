using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    /*
     *  Класс для полезных, функций которые должны быть доступны во многих местах
     *
     *  Не забывайте делать функции статическими  =)
     */
    class UsefullFunctions
    {
        /*
         * Хэндлер для TextBox'ов пропускает ввод только букв (пробел НЕ пропускает)
         */
        public static KeyPressEventHandler lettersOnly = new KeyPressEventHandler(LettersOnly);
        private static void LettersOnly(object sender, KeyPressEventArgs e) {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        /*
        * Хэндлер для TextBox'ов  НЕ пропускает пробел
        */
        public static KeyPressEventHandler noSpaces = new KeyPressEventHandler(NoSpaces);
        private static void NoSpaces(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
                e.Handled = true;
        }

        /*
         * Хэндлер для Control'ов на установку фокуса
         * */
        public static EventHandler OnSetFocus = new EventHandler(SetFocus);
        private static void SetFocus(object sender, EventArgs e) {
            ((Control)sender).BackColor = Color.LightYellow;
        }
        /*
         * Хэндлер для Control'ов на сброс фокуса
         * */
        public static EventHandler OnDropFocus = new EventHandler(DropFocus);
        private static void DropFocus(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = SystemColors.Window;
        }

        public static CancelEventHandler notEmpty = new CancelEventHandler(NotEmpty);
        private static void NotEmpty(object sender, CancelEventArgs e) {
            if (((Control)sender).Text == "") {
                e.Cancel = true;
            }
        }

    }
}
