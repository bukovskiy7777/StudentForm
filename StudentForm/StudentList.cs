using System;
using System.Collections.Generic;
using System.Text;

namespace StudentForm
{
    delegate void OnItemsAdded();
    delegate void OnItemsSorted();
    class StudentList<Student> : List<Student>
    {
        public event OnItemsAdded OnItemsAdded;
        public event OnItemsSorted OnItemsSorted;

        public void InsertStudent(int position, Student student)
        {
            Insert(position, student);
            OnItemsAdded();
        }
        public void SortStudent(IComparer<Student> studentComparer)
        {
            Sort(studentComparer);
            OnItemsSorted();
        }
    }
}
