
namespace StudentForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewAllStudents = new System.Windows.Forms.ListView();
            this.FormStudent = new System.Windows.Forms.ColumnHeader();
            this.Surname = new System.Windows.Forms.ColumnHeader();
            this.City = new System.Windows.Forms.ColumnHeader();
            this.Faculty = new System.Windows.Forms.ColumnHeader();
            this.Course = new System.Windows.Forms.ColumnHeader();
            this.AvarageScore = new System.Windows.Forms.ColumnHeader();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.comboBoxFaculty = new System.Windows.Forms.ComboBox();
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.textBoxAverageScore = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelFaculty = new System.Windows.Forms.Label();
            this.labelAverageScore = new System.Windows.Forms.Label();
            this.labelCourse = new System.Windows.Forms.Label();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.listViewStudentsByCity = new System.Windows.Forms.ListView();
            this.CityList = new System.Windows.Forms.ColumnHeader();
            this.StudentsCountByCity = new System.Windows.Forms.ColumnHeader();
            this.listViewStudentsByFaculty = new System.Windows.Forms.ListView();
            this.FacultyList = new System.Windows.Forms.ColumnHeader();
            this.StudentCountByFaculty = new System.Windows.Forms.ColumnHeader();
            this.listViewStudentsByCourse = new System.Windows.Forms.ListView();
            this.CourseList = new System.Windows.Forms.ColumnHeader();
            this.StudentsCountByCourse = new System.Windows.Forms.ColumnHeader();
            this.buttonSortByCourse = new System.Windows.Forms.Button();
            this.buttonSortByScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewAllStudents
            // 
            this.listViewAllStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FormStudent,
            this.Surname,
            this.City,
            this.Faculty,
            this.Course,
            this.AvarageScore});
            this.listViewAllStudents.HideSelection = false;
            this.listViewAllStudents.Location = new System.Drawing.Point(12, 191);
            this.listViewAllStudents.Name = "listViewAllStudents";
            this.listViewAllStudents.Size = new System.Drawing.Size(502, 247);
            this.listViewAllStudents.TabIndex = 0;
            this.listViewAllStudents.UseCompatibleStateImageBehavior = false;
            this.listViewAllStudents.View = System.Windows.Forms.View.Details;
            // 
            // FormStudent
            // 
            this.FormStudent.Name = "Form1";
            this.FormStudent.Text = "Name";
            this.FormStudent.Width = 90;
            // 
            // Surname
            // 
            this.Surname.Text = "Surname";
            this.Surname.Width = 90;
            // 
            // City
            // 
            this.City.Text = "City";
            this.City.Width = 80;
            // 
            // Faculty
            // 
            this.Faculty.Text = "Faculty";
            this.Faculty.Width = 90;
            // 
            // Course
            // 
            this.Course.Text = "Course";
            // 
            // AvarageScore
            // 
            this.AvarageScore.Text = "AvScore";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(655, 191);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(151, 23);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(655, 224);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(151, 23);
            this.textBoxSurname.TabIndex = 2;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(655, 260);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(151, 23);
            this.textBoxCity.TabIndex = 3;
            // 
            // comboBoxFaculty
            // 
            this.comboBoxFaculty.FormattingEnabled = true;
            this.comboBoxFaculty.Location = new System.Drawing.Point(655, 297);
            this.comboBoxFaculty.Name = "comboBoxFaculty";
            this.comboBoxFaculty.Size = new System.Drawing.Size(151, 23);
            this.comboBoxFaculty.TabIndex = 4;
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Location = new System.Drawing.Point(753, 334);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(52, 23);
            this.comboBoxCourse.TabIndex = 5;
            // 
            // textBoxAverageScore
            // 
            this.textBoxAverageScore.Location = new System.Drawing.Point(655, 334);
            this.textBoxAverageScore.Name = "textBoxAverageScore";
            this.textBoxAverageScore.Size = new System.Drawing.Size(48, 23);
            this.textBoxAverageScore.TabIndex = 6;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(566, 191);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 15);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(566, 225);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(54, 15);
            this.labelSurname.TabIndex = 8;
            this.labelSurname.Text = "Surname";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(566, 260);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(28, 15);
            this.labelCity.TabIndex = 9;
            this.labelCity.Text = "City";
            // 
            // labelFaculty
            // 
            this.labelFaculty.AutoSize = true;
            this.labelFaculty.Location = new System.Drawing.Point(566, 297);
            this.labelFaculty.Name = "labelFaculty";
            this.labelFaculty.Size = new System.Drawing.Size(45, 15);
            this.labelFaculty.TabIndex = 10;
            this.labelFaculty.Text = "Faculty";
            // 
            // labelAverageScore
            // 
            this.labelAverageScore.AutoSize = true;
            this.labelAverageScore.Location = new System.Drawing.Point(568, 334);
            this.labelAverageScore.Name = "labelAverageScore";
            this.labelAverageScore.Size = new System.Drawing.Size(81, 15);
            this.labelAverageScore.TabIndex = 11;
            this.labelAverageScore.Text = "Average score";
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(708, 334);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(44, 15);
            this.labelCourse.TabIndex = 12;
            this.labelCourse.Text = "Course";
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(708, 388);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(98, 30);
            this.buttonAddStudent.TabIndex = 13;
            this.buttonAddStudent.Text = "AddStudent";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // listViewStudentsByCity
            // 
            this.listViewStudentsByCity.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CityList,
            this.StudentsCountByCity});
            this.listViewStudentsByCity.HideSelection = false;
            this.listViewStudentsByCity.Location = new System.Drawing.Point(135, 12);
            this.listViewStudentsByCity.Name = "listViewStudentsByCity";
            this.listViewStudentsByCity.Size = new System.Drawing.Size(195, 157);
            this.listViewStudentsByCity.TabIndex = 14;
            this.listViewStudentsByCity.UseCompatibleStateImageBehavior = false;
            this.listViewStudentsByCity.View = System.Windows.Forms.View.Details;
            // 
            // CityList
            // 
            this.CityList.Text = "City";
            this.CityList.Width = 80;
            // 
            // StudentsCountByCity
            // 
            this.StudentsCountByCity.Text = "StudCount";
            this.StudentsCountByCity.Width = 80;
            // 
            // listViewStudentsByFaculty
            // 
            this.listViewStudentsByFaculty.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FacultyList,
            this.StudentCountByFaculty});
            this.listViewStudentsByFaculty.HideSelection = false;
            this.listViewStudentsByFaculty.Location = new System.Drawing.Point(374, 12);
            this.listViewStudentsByFaculty.Name = "listViewStudentsByFaculty";
            this.listViewStudentsByFaculty.Size = new System.Drawing.Size(195, 157);
            this.listViewStudentsByFaculty.TabIndex = 15;
            this.listViewStudentsByFaculty.UseCompatibleStateImageBehavior = false;
            this.listViewStudentsByFaculty.View = System.Windows.Forms.View.Details;
            // 
            // FacultyList
            // 
            this.FacultyList.Text = "Faculty";
            this.FacultyList.Width = 80;
            // 
            // StudentCountByFaculty
            // 
            this.StudentCountByFaculty.Text = "StudCount";
            this.StudentCountByFaculty.Width = 80;
            // 
            // listViewStudentsByCourse
            // 
            this.listViewStudentsByCourse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CourseList,
            this.StudentsCountByCourse});
            this.listViewStudentsByCourse.HideSelection = false;
            this.listViewStudentsByCourse.Location = new System.Drawing.Point(611, 12);
            this.listViewStudentsByCourse.Name = "listViewStudentsByCourse";
            this.listViewStudentsByCourse.Size = new System.Drawing.Size(195, 157);
            this.listViewStudentsByCourse.TabIndex = 16;
            this.listViewStudentsByCourse.UseCompatibleStateImageBehavior = false;
            this.listViewStudentsByCourse.View = System.Windows.Forms.View.Details;
            // 
            // CourseList
            // 
            this.CourseList.Text = "Course";
            this.CourseList.Width = 80;
            // 
            // StudentsCountByCourse
            // 
            this.StudentsCountByCourse.Text = "StudCount";
            this.StudentsCountByCourse.Width = 80;
            // 
            // buttonSortByCourse
            // 
            this.buttonSortByCourse.Location = new System.Drawing.Point(12, 143);
            this.buttonSortByCourse.Name = "buttonSortByCourse";
            this.buttonSortByCourse.Size = new System.Drawing.Size(104, 26);
            this.buttonSortByCourse.TabIndex = 17;
            this.buttonSortByCourse.Text = "Sort by course";
            this.buttonSortByCourse.UseVisualStyleBackColor = true;
            this.buttonSortByCourse.Click += new System.EventHandler(this.buttonSortByCourse_Click);
            // 
            // buttonSortByScore
            // 
            this.buttonSortByScore.Location = new System.Drawing.Point(12, 111);
            this.buttonSortByScore.Name = "buttonSortByScore";
            this.buttonSortByScore.Size = new System.Drawing.Size(104, 26);
            this.buttonSortByScore.TabIndex = 18;
            this.buttonSortByScore.Text = "Sort by score";
            this.buttonSortByScore.UseVisualStyleBackColor = true;
            this.buttonSortByScore.Click += new System.EventHandler(this.buttonSortByScore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 450);
            this.Controls.Add(this.buttonSortByScore);
            this.Controls.Add(this.buttonSortByCourse);
            this.Controls.Add(this.listViewStudentsByCourse);
            this.Controls.Add(this.listViewStudentsByFaculty);
            this.Controls.Add(this.listViewStudentsByCity);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.labelAverageScore);
            this.Controls.Add(this.labelFaculty);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxAverageScore);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.comboBoxFaculty);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.listViewAllStudents);
            this.Text = "FormStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewAllStudents;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.ColumnHeader Faculty;
        private System.Windows.Forms.ColumnHeader Course;
        private System.Windows.Forms.ColumnHeader AvarageScore;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.ComboBox comboBoxFaculty;
        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.TextBox textBoxAverageScore;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelFaculty;
        private System.Windows.Forms.Label labelAverageScore;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.ColumnHeader FormStudent;
        private System.Windows.Forms.ListView listViewStudentsByCity;
        private System.Windows.Forms.ColumnHeader CityList;
        private System.Windows.Forms.ColumnHeader StudentsCountByCity;
        private System.Windows.Forms.ListView listViewStudentsByFaculty;
        private System.Windows.Forms.ColumnHeader FacultyList;
        private System.Windows.Forms.ColumnHeader StudentCountByFaculty;
        private System.Windows.Forms.ListView listViewStudentsByCourse;
        private System.Windows.Forms.ColumnHeader CourseList;
        private System.Windows.Forms.ColumnHeader StudentsCountByCourse;
        private System.Windows.Forms.Button buttonSortByCourse;
        private System.Windows.Forms.Button buttonSortByScore;
    }
}

