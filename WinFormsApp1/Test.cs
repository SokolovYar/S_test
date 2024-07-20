using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace S_Editor
{
    internal class Test
    {
        public ObservableCollection<Section> Sections { get; set; } = null!;
        public string? Description { get; set; }

                public Test(ObservableCollection<Section> sections, string description)
        {
            Sections = sections;
            Description = description;
        }

 

        public void DeleteSection(Section sect)
        {
            Sections.Remove(sect);
        }

        public void AddSection()
        {
            Sections.Add(new Section(new ObservableCollection<QuestionClass>
            {
                QuestionClass.EmptyQuestion
            }, ("Section " + (Sections.Count + 1)), false, 1));
        }
    }

    internal class Section
    {
        public ObservableCollection<QuestionClass> Questions { get; set; } = null!;
        public bool isRandom { get; set; }
        public int Count_Questions { get; set; }
        public string? Description { get; set; }

        public Section(ObservableCollection<QuestionClass> questions, string description, bool is_random, int count_questions)
        {
            Questions = questions;
            Description = description;
            isRandom = is_random;
            if (count_questions > Questions.Count) Count_Questions = Questions.Count;
            else Count_Questions = count_questions;
        }

        public void AddQuestion()
        {
            Questions.Add(QuestionClass.EmptyQuestion);
        }

        public void AddQuestion(QuestionClass question)
        {
            Questions.Add(question);
        }

        public void DeleteQuestion(QuestionClass question)
        {
            Questions.Remove(question);
        }

    }




}
