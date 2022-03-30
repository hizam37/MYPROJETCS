using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Myschool
{
    public partial class Form1 : Form 
    {

        public Form1() 
        {
            InitializeComponent(); //Активация окно существует подефулту вибрав WINFORM
        }


        private void Up_Button(object sender, EventArgs e)  //Вызовем кнопку и даем названия "Up_Button" для новую рассписанию которые будет поднимать элемент наверху
        {
            MoveUp(Current_schedule);   //Нажав на кнопку "Верх" мы поднимаем элемент находащися в рассписание на верху с помощу создано функция "MoveUp"
        }

        private void Down_Button(object sender, EventArgs e) //Вызовем кнопку и даем названия "Down_Button" для новую рассписанию которые будет поднимать элемент фнизу
        {
            MoveDown(Current_schedule); //Нажав на кнопку "Вниз" мы поднимаем элемент находащися в списоке на верху с помощу создано функция "MoveDown"
        }

        void MoveUp(ListBox myListBox)   //Создадим функцию которые будеть поднимать элемент наверху   
        {
            int selectedIndex = myListBox.SelectedIndex;  //Сохраним выбрано элемент от список по индекс

            if (selectedIndex > 0) //Если выбрано элемент после самый первый элемент по индекс 0 1 2 3 и т д 
            {
                myListBox.Items.Insert(selectedIndex - 1, myListBox.Items[selectedIndex]); //Тогда поднимаем в рассписании выбрано элемент наверху

                myListBox.Items.RemoveAt(selectedIndex + 1); //Удалим текущии элемент из его нахождения поднатия его наверху чтобы избежать от дубликация элемента в рассписании 

                myListBox.SelectedIndex = selectedIndex - 1; //Сохраним текущего индекс и вычитим его на -1 чтобы смогли поднят элемент наврху без разрева до индекс 0.
            }
        }

        void MoveDown(ListBox myListBox)    //Создадим функцию которые будеть поднимать элемент внизу  
        {
            int selectedIndex = myListBox.SelectedIndex;//Сохраним выбрано элемент от список по индекс

            if (selectedIndex < myListBox.Items.Count - 1 & selectedIndex != -1) //Если выбрано элемент по индекс 0 1 2 3 и т д меньше чем количество элементы на минус одного элемент в списке и элемент не является пустым.
            {
                myListBox.Items.Insert(selectedIndex + 2, myListBox.Items[selectedIndex]); //Тогда находим поднимаем элемент внизу на одну индексу.
                                                                                           //
                myListBox.Items.RemoveAt(selectedIndex); //Удалим текущии элемент из его нахождения поднатия его внизу чтобы избежать от дубликация элемента в рассписании

                myListBox.SelectedIndex = selectedIndex + 1; //Сохраним текущего индекс и вычитим его на -1 чтобы смогли поднят элемент внизу без разрева до конец индекса в рассписании.

            }
        }

        private void Form1_Load(object sender, EventArgs e)  //Окно  WINFORM
        {
            //Имплиментация не требуют 
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) //Вызовем Указатель даты и времени которые будеть исползован при исползовании кнопку "печатать" для показания дату создания тесктовое файл тип txt 
        {
            //Имплиментация не требуют 
        }




        private void Checkbox_For_Registration(object sender, EventArgs e) /*Вызовем флажок и даем назвния "Check_For_Registration" которые будеть
                                                                        исползован для добавления элемент в рассписании как подверждения*/
        {
            //Имплиментация не требуют 
        }

        private void Checkbox_For_Editing(object sender, EventArgs e) /*Вызовем флажок и даем назвния "Check_For_Editing" которые будеть
                                                                        исползован для редактировании в рассписании как подверждения*/
        {
            //Имплиментация не требуют 
        }

        private void Delete_From_Schedule_Button(object sender, EventArgs e) //Вызовем кнопку и даем названия "Delete_From_Schedule_Button" которые будеть удалит элемент в рассписании первой ветвь университета
        {
            if (Schedule_of_first_Section.SelectedItem != null & Schedule_of_second_Section.SelectedItem != null) //Если Выбрано элемент из двух рассписаниях одновремнно   
            {
                MessageBox.Show("Выбирай только один элемент"); //сообщаем пользовател выбрать только один элемент

                Schedule_of_first_Section.ClearSelected(); //Убирим выделение элемент рассписания первого ветвь 

                Schedule_of_second_Section.ClearSelected();  //Убирим выделение элемент рассписания второго ветвь 
            }
            else if (Current_schedule.SelectedItem != null) //Если Выбрано элемент из текущие рассписания  
            {
                MessageBox.Show($"Вы убрали {Current_schedule.SelectedItem}"); //Сообщить ползователь выбрано элемент

                MessageBox.Show("Замечания предыдущий элемент может быть удален из-за сходства в названии элемента"); //Сообщить ползователь что предыдущий элемент может быть удален из-за сходства в названии элемента

                Current_schedule.Items.Remove(Current_schedule.SelectedItem); //Удалим выбрано элемент от текущие рассписания
            }
            else if (Schedule_of_second_Section.SelectedItem != null) //Осталный условые работаеть аналогично и соответственно зависимо от место выбор элемента в списке
            {
                MessageBox.Show($"Вы убрали {Schedule_of_second_Section.SelectedItem}");

                MessageBox.Show("Замечания предыдущий элемент может быть удален из-за сходства в названии элемента");

                Schedule_of_second_Section.Items.Remove(Schedule_of_second_Section.SelectedItem);
            }
            else if (Schedule_of_first_Section.SelectedItem != null)
            {
                MessageBox.Show($"Вы убрали {Schedule_of_first_Section.SelectedItem}");

                MessageBox.Show("Замечания предыдущий элемент может быть удален из-за сходства в названии элемента");

                Schedule_of_first_Section.Items.Remove(Schedule_of_first_Section.SelectedItem);
            }
        }

        private void Add_For_Registration_Button(object sender, EventArgs e)  //Вызовем кнопку и даем названия "Add_For_Registration_Button" которые будеть добавлят элемент в рассписании первой ветвь университета
        {
            if (Check_to_comfirm_for_registration.Checked && First_section_of_SPBGASU.Checked) //Если подкчернули и быбрали первой ветвь унинверситета
            {
                Schedule_of_first_Section.Items.Add(Blank_for_adding_in_the_schedule.Text);  //Тогда даем разрешения на добаления текст в списке первой ветвь университета

                MessageBox.Show($"{Blank_for_adding_in_the_schedule.Text} добавлено");  //Сообщить пользователь какой текст он ввел в текстовой поле и что он уже добавлена в перый ветвь университета   

                Blank_for_adding_in_the_schedule.Clear(); //Очистим текстовой поль после добавления в перый ветвь университета

                Check_to_comfirm_for_registration.Checked = false; //Отключаем флажок после добавления в перый ветвь университета

                First_section_of_SPBGASU.Checked = false; //Отключаем Переключатель Добавлена в перый ветвь университета
            }
            else if (Check_to_comfirm_for_registration.Checked && Second_section_of_SPBGASU.Checked) //Условия работает аналогично кроме для другого переключателя являющие второй ветвь университета
            {
                Schedule_of_second_Section.Items.Add(Blank_for_adding_in_the_schedule.Text);

                MessageBox.Show($"{Blank_for_adding_in_the_schedule.Text} добавлено");

                Blank_for_adding_in_the_schedule.Clear();

                Check_to_comfirm_for_registration.Checked = false;

                Second_section_of_SPBGASU.Checked = false;
            }
            else //Инач 
            {
                MessageBox.Show("Пожалуйста проверай флажок и подключатель"); //Сообщить пользователь что он не подкчернул в флажок и не выбрал подключатель
            }
        }

        private void First_Section_Button(object sender, EventArgs e) /*Вызовем кнопку и даем названия "First_Section_Button" которые будеть добавит элемент из
                                                                         рассписании первого ветвь университета на новую рассписанию университета*/
        {
            if (Schedule_of_first_Section.SelectedItem != null && Schedule_of_second_Section.SelectedItem != null) //Если выбрано один элемент в двух разных рассписаниях  
            {
                Current_schedule.Enabled = false;     //Тогда отключаем текущие рассписания

                Schedule_of_second_Section.Enabled = false;  //Отключаем второй рассписания 

                Schedule_of_first_Section.Enabled = false;  //Отключаем первый рассписания

                add_from_first_section_to_new_schedule.Enabled = false; //отключаем кнопка добавление на новую рассписанию из рассписании первого ветвь университета

                MessageBox.Show("Добавление из двух разных расписаний не допускается!!!"); //Сообщить ползователь при использовании двух элемента из разных рассписанях 

                MessageBox.Show("чтобы повторно запустить приложение, нажмите на кнопку 'Перезапуск'"); //Далее Сообщить пользователь нажать на кнопку "Перезапуск".
            }
            if (Schedule_of_first_Section.SelectedIndex == -1)  //Если элемент не выбрано из первого рассписании при нажати на кнопку добавление на рассписании от первого ветвь 
            {
                MessageBox.Show($"Элемент от {First_section_As_LABEL.Text} не выбран");  //Сообщить пользователь что елемент из первого списка выбрано
            }
            else //Иначи 
            {
                SECTION_INDICATOR.Text = "Вы редактируйте расписание для университета " + SPBGASU_As_Groupbox.Text + " " + First_section_As_LABEL.Text; //Показываем ветвь и названия универсетита при выбрание эленент первого списка

                Current_schedule.Items.Add(Schedule_of_first_Section.SelectedItem);  //Добавим выбрано элемент из рассписании первого ветвь университета на новую рассписанию   
            }
        }

        private void Second_Section_Button(object sender, EventArgs e)  /*Вызовем кнопку и даем названия "Second_Section_Button" которы будеть добавит элемент из
                                                                         рассписании второго ветвь университета на новую рассписанию университета*/
        {
            if (Schedule_of_first_Section.SelectedItem != null & Schedule_of_second_Section.SelectedItem != null) /* Условия работает аналогично как предедущие кроме для другово кнопки
                                                                                                                    добавлающий элемент от списка второго ветвь университета на новую 
                                                                                                                    рассписанию университета */

            {
                Current_schedule.Enabled = false; 

                Schedule_of_second_Section.Enabled = false;

                Schedule_of_first_Section.Enabled = false;

                add_from_second_section_to_new_schedule.Enabled = false;

                MessageBox.Show("Добавление из двух разных расписаний не допускается!!!");

                MessageBox.Show("чтобы повторно запустить приложение, нажмите на кнопку 'Перезапуск'");
            }
            if (Schedule_of_second_Section.SelectedIndex == -1)
            {
                MessageBox.Show($"Элемент от {Second_section_As_LABEL.Text} не выбран");
            }
            else
            {
                SECTION_INDICATOR.Text = "Вы редактируйте расписание для университета " + SPBGASU_As_Groupbox.Text + " " + Second_section_As_LABEL.Text;

                Current_schedule.Items.Add(Schedule_of_second_Section.SelectedItem);
            }
        }

        private void Restart_Button(object sender, EventArgs e)  //Вызовем кнопку и даем названия "Restart_Button" которая перезапустит приложение
        {
            Current_schedule.Enabled = true; //При нажатии на кнопку "Перезапуск" включим текущие рассписания 

            Schedule_of_second_Section.Enabled = true; //Включим рассписания второго ветвь 

            Schedule_of_first_Section.Enabled = true; //Включим рассписания первого ветвь 

            Current_schedule.Items.Clear(); //Очистим элементы от текущии рассписания 

            Schedule_of_first_Section.ClearSelected();  //Убирим выделение элемент рассписания первого ветвь 

            Schedule_of_second_Section.ClearSelected(); //Убирим выделение элемент рассписания второго ветвь 

            SECTION_INDICATOR.Clear();  //Удалим текст от индикатора которые показывает место выбраного элемента из рассписании.

            add_from_first_section_to_new_schedule.Enabled = true; //Включим кнопка добавление от первого веть на новую рассписанию.

            add_from_second_section_to_new_schedule.Enabled = true; //Включим кнопка добавление от второго веть на новую рассписанию.
        }

        private void Print_Button(object sender, EventArgs e) //Вызовем кнопку и даем названия "Print_Button" которые будет распечатать элементы из нового списка на компьютер
        {
            if (Current_schedule.Items.Contains(Schedule_of_first_Section.Text)) //Если новая списка содержить элементы сииска первого секция университета
            {

                string dir = $"C:\\SPBGASU SCHEDULE"; //Тогда создадим каталог C:\\ и даем назания папка "SPBGASU SCHEDULE"

                if (!Directory.Exists(dir)) //Если папка не существует в каталог C:\\
                {
                    Directory.CreateDirectory(dir); //тогда создадим этот папку в каталог
                }
                else if (Directory.Exists(dir)) //Иначи если папка существует в каталог 
                {
                    MessageBox.Show($"папка уже сужествует в {dir}"); //тогда Сообщаем ползователь что папка уже существует в каталог  
                }

                string Path = $"{dir}\\Расписания {dateTimePicker1.Text} {SPBGASU_As_Groupbox.Text} {First_section_As_LABEL.Text}.txt"; //Далее находим файл тип txt в пути создано папка 

                StreamWriter Save_File = new StreamWriter(Path); //Активация своиства редактирования внутри текстом файлы тип txt 

                foreach (var item in Current_schedule.Items)  //Для каждого элемент находяшии в новом рассписании 
                {
                    Save_File.WriteLine(item); //Пишем эти элементы в txt файл

                    Save_File.WriteLine("****************************************");
                }
                Save_File.Close();  //После написание элементы в файл. Файл закрывается автоматический 

                MessageBox.Show("Поздравлю расписания создано :) "); //Собщить ползователь что расписания уже создано 

                MessageBox.Show($"Файл находиться в {dir}"); //Далее показать ползователь нахождения файла 

                MessageBox.Show("если вы хотите создать другое расписание, измените дату."); //Сообщить ползователь что если он хочет создать другую расписанию,надо изменить дату.
            }
            if (Current_schedule.Items.Contains(Schedule_of_second_Section.Text)) //Условия работает аналогично как предедущи кроме рассписания содержить элементы расписании второго ветвь университета
            {
                string Path = $"C:\\Users\\ISLAM\\Расписания {dateTimePicker1.Text} {SPBGASU_As_Groupbox.Text} {Second_section_As_LABEL.Text}.txt";

                StreamWriter Save_File = new StreamWriter(Path);

                foreach (var item in Current_schedule.Items)
                {
                    Save_File.WriteLine(item);

                    Save_File.WriteLine("****************************************");

                }
                Save_File.Close();

                MessageBox.Show("Поздравлю расписания создано :) ");

                MessageBox.Show("если вы хотите создать другое расписание, измените дату.");
            }
        }

        private void First_Section_As_Label(object sender, EventArgs e) //Вызовем ярлык и даем названия "First_Section_As_Label" которые являается ярлык рассписания первого ветвь университета
        {
            //Имплиментация не требуют 
        }

        private void Second_Section_As_Label(object sender, EventArgs e)  //Вызовем ярлык и даем названия "First_Section_As_Label" которые являается ярлык рассписания второго ветвь университета
        {
            //Имплиментация не требуют 
        }

        private void Edit_Inside_Schedule_Button(object sender, EventArgs e) /*Вызовем кнопку и даем названия "Edit_Inside_Schedule_Button"
                                                                             которые будеть позволять ползователь редактироват элементы в рассписании для первого и второго ветвь университета*/
        {
            if (Check_to_comfirm_for_change.Checked && Schedule_of_first_Section.SelectedIndex != -1 || Check_to_comfirm_for_change.Checked && Schedule_of_second_Section.SelectedIndex != -1)/*Если ползователь 
                подкчернул в флажок и элемент рассписания первого ветвь университета выбран или ползователь
                подкчернул в флажок и элемент рассписания второго ветвь университета выбран */
            {
                int Index_Of_First_Schedule = Schedule_of_first_Section.SelectedIndex; //Сохраним выбрано элемент рассписании первого ветвь университета по индексу 0 1 2 3 и т д

                if (Schedule_of_first_Section.SelectedItem != null) //Если выбран элемент списка первого ветвь университета 
                {
                    Schedule_of_first_Section.Items.RemoveAt(Schedule_of_first_Section.SelectedIndex);//тогда удалим выбрано элемент рассписании первого ветвь университета по индексу

                    Schedule_of_first_Section.Items.Insert(Index_Of_First_Schedule, Blank_for_editing_inside_the_schedule.Text);//Вместо удален элемент вставим вводимый текст пользователя
                                                                                                                                
                    Blank_for_editing_inside_the_schedule.Clear();//Очистим текстовое после его использования  

                    Check_to_comfirm_for_change.Checked = false;//Отключаем флажок после его использования 
                }
                int Index_Of_Second_Schedule = Schedule_of_second_Section.SelectedIndex; //Отсуда реализация аналогично как предедущие кроме для рассписании второго ветвь университета по индексу 

                if (Schedule_of_second_Section.SelectedItem != null)
                {
                    Schedule_of_second_Section.Items.RemoveAt(Schedule_of_second_Section.SelectedIndex);

                    Schedule_of_second_Section.Items.Insert(Index_Of_Second_Schedule, Blank_for_editing_inside_the_schedule.Text);

                    Blank_for_editing_inside_the_schedule.Clear();
                }
            }
            else //Иначи
            {
                MessageBox.Show($"Пожалуйста, подкчернуте и выбирайте элемент от {First_section_As_LABEL.Text} или {Second_section_As_LABEL.Text} и введите в текстовое поле");/*сообщить ползователь что надо
                подкчернуть и выбирать элемент от рассписании первого ветвь университета или рассписания второго ветвь университета и  ввести в текстовое поле*/
            }

        }

        private void Registration_In_SPBGASU_As_GroupBox(object sender, EventArgs e) //Вызовем Групповой ящик и лаем названия "Registration_In_SPBGASU_As_GroupBox" которые будеть сожержить подключателы и одина кнопка, один флажок и один текстовое поле для регистрация в расписания 
        {
            //Имплиментация не требуют 
        }

        private void Editing_Inside_Schedule_As_Groupbox(object sender, EventArgs e) //Вызовем Групповой ящик и даем названия "Editing_Inside_Schedule_As_Groupbox" которые будеть сожержить одина кнопка,один флажок и один текстовое поле для редактировании в расписании
        {
            //Имплиментация не требуют 
        }

        private void Adding_From_SPBGASU_To_The_New_Schedule_As_Groupbox(object sender, EventArgs e) //Вызовем Групповой ящик и даем названия  "Adding_From_SPBGASU_To_The_New_Schedule_As_Groupbox" которые содержить две кнопке для добавления элементы из двух разных ветвь расписанях на новую расписаню 
        {
            //Имплиментация не требуют 
        }

        private void Addtional_Functions_As_Groupbox(object sender, EventArgs e)  //Вызовем Групповой ящик и даем названия  "Addtional_Functions_As_Groupbox" которые содержить три кнопке для удаления,печатание и перезапуск элементы в расписании соответственно зависимо от ввод пользователя 
        {
            //Имплиментация не требуют 
        }

        private void SPBGASU_As_GROUPBOX(object sender, EventArgs e) //Вызовем Групповой ящик и даем названия  "SPBGASU_As_GROUPBOX" которые содержить две разных ветвь расписанях
        {
            //Имплиментация не требуют 
        }

        private void Current_Schedule_As_Groupbox(object sender, EventArgs e) //Вызовем Групповой ящик и даем названия  "Current_Schedule_As_Groupbox" которые содержить две разных ветвь расписанях
        {
            //Имплиментация не требуют 
        }

        private void Organize_Inside_Current_Schedule_As_Groupbox(object sender, EventArgs e) //Вызовем Групповой ящик и даем названия  "Organize_Inside_Current_Schedule_As" которые содержить две кнопке верх и вниз соответственно для организации элементов в расписании
        {
            //Имплиментация не требуют 
        }

        private void Editing_Inside_Schedule_As_Textbox(object sender, EventArgs e) //Вызовем текстовое поле и даем названия  "Editing_Inside_Schedule_As_Textbox" которые будеть содержат текст пользователя для редактировании в расписании 
        {
            //Имплиментация не требуют 
        }

        private void Registration_Inside_Schedule_As_Textbox(object sender, EventArgs e) //Вызовем текстовое поле и даем названия  "Registration_Inside_Schedule_As_Textbox" которые будеть содержат текст пользователя для регистрации
        {
            //Имплиментация не требуют 
        }

        private void Section_Indicator_As_Textbox(object sender, EventArgs e) //Вызовем текстовое поле и даем названия  "Section_Indicator_As_Textbox" которые будеть показат выбрано ветвь университета
        {
            //Имплиментация не требуют 
        }

        private void Current_Schedule_As_Listbox(object sender, EventArgs e) //Вызовем Список и даем названия  "Current_Schedule_As_Listbox" которые будеть содержат эдементы в новую расписании 
        {
            //При выбрания элемент из новой списока   
            Schedule_of_first_Section.ClearSelected(); //Убирается выделения элемент из первой рассписания   

            Schedule_of_second_Section.ClearSelected(); //Убирается выделения элемент из второй рассписания 
        }

        private void Second_Section_Schedule_As_Listbox(object sender, EventArgs e) //Вызовем Групповой ящик и лаем названия  "SPBGASU_As_GROUPBOX" которые содержить две разных ветвь расписанях
        {
            //Имплиментация не требуют 
        }

        private void First_Section_Schedule_As_Listbox(object sender, EventArgs e) //Вызовем Групповой ящик и лаем названия  "SPBGASU_As_GROUPBOX" которые содержить две разных ветвь расписанях
        {
            //Имплиментация не требуют 
        }

        private void First_section_of_SPBGASU_As_RadioButton(object sender, EventArgs e) //Вызовем Групповой ящик и лаем названия  "SPBGASU_As_GROUPBOX" которые содержить две разных ветвь расписанях
        {
            //Имплиментация не требуют 
        }

        private void Second_Section_As_RadioButton(object sender, EventArgs e) //Вызовем Групповой ящик и лаем названия  "SPBGASU_As_GROUPBOX" которые содержить две разных ветвь расписанях
        {
            //Имплиментация не требуют 
        }
    }
}

       

   
    

