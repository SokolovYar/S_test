using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_Editor
{

    internal class QuestionClass
    {
        public string Question { get; set; } = null!;
        public Image ? QImage { get; set; }
        public ObservableCollection<Answer> Answers { get; set; } = null!;

        public int Point { get; set; } = 0;
        public QuestionType QuestionType { get; set; }
        public bool wasAsked { get; set; } = false;
        public static QuestionClass EmptyQuestion = new QuestionClass("Type question here", new ObservableCollection<Answer>
                        {
                            new Answer("Answer #1", true),
                            new Answer("Answer #2", false),
                            new Answer("Answer #3", false),
                            new Answer("Answer #4", false)
                        }, 1, QuestionType.OnlyOne);

        
        public QuestionClass(string question, ObservableCollection<Answer> answers, int point, QuestionType questionType, Image img = null)
        {
            Question = question;
            Answers = answers;
            Point = point;
            QuestionType = questionType;
            if (img != null) QImage = img;
        }
    }

    internal class Answer
    {
        public string Description { get; set; } = null!;
        //public BitmapImage? Image1 { get; set; }
        public bool isRight { get; set; }

        public Answer(string description, bool is_right)
        {
            Description = description;
            isRight = is_right;
        }
    }

    public enum QuestionType { OnlyOne, Many }
}
