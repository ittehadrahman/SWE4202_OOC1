using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Books
{
    public partial class studybookaddbutton : Form
    {
        List<StudyBook> studybooks = new List<StudyBook>();
        List<ResearchArticle> researcharticles = new List<ResearchArticle>();
        public studybookaddbutton()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int studybookID = Convert.ToInt32(studybookIDtextbox.Text);
            string studybooktitle = studybooktitletextbox.Text;
            string studybookauthor = studybookauthortextbox.Text;
            string studybookpublisher = studybookpublishertextbox.Text;
            int studybookquantity = Convert.ToInt32(studybookquantitytextbox.Text);
            int studybookISBN = Convert.ToInt32(studybookISBNtextbox.Text);
            string studybookgenre = studybookgenretextbox.Text;

            StudyBook dummy_studybook = new StudyBook();
            dummy_studybook.ID = studybookID;
            dummy_studybook.title = studybooktitle;
            dummy_studybook.author = studybookauthor;
            dummy_studybook.publisher = studybookpublisher;
            dummy_studybook.quantity = studybookquantity;
            dummy_studybook.ISBN = studybookISBN;
            dummy_studybook.genre = studybookgenre;
            studybooks.Add(dummy_studybook);

            MessageBox.Show("Book has been added successfully!");
        
        }

        private void studybookaddbutton_Load(object sender, EventArgs e)
        {
            
        }

        private void reesearcharticleaddbutton_Click(object sender, EventArgs e)
        {
            int researcharticleID = Convert.ToInt32(researcharticleIDtextbox.Text);
            string researcharticletitle = researcharticletitletextbox.Text;
            string researcharticleauthor = researcharticleauthortextbox.Text;
            string researcharticlepublisher = researcharticlepublishertextbox.Text;
            int researcharticlequantity = Convert.ToInt32(researcharticlequantitytextbox.Text);
            int researcharticleDOI = Convert.ToInt32(researcharticleDOItextbox.Text);
            string researcharticlepublisheddate = researcharticlepublisheddatetextbox.Text;
            string researcharticleCorJ = researcharticleconferencetextbox.Text;

            ResearchArticle dummy_researcharticle = new ResearchArticle();
            dummy_researcharticle.ID = researcharticleID;
            dummy_researcharticle.title = researcharticletitle;
            dummy_researcharticle.author = researcharticleauthor;
            dummy_researcharticle.publisher = researcharticlepublisher;
            dummy_researcharticle.quantity = researcharticlequantity;
            dummy_researcharticle.DOI = researcharticleDOI;
            dummy_researcharticle.published_date = researcharticlepublisheddate;
            dummy_researcharticle.CorJ = researcharticleCorJ;
            researcharticles.Add(dummy_researcharticle);

            MessageBox.Show("Book has been added successfully!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudyBookList.Items.Clear();

            for (int i = 0; i < studybooks.Count; i++)
            {
                StudyBookList.Items.Add(studybooks[i].getInfo());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResearchArticleListbox.Items.Clear();

            for (int i = 0; i < researcharticles.Count; i++)
            {
                ResearchArticleListbox.Items.Add(researcharticles[i].getInfo());
            }
        }

        private void borrowbookbutton_Click(object sender, EventArgs e)
        {
            foreach (StudyBook dummy in studybooks)
            {
                if (dummy.ID == Convert.ToInt32(borrowbookIDtextbox.Text))
                {
                    dummy.borrow();
                }
            }

        }

        private void borrowarticlebutton_Click(object sender, EventArgs e)
        {
            foreach (ResearchArticle dummy in researcharticles)
            {
                if (dummy.ID == Convert.ToInt32(borrowarticleIDtextbox.Text))
                {
                    dummy.borrow();
                }
            }

            
        }
    }
}
