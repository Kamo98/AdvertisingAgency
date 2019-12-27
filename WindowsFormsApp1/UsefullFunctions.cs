using System;
using System.Collections.Generic;
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

        public static void LettersOnly(object sender, KeyPressEventArgs e) {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
