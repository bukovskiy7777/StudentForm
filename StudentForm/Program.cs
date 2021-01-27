using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentForm
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }

    public enum SortDirection { Ascending, Descending }

    class SortStudentsByCourse : IComparer<Student>
    {
        private SortDirection sortDirection;

        public SortDirection SortDirection { get { return sortDirection; } set { sortDirection = value; } }

        public int Compare(Student one, Student other)
        {
            if (one.Course > other.Course)
                if (sortDirection.Equals(SortDirection.Ascending)) return 1; else return -1;
            else if (one.Course < other.Course)
                if (sortDirection.Equals(SortDirection.Ascending)) return -1; else return 1;
            else
                return 0;
        }
    }

    class SortStudentsByScore : IComparer<Student>
    {
        private SortDirection sortDirection;

        public SortDirection SortDirection { get { return sortDirection; } set { sortDirection = value; } }

        public int Compare(Student one, Student other)
        {
            if (one.AverageScore > other.AverageScore)
                if (sortDirection.Equals(SortDirection.Ascending)) return 1; else return -1;
            else if (one.AverageScore < other.AverageScore)
                if (sortDirection.Equals(SortDirection.Ascending)) return -1; else return 1;
            else
                return 0;
        }
    }



}
