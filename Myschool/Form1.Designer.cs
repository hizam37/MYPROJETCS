namespace Myschool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Schedule_of_first_Section = new System.Windows.Forms.ListBox();
            this.Schedule_of_second_Section = new System.Windows.Forms.ListBox();
            this.First_section_As_LABEL = new System.Windows.Forms.Label();
            this.up = new System.Windows.Forms.Button();
            this.add_from_first_section_to_new_schedule = new System.Windows.Forms.Button();
            this.delete_from_schedule = new System.Windows.Forms.Button();
            this.Current_schedule = new System.Windows.Forms.ListBox();
            this.SECTION_INDICATOR = new System.Windows.Forms.TextBox();
            this.Restart = new System.Windows.Forms.Button();
            this.add_from_second_section_to_new_schedule = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.organize_inside_the_current_schedule = new System.Windows.Forms.GroupBox();
            this.Edit_in_schedule = new System.Windows.Forms.Button();
            this.Blank_for_editing_inside_the_schedule = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Check_to_comfirm_for_change = new System.Windows.Forms.CheckBox();
            this.print_schedule = new System.Windows.Forms.Button();
            this.Second_section_As_LABEL = new System.Windows.Forms.Label();
            this.SPBGASU_As_Groupbox = new System.Windows.Forms.GroupBox();
            this.Registration_in_SPBGASU = new System.Windows.Forms.GroupBox();
            this.Second_section_of_SPBGASU = new System.Windows.Forms.RadioButton();
            this.First_section_of_SPBGASU = new System.Windows.Forms.RadioButton();
            this.add_registered_student_or_teacher_in_the_schedule = new System.Windows.Forms.Button();
            this.Check_to_comfirm_for_registration = new System.Windows.Forms.CheckBox();
            this.Blank_for_adding_in_the_schedule = new System.Windows.Forms.TextBox();
            this.Current_schedule_of_SPBAGU_AS_LABEL = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.addtional_functions = new System.Windows.Forms.GroupBox();
            this.organize_inside_the_current_schedule.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SPBGASU_As_Groupbox.SuspendLayout();
            this.Registration_in_SPBGASU.SuspendLayout();
            this.Current_schedule_of_SPBAGU_AS_LABEL.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.addtional_functions.SuspendLayout();
            this.SuspendLayout();
            // 
            // Schedule_of_first_Section
            // 
            this.Schedule_of_first_Section.FormattingEnabled = true;
            this.Schedule_of_first_Section.ItemHeight = 16;
            this.Schedule_of_first_Section.Items.AddRange(new object[] {
            "Teacher :  Victor.  Subject : Math",
            "Classroom : 101A",
            "Students : 25",
            "duration : 1 hour",
            "Teacher : Ali. Subject : Biology",
            "Classroom : 222C",
            "Students : 50",
            "duration : 1 hour ",
            "Teacher : Vladimir Subject : Psychology",
            "Classroom : 23C ",
            "Students : 55",
            "duration : 1 hour"});
            this.Schedule_of_first_Section.Location = new System.Drawing.Point(6, 66);
            this.Schedule_of_first_Section.Name = "Schedule_of_first_Section";
            this.Schedule_of_first_Section.Size = new System.Drawing.Size(293, 196);
            this.Schedule_of_first_Section.TabIndex = 0;
            this.Schedule_of_first_Section.SelectedIndexChanged += new System.EventHandler(this.First_Section_Schedule_As_Listbox);
            // 
            // Schedule_of_second_Section
            // 
            this.Schedule_of_second_Section.FormattingEnabled = true;
            this.Schedule_of_second_Section.ItemHeight = 16;
            this.Schedule_of_second_Section.Items.AddRange(new object[] {
            "Teacher :  Victoria. Subject : Physics",
            "Classroom :  101E",
            "Students :  20",
            "duration : 1 hour",
            "Teacher : Elia. Subject : Astrology",
            "Classroom : 22E",
            "Students : 50",
            "duration : 1 hour",
            "Teacher : Maksim. Subject : Architecture",
            "Classroom : 23A",
            "Students :  56",
            "duration : 1 hour"});
            this.Schedule_of_second_Section.Location = new System.Drawing.Point(345, 66);
            this.Schedule_of_second_Section.Name = "Schedule_of_second_Section";
            this.Schedule_of_second_Section.Size = new System.Drawing.Size(327, 196);
            this.Schedule_of_second_Section.TabIndex = 1;
            this.Schedule_of_second_Section.SelectedIndexChanged += new System.EventHandler(this.Second_Section_Schedule_As_Listbox);
            // 
            // First_section_As_LABEL
            // 
            this.First_section_As_LABEL.AutoSize = true;
            this.First_section_As_LABEL.Location = new System.Drawing.Point(3, 35);
            this.First_section_As_LABEL.Name = "First_section_As_LABEL";
            this.First_section_As_LABEL.Size = new System.Drawing.Size(97, 16);
            this.First_section_As_LABEL.TabIndex = 3;
            this.First_section_As_LABEL.Text = "Первая ветвь";
            this.First_section_As_LABEL.Click += new System.EventHandler(this.First_Section_As_Label);
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(6, 29);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(63, 38);
            this.up.TabIndex = 4;
            this.up.Text = " Верх";
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.Up_Button);
            // 
            // add_from_first_section_to_new_schedule
            // 
            this.add_from_first_section_to_new_schedule.Location = new System.Drawing.Point(22, 50);
            this.add_from_first_section_to_new_schedule.Name = "add_from_first_section_to_new_schedule";
            this.add_from_first_section_to_new_schedule.Size = new System.Drawing.Size(441, 33);
            this.add_from_first_section_to_new_schedule.TabIndex = 5;
            this.add_from_first_section_to_new_schedule.Text = "Первая ветвь";
            this.add_from_first_section_to_new_schedule.UseVisualStyleBackColor = true;
            this.add_from_first_section_to_new_schedule.Click += new System.EventHandler(this.First_Section_Button);
            // 
            // delete_from_schedule
            // 
            this.delete_from_schedule.ForeColor = System.Drawing.Color.Red;
            this.delete_from_schedule.Location = new System.Drawing.Point(35, 21);
            this.delete_from_schedule.Name = "delete_from_schedule";
            this.delete_from_schedule.Size = new System.Drawing.Size(192, 37);
            this.delete_from_schedule.TabIndex = 6;
            this.delete_from_schedule.Text = "Убрать_из_расписании ";
            this.delete_from_schedule.UseVisualStyleBackColor = true;
            this.delete_from_schedule.Click += new System.EventHandler(this.Delete_From_Schedule_Button);
            // 
            // Current_schedule
            // 
            this.Current_schedule.FormattingEnabled = true;
            this.Current_schedule.ItemHeight = 16;
            this.Current_schedule.Location = new System.Drawing.Point(21, 69);
            this.Current_schedule.Name = "Current_schedule";
            this.Current_schedule.Size = new System.Drawing.Size(358, 196);
            this.Current_schedule.TabIndex = 7;
            this.Current_schedule.SelectedIndexChanged += new System.EventHandler(this.Current_Schedule_As_Listbox);
            // 
            // SECTION_INDICATOR
            // 
            this.SECTION_INDICATOR.Location = new System.Drawing.Point(21, 21);
            this.SECTION_INDICATOR.Multiline = true;
            this.SECTION_INDICATOR.Name = "SECTION_INDICATOR";
            this.SECTION_INDICATOR.Size = new System.Drawing.Size(358, 41);
            this.SECTION_INDICATOR.TabIndex = 8;
            this.SECTION_INDICATOR.TextChanged += new System.EventHandler(this.Section_Indicator_As_Textbox);
            // 
            // Restart
            // 
            this.Restart.Location = new System.Drawing.Point(35, 115);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(192, 37);
            this.Restart.TabIndex = 9;
            this.Restart.Text = "Перезапуск";
            this.Restart.UseVisualStyleBackColor = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Button);
            // 
            // add_from_second_section_to_new_schedule
            // 
            this.add_from_second_section_to_new_schedule.Location = new System.Drawing.Point(22, 114);
            this.add_from_second_section_to_new_schedule.Name = "add_from_second_section_to_new_schedule";
            this.add_from_second_section_to_new_schedule.Size = new System.Drawing.Size(441, 33);
            this.add_from_second_section_to_new_schedule.TabIndex = 10;
            this.add_from_second_section_to_new_schedule.Text = "Вторая ветвь";
            this.add_from_second_section_to_new_schedule.UseVisualStyleBackColor = true;
            this.add_from_second_section_to_new_schedule.Click += new System.EventHandler(this.Second_Section_Button);
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(400, 29);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(63, 38);
            this.down.TabIndex = 11;
            this.down.Text = "Вниз";
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.Down_Button);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(94, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(256, 22);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // organize_inside_the_current_schedule
            // 
            this.organize_inside_the_current_schedule.Controls.Add(this.up);
            this.organize_inside_the_current_schedule.Controls.Add(this.down);
            this.organize_inside_the_current_schedule.Location = new System.Drawing.Point(94, 534);
            this.organize_inside_the_current_schedule.Name = "organize_inside_the_current_schedule";
            this.organize_inside_the_current_schedule.Size = new System.Drawing.Size(481, 85);
            this.organize_inside_the_current_schedule.TabIndex = 13;
            this.organize_inside_the_current_schedule.TabStop = false;
            this.organize_inside_the_current_schedule.Text = "Организовать_внутри_текущего_расписании ";
            this.organize_inside_the_current_schedule.Enter += new System.EventHandler(this.Organize_Inside_Current_Schedule_As_Groupbox);
            // 
            // Edit_in_schedule
            // 
            this.Edit_in_schedule.Location = new System.Drawing.Point(6, 70);
            this.Edit_in_schedule.Name = "Edit_in_schedule";
            this.Edit_in_schedule.Size = new System.Drawing.Size(215, 36);
            this.Edit_in_schedule.TabIndex = 15;
            this.Edit_in_schedule.Text = "Изменить";
            this.Edit_in_schedule.UseVisualStyleBackColor = true;
            this.Edit_in_schedule.Click += new System.EventHandler(this.Edit_Inside_Schedule_Button);
            // 
            // Blank_for_editing_inside_the_schedule
            // 
            this.Blank_for_editing_inside_the_schedule.Location = new System.Drawing.Point(242, 70);
            this.Blank_for_editing_inside_the_schedule.Multiline = true;
            this.Blank_for_editing_inside_the_schedule.Name = "Blank_for_editing_inside_the_schedule";
            this.Blank_for_editing_inside_the_schedule.Size = new System.Drawing.Size(233, 36);
            this.Blank_for_editing_inside_the_schedule.TabIndex = 16;
            this.Blank_for_editing_inside_the_schedule.TextChanged += new System.EventHandler(this.Editing_Inside_Schedule_As_Textbox);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Check_to_comfirm_for_change);
            this.groupBox2.Controls.Add(this.Blank_for_editing_inside_the_schedule);
            this.groupBox2.Controls.Add(this.Edit_in_schedule);
            this.groupBox2.Location = new System.Drawing.Point(94, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 112);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Редактирование в расписание";
            this.groupBox2.Enter += new System.EventHandler(this.Editing_Inside_Schedule_As_Groupbox);
            // 
            // Check_to_comfirm_for_change
            // 
            this.Check_to_comfirm_for_change.AutoSize = true;
            this.Check_to_comfirm_for_change.Location = new System.Drawing.Point(5, 37);
            this.Check_to_comfirm_for_change.Name = "Check_to_comfirm_for_change";
            this.Check_to_comfirm_for_change.Size = new System.Drawing.Size(118, 20);
            this.Check_to_comfirm_for_change.TabIndex = 17;
            this.Check_to_comfirm_for_change.Text = "Подверждать";
            this.Check_to_comfirm_for_change.UseVisualStyleBackColor = true;
            this.Check_to_comfirm_for_change.CheckedChanged += new System.EventHandler(this.Checkbox_For_Editing);
            // 
            // print_schedule
            // 
            this.print_schedule.Location = new System.Drawing.Point(35, 213);
            this.print_schedule.Name = "print_schedule";
            this.print_schedule.Size = new System.Drawing.Size(192, 40);
            this.print_schedule.TabIndex = 18;
            this.print_schedule.Text = "Печатать";
            this.print_schedule.UseVisualStyleBackColor = true;
            this.print_schedule.Click += new System.EventHandler(this.Print_Button);
            // 
            // Second_section_As_LABEL
            // 
            this.Second_section_As_LABEL.AutoSize = true;
            this.Second_section_As_LABEL.Location = new System.Drawing.Point(342, 35);
            this.Second_section_As_LABEL.Name = "Second_section_As_LABEL";
            this.Second_section_As_LABEL.Size = new System.Drawing.Size(95, 16);
            this.Second_section_As_LABEL.TabIndex = 19;
            this.Second_section_As_LABEL.Text = "Вторая ветвь";
            this.Second_section_As_LABEL.Click += new System.EventHandler(this.Second_Section_As_Label);
            // 
            // SPBGASU_As_Groupbox
            // 
            this.SPBGASU_As_Groupbox.Controls.Add(this.Schedule_of_second_Section);
            this.SPBGASU_As_Groupbox.Controls.Add(this.Second_section_As_LABEL);
            this.SPBGASU_As_Groupbox.Controls.Add(this.Schedule_of_first_Section);
            this.SPBGASU_As_Groupbox.Controls.Add(this.First_section_As_LABEL);
            this.SPBGASU_As_Groupbox.Location = new System.Drawing.Point(590, 46);
            this.SPBGASU_As_Groupbox.Name = "SPBGASU_As_Groupbox";
            this.SPBGASU_As_Groupbox.Size = new System.Drawing.Size(678, 267);
            this.SPBGASU_As_Groupbox.TabIndex = 20;
            this.SPBGASU_As_Groupbox.TabStop = false;
            this.SPBGASU_As_Groupbox.Text = "СПБГАСУ";
            this.SPBGASU_As_Groupbox.Enter += new System.EventHandler(this.SPBGASU_As_GROUPBOX);
            // 
            // Registration_in_SPBGASU
            // 
            this.Registration_in_SPBGASU.Controls.Add(this.Second_section_of_SPBGASU);
            this.Registration_in_SPBGASU.Controls.Add(this.First_section_of_SPBGASU);
            this.Registration_in_SPBGASU.Controls.Add(this.add_registered_student_or_teacher_in_the_schedule);
            this.Registration_in_SPBGASU.Controls.Add(this.Check_to_comfirm_for_registration);
            this.Registration_in_SPBGASU.Controls.Add(this.Blank_for_adding_in_the_schedule);
            this.Registration_in_SPBGASU.Location = new System.Drawing.Point(94, 46);
            this.Registration_in_SPBGASU.Name = "Registration_in_SPBGASU";
            this.Registration_in_SPBGASU.Size = new System.Drawing.Size(481, 112);
            this.Registration_in_SPBGASU.TabIndex = 21;
            this.Registration_in_SPBGASU.TabStop = false;
            this.Registration_in_SPBGASU.Text = "Регистрация_в_СПБГАСУ";
            this.Registration_in_SPBGASU.Enter += new System.EventHandler(this.Registration_In_SPBGASU_As_GroupBox);
            // 
            // Second_section_of_SPBGASU
            // 
            this.Second_section_of_SPBGASU.AutoSize = true;
            this.Second_section_of_SPBGASU.Location = new System.Drawing.Point(357, 43);
            this.Second_section_of_SPBGASU.Name = "Second_section_of_SPBGASU";
            this.Second_section_of_SPBGASU.Size = new System.Drawing.Size(116, 20);
            this.Second_section_of_SPBGASU.TabIndex = 26;
            this.Second_section_of_SPBGASU.TabStop = true;
            this.Second_section_of_SPBGASU.Text = "Вторая ветвь";
            this.Second_section_of_SPBGASU.UseVisualStyleBackColor = true;
            this.Second_section_of_SPBGASU.CheckedChanged += new System.EventHandler(this.Second_Section_As_RadioButton);
            // 
            // First_section_of_SPBGASU
            // 
            this.First_section_of_SPBGASU.AutoSize = true;
            this.First_section_of_SPBGASU.Location = new System.Drawing.Point(357, 17);
            this.First_section_of_SPBGASU.Name = "First_section_of_SPBGASU";
            this.First_section_of_SPBGASU.Size = new System.Drawing.Size(118, 20);
            this.First_section_of_SPBGASU.TabIndex = 25;
            this.First_section_of_SPBGASU.TabStop = true;
            this.First_section_of_SPBGASU.Text = "Первая ветвь";
            this.First_section_of_SPBGASU.UseVisualStyleBackColor = true;
            this.First_section_of_SPBGASU.CheckedChanged += new System.EventHandler(this.First_section_of_SPBGASU_As_RadioButton);
            // 
            // add_registered_student_or_teacher_in_the_schedule
            // 
            this.add_registered_student_or_teacher_in_the_schedule.Location = new System.Drawing.Point(6, 69);
            this.add_registered_student_or_teacher_in_the_schedule.Name = "add_registered_student_or_teacher_in_the_schedule";
            this.add_registered_student_or_teacher_in_the_schedule.Size = new System.Drawing.Size(215, 36);
            this.add_registered_student_or_teacher_in_the_schedule.TabIndex = 24;
            this.add_registered_student_or_teacher_in_the_schedule.Text = "Дабавь";
            this.add_registered_student_or_teacher_in_the_schedule.UseVisualStyleBackColor = true;
            this.add_registered_student_or_teacher_in_the_schedule.Click += new System.EventHandler(this.Add_For_Registration_Button);
            // 
            // Check_to_comfirm_for_registration
            // 
            this.Check_to_comfirm_for_registration.AutoSize = true;
            this.Check_to_comfirm_for_registration.Location = new System.Drawing.Point(7, 22);
            this.Check_to_comfirm_for_registration.Name = "Check_to_comfirm_for_registration";
            this.Check_to_comfirm_for_registration.Size = new System.Drawing.Size(118, 20);
            this.Check_to_comfirm_for_registration.TabIndex = 23;
            this.Check_to_comfirm_for_registration.Text = "Подверждать";
            this.Check_to_comfirm_for_registration.UseVisualStyleBackColor = true;
            this.Check_to_comfirm_for_registration.CheckedChanged += new System.EventHandler(this.Checkbox_For_Registration);
            // 
            // Blank_for_adding_in_the_schedule
            // 
            this.Blank_for_adding_in_the_schedule.Location = new System.Drawing.Point(242, 69);
            this.Blank_for_adding_in_the_schedule.Multiline = true;
            this.Blank_for_adding_in_the_schedule.Name = "Blank_for_adding_in_the_schedule";
            this.Blank_for_adding_in_the_schedule.Size = new System.Drawing.Size(233, 36);
            this.Blank_for_adding_in_the_schedule.TabIndex = 22;
            this.Blank_for_adding_in_the_schedule.TextChanged += new System.EventHandler(this.Registration_Inside_Schedule_As_Textbox);
            // 
            // Current_schedule_of_SPBAGU_AS_LABEL
            // 
            this.Current_schedule_of_SPBAGU_AS_LABEL.Controls.Add(this.SECTION_INDICATOR);
            this.Current_schedule_of_SPBAGU_AS_LABEL.Controls.Add(this.Current_schedule);
            this.Current_schedule_of_SPBAGU_AS_LABEL.Location = new System.Drawing.Point(590, 335);
            this.Current_schedule_of_SPBAGU_AS_LABEL.Name = "Current_schedule_of_SPBAGU_AS_LABEL";
            this.Current_schedule_of_SPBAGU_AS_LABEL.Size = new System.Drawing.Size(390, 284);
            this.Current_schedule_of_SPBAGU_AS_LABEL.TabIndex = 22;
            this.Current_schedule_of_SPBAGU_AS_LABEL.TabStop = false;
            this.Current_schedule_of_SPBAGU_AS_LABEL.Text = "Текущий расписание ";
            this.Current_schedule_of_SPBAGU_AS_LABEL.Enter += new System.EventHandler(this.Current_Schedule_As_Groupbox);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.add_from_first_section_to_new_schedule);
            this.groupBox6.Controls.Add(this.add_from_second_section_to_new_schedule);
            this.groupBox6.Location = new System.Drawing.Point(94, 333);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(481, 177);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "ДАБАВИТЬ_ОТ_СПБГАСУ_НА_ТЕКУШИИ_РАСПИМАНИЕ";
            this.groupBox6.Enter += new System.EventHandler(this.Adding_From_SPBGASU_To_The_New_Schedule_As_Groupbox);
            // 
            // addtional_functions
            // 
            this.addtional_functions.Controls.Add(this.delete_from_schedule);
            this.addtional_functions.Controls.Add(this.Restart);
            this.addtional_functions.Controls.Add(this.print_schedule);
            this.addtional_functions.Location = new System.Drawing.Point(998, 347);
            this.addtional_functions.Name = "addtional_functions";
            this.addtional_functions.Size = new System.Drawing.Size(264, 272);
            this.addtional_functions.TabIndex = 24;
            this.addtional_functions.TabStop = false;
            this.addtional_functions.Text = "Дополнительные функции";
            this.addtional_functions.Enter += new System.EventHandler(this.Addtional_Functions_As_Groupbox);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 649);
            this.Controls.Add(this.addtional_functions);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.Current_schedule_of_SPBAGU_AS_LABEL);
            this.Controls.Add(this.Registration_in_SPBGASU);
            this.Controls.Add(this.SPBGASU_As_Groupbox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.organize_inside_the_current_schedule);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.organize_inside_the_current_schedule.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.SPBGASU_As_Groupbox.ResumeLayout(false);
            this.SPBGASU_As_Groupbox.PerformLayout();
            this.Registration_in_SPBGASU.ResumeLayout(false);
            this.Registration_in_SPBGASU.PerformLayout();
            this.Current_schedule_of_SPBAGU_AS_LABEL.ResumeLayout(false);
            this.Current_schedule_of_SPBAGU_AS_LABEL.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.addtional_functions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Schedule_of_first_Section;
        private System.Windows.Forms.ListBox Schedule_of_second_Section;
        private System.Windows.Forms.Label First_section_As_LABEL;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button add_from_first_section_to_new_schedule;
        private System.Windows.Forms.Button delete_from_schedule;
        private System.Windows.Forms.ListBox Current_schedule;
        private System.Windows.Forms.TextBox SECTION_INDICATOR;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.Button add_from_second_section_to_new_schedule;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox organize_inside_the_current_schedule;
        private System.Windows.Forms.Button Edit_in_schedule;
        private System.Windows.Forms.TextBox Blank_for_editing_inside_the_schedule;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button print_schedule;
        private System.Windows.Forms.Label Second_section_As_LABEL;
        private System.Windows.Forms.GroupBox SPBGASU_As_Groupbox;
        private System.Windows.Forms.GroupBox Registration_in_SPBGASU;
        private System.Windows.Forms.Button add_registered_student_or_teacher_in_the_schedule;
        private System.Windows.Forms.CheckBox Check_to_comfirm_for_registration;
        private System.Windows.Forms.TextBox Blank_for_adding_in_the_schedule;
        private System.Windows.Forms.CheckBox Check_to_comfirm_for_change;
        private System.Windows.Forms.RadioButton Second_section_of_SPBGASU;
        private System.Windows.Forms.RadioButton First_section_of_SPBGASU;
        private System.Windows.Forms.GroupBox Current_schedule_of_SPBAGU_AS_LABEL;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox addtional_functions;
    }
}

