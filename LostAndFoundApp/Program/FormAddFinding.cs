using LostAndFoundApp.Data;

namespace LostAndFoundApp.Program
{
    public partial class FormAddFinding : Form
    {
        public List<Filter> tags = new();

        public FormAddFinding()
        {
            InitializeComponent();
        }

        private void FormAddFinding_Load(object sender, EventArgs e)
        {
            foreach (Filter tag in tags)
            {
                CheckedListBoxTags.Items.Add(tag.Name);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == null || textBoxName.Text.Length == 0 || textBoxName.Text.All(char.IsWhiteSpace))
            {
                MessageBox.Show("Incorrect name!");
                return;
            }
            if (RichTextBoxAbout.Text == null || RichTextBoxAbout.Text.Length == 0 || RichTextBoxAbout.Text.All(char.IsWhiteSpace))
            {
                MessageBox.Show("Add information about finding!");
                return;
            }
            if (textBoxPhone.Text == null || textBoxPhone.Text.Length == 0 || textBoxPhone.Text.All(char.IsWhiteSpace) || !WorkWithData.IsValidPhone(textBoxPhone.Text))
            {
                MessageBox.Show("Incorrect number!");
                return;
            }
            if (textBoxMail.Text == null || textBoxMail.Text.Length == 0 || textBoxMail.Text.All(char.IsWhiteSpace) || !WorkWithData.IsValidEmail(textBoxMail.Text))
            {
                MessageBox.Show("Incorrect email!");
                return;
            }
            if (CheckedListBoxTags.CheckedItems.Count == 0)
            {
                MessageBox.Show("Choose tags!");
                return;
            }

            string tags = WorkWithData.FormatToKeyWords(CheckedListBoxTags.CheckedItems.Cast<string>().ToArray());

            FormMain.addedFinding = new Finding(textBoxName.Text, RichTextBoxAbout.Text, tags, textBoxPhone.Text, textBoxMail.Text);
            this.Close();
        }
    }
}