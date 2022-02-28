using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace XML_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument first_file = new XmlDocument();      //Создадим обЪект xml
            first_file.Load(name_of_xml_first_file.Text);         //Загружаем перый xml файл 
            XmlElement element_of_first_file = first_file.DocumentElement; // Создадим обЬект элемент xml
            XmlNodeList elemList_of_first_file = element_of_first_file.GetElementsByTagName(name_of_tag_of_first_xml_file.Text);  //Получаем элемент xml через названия тег
            XmlDocument second_file = new XmlDocument();  //Создадим обЪект xml
            second_file.Load(name_of_xml_second_file.Text); //Загружаем второй xml файл 
            XmlElement element_of_second_file = second_file.DocumentElement; // Создадим обЬект элемент xml
            XmlNodeList elemList_of_second_file = element_of_second_file.GetElementsByTagName(name_of_tag_of_second_xml_file.Text); //Получаем элемент xml через названия тег
            for (int i = 0; i < elemList_of_second_file.Count; i++)       //Выводим тег и элемент цикличиский зависимо от количества элементов внутри xml файл.
            {
                if (elemList_of_first_file[i].InnerText != elemList_of_second_file[i].InnerText)  //Условия которые ищет сходства и обнаруженные различия между двумями файлями "xml". 
                {
                    listBox1.Items.Add("обнаруженные различия");
                    listBox1.Items.Add($"Первый файл {name_of_xml_first_file.Text}");
                    listBox1.Items.Add($"Названия тег {elemList_of_first_file[i].Name} Элемент тега {elemList_of_first_file[i].InnerText}");
                    listBox1.Items.Add($"Второй фаил {name_of_xml_second_file.Text}");
                    listBox1.Items.Add($"Названия тег {elemList_of_second_file[i].Name} Элемент тега {elemList_of_second_file[i].InnerText}");
                    this.Controls.Add(listBox1);
                }
                else
                {
                    listBox1.Items.Add("Найденное сходство");
                    listBox1.Items.Add($"Первый файл {name_of_xml_first_file.Text}");
                    listBox1.Items.Add($"Названия тег {elemList_of_first_file[i].Name} Элемент тега {elemList_of_first_file[i].InnerText}");
                    listBox1.Items.Add($"Второй файл {name_of_xml_second_file.Text}");
                    listBox1.Items.Add($"Названия тег {elemList_of_second_file[i].Name} Элемент тега {elemList_of_second_file[i].InnerText}");
                    listBox1.Items.Add("\n");
                    this.Controls.Add(listBox1);
                }
            }
            button1.Enabled = false;    //Кнопка отключается после ей использования для сравнения двух дайла xml.
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();  /*при нажатии на кнопку очистка
                                     Очистим лист показывающие разницу между двумя XML-файлами при нажатии нп кнопку очистка
           Очистим текстовое поле принимающие названия первой файла тип xml
           Очистим текстовое поле принимающие названия второй файла тип xml
           Очистим текстовое поле принимающие элемент первой файла тип xml
           Очистим текстовое поле принимающие элемент второй файла тип xml */
            name_of_xml_first_file.Clear();
            name_of_xml_second_file.Clear(); 
            name_of_tag_of_first_xml_file.Clear(); 
            name_of_tag_of_second_xml_file.Clear(); 
           button1.Enabled = true;   //Кнопка включается после очистки.
        }
    }
}
    

