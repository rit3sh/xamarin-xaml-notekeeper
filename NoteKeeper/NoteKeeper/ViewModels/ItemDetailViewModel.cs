using System;
using System.Collections.Generic;
using NoteKeeper.Models;

namespace NoteKeeper.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Note Note { get; set; }
        public IList<String> CourseList { get; set; }

        public String NoteHeading
        {
            get { return Note.Heading; }
            set
            {
                Note.Heading = value;
                OnPropertyChanged();
            }
        }

        public String NoteText
        {
            get { return Note.Text; }
            set
            {
                Note.Text = value;
                OnPropertyChanged();
            }
        }

        public String NoteCourse
        {
            get { return CourseList[0]; }
            set
            {
                Note.Course = value;
                OnPropertyChanged();
            }
        }

        public ItemDetailViewModel(Note note = null)
        {
            Title = "Edit Note";
            InitializeCourseList();
            Note = note ?? new Note();
        }

        async void InitializeCourseList()
        {
            CourseList = await TestDataStore.GetCoursesAsync();
        }
    }
}
