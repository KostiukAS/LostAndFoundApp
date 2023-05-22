using LostAndFoundApp.Data;
using LostAndFoundApp.Program;

namespace LostAndFoundApp
{
    public partial class FormMain : Form
    {
        List<Finding> findings = new FindingsContext().Findings.ToList();
        FindingsContext findingsContext = new();
        List<string> usedFilters = new();
        string? filteredByWord;
        readonly List<Filter> filters = new FiltersContext().Filters.ToList();
        public static Finding? addedFinding;

        public FormMain()
        {
            InitializeComponent();

            foreach (var filter in filters)
            {
                CheckListBoxFilter.Items.Add(filter.Name);
            }
            foreach (var finding in findings)
            {
                lbFindings.Items.Add(finding.Name);
            }

            usedFilters = CheckListBoxFilter.CheckedItems.Cast<string>().ToList();
        }
        private void BtnAddFinding_Click(object sender, EventArgs e)
        {
            FormAddFinding formAddFinding = new()
            {
                tags = filters
            };
            formAddFinding.ShowDialog();
            
            if (addedFinding != null)
            {
                findings.Add(addedFinding);
                findingsContext.Findings.Add(addedFinding);
                findingsContext.SaveChanges();

                if (IsFindingFiltered(addedFinding))
                {
                    if ((filteredByWord != null && addedFinding.Name.Contains(filteredByWord)) || filteredByWord == null)
                    {
                        lbFindings.Items.Add(addedFinding.Name);
                    }
                }
                addedFinding = null;
            }
        }

        private void BtnDeleteFinding_Click(object sender, EventArgs e)
        {
            if (lbFindings.SelectedItem == null)
            {
                MessageBox.Show("Choose finding to delete!");
                return;
            }

            Finding findingToDelete = FindElemInFindings(lbFindings.Items.Cast<string>().ToList(), lbFindings.SelectedIndex);
            findingsContext.Remove(findingToDelete);
            findings.Remove(findingToDelete);
            findingsContext.SaveChanges();
            lbFindings.Items.RemoveAt(lbFindings.SelectedIndex);
        }

        private void BtnShowInfo_Click(object sender, EventArgs e)
        {
            if (lbFindings.SelectedItem == null)
            {
                MessageBox.Show("Choose finding!");
                return;
            }
            FormFindingInfo findingInfo = new()
            {
                finding = FindElemInFindings(lbFindings.Items.Cast<string>().ToList(), lbFindings.SelectedIndex)
            };
            findingInfo.ShowDialog();
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            if (CheckListBoxFilter.CheckedItems.Count == 0 && lbFindings.Items.Count == findings.Count)
            {
                MessageBox.Show("Choose filters!");
                return;
            }

            lbFindings.Items.Clear();
            usedFilters = CheckListBoxFilter.CheckedItems.Cast<string>().ToList();

            foreach (var finding in findings)
            {
                if (filteredByWord != null)
                {
                    if (!finding.Name.Contains(filteredByWord) && !IsFindingFiltered(finding))
                    {
                        continue;
                    }
                }
                else
                {
                    if(!IsFindingFiltered(finding))
                    {
                        continue;
                    }
                }
                lbFindings.Items.Add(finding.Name);
            }
        }

        private void BtnFilterRemove_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < CheckListBoxFilter.Items.Count; i++)
            {
                CheckListBoxFilter.SetItemChecked(i, false);
            }
            CheckListBoxFilter.ClearSelected();
            lbFindings.ClearSelected();
            usedFilters = CheckListBoxFilter.CheckedItems.Cast<string>().ToList();

            if (lbFindings.Items.Count == findings.Count)
            {
                return;
            }

            lbFindings.Items.Clear();
            foreach (var finding in findings)
            {
                if (filteredByWord != null)
                {
                    if (!finding.Name.Contains(filteredByWord))
                    {
                        continue;
                    }
                }
                lbFindings.Items.Add(finding.Name);
            }
        }

        private Finding FindElemInFindings(List<string> listOfFindings, int index)
        {
            if (listOfFindings.Count == findings.Count)
            {
                return findings[index];
            }
            else
            {
                int counter = -1;

                foreach (var finding in findings)
                {
                    int secondCounter = 0;
                    
                    for (int i = 0; i < usedFilters.Count; i++)
                    {
                        if (finding.KeyWords.Split(',').Contains(usedFilters[i]))
                        {
                            secondCounter++;
                            if (filteredByWord != null)
                            {
                                if (!finding.Name.Contains(filteredByWord))
                                {
                                    secondCounter--;
                                }
                            }
                        }
                    }
                    if (secondCounter == usedFilters.Count)
                    {
                        counter++;
                    }
                    if (index == counter)
                    {
                        return finding;
                    }
                }
            }
            return findings[index];
        }

        private bool IsFindingFiltered(Finding finding)
        {
            int iterator = 0;
            
            foreach (var filter in usedFilters)
            {
                if (finding.KeyWords.Split(',').Contains(filter))
                {
                    iterator++;
                }
            }

            if (iterator == usedFilters.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            List<string> findingsInListBox = lbFindings.Items.Cast<string>().ToList();
            
            lbFindings.Items.Clear();

            if (textBoxSearch.Text == null || textBoxSearch.Text.Length == 0 || textBoxSearch.Text.All(char.IsWhiteSpace))
            {
                foreach (var finding in findings)
                {
                    if (usedFilters.Count == 0 || IsFindingFiltered(finding))
                    {
                        lbFindings.Items.Add(finding.Name);
                    }
                }
                filteredByWord = null;
            }
            else
            {
                for (int i = 0; i < findingsInListBox.Count; i++)
                {
                    if (findingsInListBox[i].Contains(textBoxSearch.Text))
                    {
                        lbFindings.Items.Add(findingsInListBox[i]);
                    }
                }
                filteredByWord = textBoxSearch.Text;
            }
        }

        private void buttonClearSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = null;
            filteredByWord = null;
            lbFindings.Items.Clear();

            foreach (var finding in findings)
            {
                if (usedFilters.Count == 0 || IsFindingFiltered(finding))
                {
                    lbFindings.Items.Add(finding.Name);
                }
            }
        }
    }
}