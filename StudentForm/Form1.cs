using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentForm
{
    public partial class Form1 : Form
    {
        private StudentList<Student> studentList = new StudentList<Student>();
        SortStudentsByCourse sortStudentsByCourse = new SortStudentsByCourse();
        SortStudentsByScore sortStudentsByScore = new SortStudentsByScore();

        public Form1()
        {
            InitializeComponent();

            generateInitialStudents();
            comboBoxSetInitialValue();

            allStudentsListViewSetValue();
            cityListViewSetValue();
            facultyListViewSetValue();
            courseListViewSetValue();

            studentList.OnItemsAdded += UpdateAllViews;
            studentList.OnItemsSorted += UpdateListStudents;

        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            studentList.InsertStudent(0, createNewStudentFromInputForms());
        }

        private void buttonSortByCourse_Click(object sender, EventArgs e)
        {
            if (sortStudentsByCourse.SortDirection == SortDirection.Ascending)
            {
                sortStudentsByCourse.SortDirection = SortDirection.Descending;
                studentList.SortStudent(sortStudentsByCourse);
            }
            else 
            {
                sortStudentsByCourse.SortDirection = SortDirection.Ascending;
                studentList.SortStudent(sortStudentsByCourse);
            }
        }

        private void buttonSortByScore_Click(object sender, EventArgs e)
        {
            if (sortStudentsByScore.SortDirection == SortDirection.Ascending)
            {
                sortStudentsByScore.SortDirection = SortDirection.Descending;
                studentList.SortStudent(sortStudentsByScore);
            }
            else
            {
                sortStudentsByScore.SortDirection = SortDirection.Ascending;
                studentList.SortStudent(sortStudentsByScore);
            }
        }

        private void UpdateAllViews()
        {
            allStudentsListViewSetValue();
            cityListViewSetValue();
            facultyListViewSetValue();
            courseListViewSetValue();

            clearInputForms();
        }

        private void UpdateListStudents()
        {
            allStudentsListViewSetValue();
        }

        private void generateInitialStudents()
        {
            studentList.Add(new Student("Bob", "Marley", "Kyiv", "Philosophy", 3, 4.5));
            studentList.Add(new Student("Jon", "Bon Jovi", "Lviv", "Physics", 2, 4.6));
            studentList.Add(new Student("John", "Lennon", "Kharkiv", "Mathematics", 4, 4.4));
            studentList.Add(new Student("Maraya", "Kerry", "Kyiv", "Economics", 1, 4.0));
            studentList.Add(new Student("Jimi", "Hendrix", "Dnipro", "Philosophy", 3, 4.5));
        }

        private void allStudentsListViewSetValue()
        {
            listViewAllStudents.Items.Clear();

            foreach (Student student in studentList)
            {
                ListViewItem lvi = new ListViewItem(student.Name);
                lvi.SubItems.Add(student.Surname);
                lvi.SubItems.Add(student.City);
                lvi.SubItems.Add(student.Faculty);
                lvi.SubItems.Add(student.Course.ToString());
                lvi.SubItems.Add(student.AverageScore.ToString());

                listViewAllStudents.Items.Add(lvi);
            }
        }

        private void cityListViewSetValue()
        {
            listViewStudentsByCity.Items.Clear();

            List<string> allValues = new List<string>();
            foreach (Student student in studentList)
            {
                allValues.Add(student.City);
            }

            IEnumerable<string> distinctValues = allValues.Distinct();
            foreach (string value in distinctValues)
            {
                ListViewItem lvi = new ListViewItem(value);
                lvi.SubItems.Add(getStudentsCountByCity(value).ToString());

                listViewStudentsByCity.Items.Add(lvi);
            }
        }

        private int getStudentsCountByCity(string value)
        {
            int count = 0;
            foreach (Student student in studentList)
            {
                if(student.City == value) count++;
            }

            return count;
        }

        private void facultyListViewSetValue()
        {
            listViewStudentsByFaculty.Items.Clear();

            List<string> allValues = new List<string>();
            foreach (Student student in studentList)
            {
                allValues.Add(student.Faculty);
            }

            IEnumerable<string> distinctValues = allValues.Distinct();
            foreach (string value in distinctValues)
            {
                ListViewItem lvi = new ListViewItem(value);
                lvi.SubItems.Add(getStudentsCountByFaculty(value).ToString());

                listViewStudentsByFaculty.Items.Add(lvi);
            }
        }

        private int getStudentsCountByFaculty(string value)
        {
            int count = 0;
            foreach (Student student in studentList)
            {
                if (student.Faculty == value) count++;
            }

            return count;
        }

        private void courseListViewSetValue()
        {
            listViewStudentsByCourse.Items.Clear();

            List<int> allValues = new List<int>();
            foreach (Student student in studentList)
            {
                allValues.Add(student.Course);
            }

            IEnumerable<int> distinctValues = allValues.Distinct();
            foreach (int value in distinctValues)
            {
                ListViewItem lvi = new ListViewItem(value.ToString());
                lvi.SubItems.Add(getStudentsCountByCourse(value).ToString());

                listViewStudentsByCourse.Items.Add(lvi);
            }
        }

        private int getStudentsCountByCourse(int value)
        {
            int count = 0;
            foreach (Student student in studentList)
            {
                if (student.Course == value) count++;
            }

            return count;
        }

        private void comboBoxSetInitialValue()
        {
            comboBoxCourse.Items.AddRange(new string[] { "1", "2", "3", "4", "5" });
            comboBoxFaculty.Items.AddRange(new string[] { "Mathematics", "Physics", "Philosophy", "Programming", "Economics" });
        }

        private Student createNewStudentFromInputForms()
        {
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            string city = textBoxCity.Text;
            string faculty = ""; if (comboBoxFaculty.SelectedIndex >= 0) faculty = comboBoxFaculty.SelectedItem.ToString();
            int course = 0; if (comboBoxCourse.SelectedIndex >= 0) course = int.Parse(comboBoxCourse.SelectedItem.ToString());
            double averageScore; double.TryParse(textBoxAverageScore.Text, out averageScore);

            return new Student(name, surname, city, faculty, course, averageScore);
        }

        private void clearInputForms()
        {
            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxCity.Clear();
            comboBoxFaculty.SelectedIndex = -1;
            comboBoxFaculty.Text = "";
            comboBoxCourse.SelectedIndex = -1;
            comboBoxCourse.Text = "";
            textBoxAverageScore.Clear();
        }

    }
}
