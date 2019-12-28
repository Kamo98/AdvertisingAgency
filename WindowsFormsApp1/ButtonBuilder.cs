﻿using System;

namespace WindowsFormsApp1
{
    /*
     * Класс для построения кнопок
     * Кнопки должны добавляться в Controls элемента, на который они размещаются
     */
    class ButtonBuilder
    {
        /*
         * Функция добавляет кнопку, при нажати на которую открывается форма добавления сотрудника
         */ 
        public static System.Windows.Forms.Button Get_AddEmployeeBtn(int x = 20, int y = 50) {
            System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
            btn.Text = "Добавить сотрудника";
            btn.Click += new System.EventHandler(OpenEmployeeForm);
            btn.Location = new System.Drawing.Point(x, y);
            btn.Size = new System.Drawing.Size(150, 50);
            return btn;
        }

        private static void OpenEmployeeForm(object sender, EventArgs e) {
            EmployeeForm ef = new EmployeeForm(5);
            ef.ShowDialog();    //форма вызывается в модальном режиме
        }
    }
}
