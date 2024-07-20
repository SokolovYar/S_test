using S_Editor;
using System.Collections.ObjectModel;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Test MyTest;
        private QuestionClass? selectedQuestion;
        private Section? selectedSection;

        public Form1()
        {
            InitializeComponent();

            // Пустой тест при инициализации
            MyTest = new Test(
                new ObservableCollection<Section>
                {
                    new Section(new ObservableCollection<QuestionClass>
                    {
                       QuestionClass.EmptyQuestion,
                    }, "Section 1", false, 1),
                }, "Test Description");

            DescriptionTableLayoutPanel.SetColumnSpan(Description_textBox, 2);
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
            ClearAnswerFields();

            if (e.Node.Tag is QuestionClass question)
            {
                selectedQuestion = question;
                selectedSection = e.Node.Parent?.Tag as Section;
                Description_textBox.Text = selectedQuestion.Question;
                if (selectedQuestion.QImage != null)
                {
                    DescriptionTableLayoutPanel.SetColumnSpan(Description_textBox, 1);
                    QPictureBox.Image = selectedQuestion.QImage;
                }
                else
                {
                    QPictureBox.Image = null;
                    DescriptionTableLayoutPanel.SetColumnSpan(Description_textBox, 2);
                }

                var answers = selectedQuestion.Answers.ToList();

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

            if (e.Node.Tag is Section section)
            {
                selectedQuestion = null;
                selectedSection = section;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (selectedQuestion != null)
            {
                selectedQuestion.Question = Description_textBox.Text;
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

                // Обновляем отображение текста выбранного узла в TreeView
                //treeView.SelectedNode.Text = selectedQuestion.Question;
                LoadTestToTreeView(MyTest);
            }
        }

        private void ClearAnswerFields()
        {
            textBox1.Text = string.Empty;
            checkBox1.Checked = false;
            textBox2.Text = string.Empty;
            checkBox2.Checked = false;
            textBox3.Text = string.Empty;
            checkBox3.Checked = false;
            textBox4.Text = string.Empty;
            checkBox4.Checked = false;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyTest.AddSection();
            LoadTestToTreeView(MyTest);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedSection == null) return;
            MyTest.DeleteSection(selectedSection);
            LoadTestToTreeView(MyTest);
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (selectedSection == null) return;
            selectedSection.AddQuestion();
            LoadTestToTreeView(MyTest);
        }

        private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (selectedQuestion == null) return;
            selectedSection = treeView.SelectedNode.Parent?.Tag as Section;
            if (selectedSection != null)
            {
                selectedSection.Questions.Remove(selectedQuestion);
                LoadTestToTreeView(MyTest);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedSection == null) return;
            SectionAdjust sa = new SectionAdjust(selectedSection);
            DialogResult result = sa.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedSection.isRandom = sa.IsRandom;
                selectedSection.Count_Questions = sa.QToAsk;
                selectedSection.Description = sa.Descr;
            }
            LoadTestToTreeView(MyTest);
        }

        private void addImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK && selectedQuestion != null)
            {
                string path = openFileDialog.FileName;
                selectedQuestion.QImage = System.Drawing.Image.FromFile(path);
                QPictureBox.Image = selectedQuestion.QImage; // Обновление PictureBox при добавлении изображения
                LoadTestToTreeView(MyTest);
            }
        }

        private void removeImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedQuestion == null) return;

            selectedQuestion.QImage = null;
            QPictureBox.Image = null; // Обновление PictureBox при удалении изображения
            LoadTestToTreeView(MyTest);
        }

        private void QPictureBox_Click(object sender, EventArgs e)
        {
            ImageForm imgForm = new ImageForm(QPictureBox.Image);
            imgForm.ShowDialog();
        }
    }
}