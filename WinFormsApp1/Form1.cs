using S_Editor;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.ObjectModel;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Test MyTest;
        private QuestionClass selectedQuestion;


        public Form1()
        {
            InitializeComponent();

            // Пустой тест при инициализации
            MyTest = new Test(
                new ObservableCollection<Section>
                {
                    new Section(new ObservableCollection<QuestionClass>
                    {
                        new QuestionClass("Type question here", new ObservableCollection<Answer>
                        {
                            new Answer("Answer #1", true),
                            new Answer("Answer #2", false),
                            new Answer("Answer #3", false),
                            new Answer("Answer #4", false)
                        }, 1, QuestionType.OnlyOne),

                        new QuestionClass("Type question here2", new ObservableCollection<Answer>
                        {
                            new Answer("Answer #1", true),
                            new Answer("Answer #2", false)
                        }, 1, QuestionType.OnlyOne),

                    }, "Section 1", false, 2)
                }, "Test Description");

            LoadTestToTreeView(MyTest);
        }

        private void LoadTestToTreeView(Test test)
        {
            treeView.Nodes.Clear();

            foreach (var section in test.Sections)
            {
                TreeNode sectionNode = new TreeNode(section.Description ?? "Unnamed Section");
                sectionNode.Tag = section;

                foreach (var question in section.Questions)
                {
                    TreeNode questionNode = new TreeNode(question.Question);
                    questionNode.Tag = question;
                    sectionNode.Nodes.Add(questionNode);
                }

                treeView.Nodes.Add(sectionNode);
            }
            treeView.ExpandAll();
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is QuestionClass question)
            {
                selectedQuestion = question;
                richTextBox1.Text = question.Question;
                var answers = question.Answers.ToList();

                if (answers.Count > 0)
                {
                    textBox1.Text = answers[0].Description;
                    checkBox1.Checked = answers[0].isRight;
                }
                if (answers.Count > 1)
                {
                    textBox2.Text = answers[1].Description;
                    checkBox2.Checked = answers[1].isRight;
                }
                if (answers.Count > 2)
                {
                    textBox3.Text = answers[2].Description;
                    checkBox3.Checked = answers[2].isRight;
                }
                if (answers.Count > 3)
                {
                    textBox4.Text = answers[3].Description;
                    checkBox4.Checked = answers[3].isRight;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (selectedQuestion != null)
            {
                selectedQuestion.Question = richTextBox1.Text;
                var answers = selectedQuestion.Answers;

                if (answers.Count > 0)
                {
                    answers[0].Description = textBox1.Text;
                    answers[0].isRight = checkBox1.Checked;
                }
                if (answers.Count > 1)
                {
                    answers[1].Description = textBox2.Text;
                    answers[1].isRight = checkBox2.Checked;
                }
                if (answers.Count > 2)
                {
                    answers[2].Description = textBox3.Text;
                    answers[2].isRight = checkBox3.Checked;
                }
                if (answers.Count > 3)
                {
                    answers[3].Description = textBox4.Text;
                    answers[3].isRight = checkBox4.Checked;
                }
                treeView.SelectedNode.Text = selectedQuestion.Question;
            }
        }
    }
}
