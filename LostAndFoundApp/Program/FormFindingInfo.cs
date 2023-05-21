using LostAndFoundApp.Data;

namespace LostAndFoundApp.Program
{
    public partial class FormFindingInfo : Form
    {
        public Finding finding = new("Name", "About", "Other", "Phone", "Mail");

        public FormFindingInfo()
        {
            InitializeComponent();
        }

        private void FormFindingInfo_Load(object sender, EventArgs e)
        {
            labelName.Text = finding.Name;
            labelAbout.Text = finding.About;
            labelPhone.Text = finding.Phone;
            labelMail.Text = finding.Mail;
            string[] tags = finding.KeyWords.Split(',');
            foreach (string tag in tags)
            {
                listBoxTags.Items.Add(tag);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}