using System.Reflection;

namespace WikiPrototype
{
    public partial class Form1 : Form
    {

        string[,] recordArray = new string[12,4];

        public Form1()
        {
            InitializeComponent();
        }

        public void DisplayListBox()
        {
            listBox1.Items.Clear();

            for (int i = 0; i < recordArray.GetLength(0); i++)
            {
                for (int j = 0; j < recordArray.GetLength(1); j++)
                {
                    if (recordArray[i, j] != null)
                    {
                        if (j != 0 && j % 3 == 0)
                        {
                            Record tempRecord = new Record(recordArray[i, j], recordArray[i, j], recordArray[i, j], recordArray[i, j]);
                            string text = tempRecord.DisplayRecord(tempRecord);
                            listBox1.Items.Add(text);
                        }
                    }
                }
            }
        }

        public void ClearTextBoxes()
        {
            txtBoxName.Clear();
            txtBoxCategory.Clear();
            txtBoxStructure.Clear();
            txtBoxDefinition.Clear();
        }

        public void AddRecordToArray(Record inputRecord)
        {
            bool isAdded = false;
            for (int i = 0; i < recordArray.GetLength(0); i++)
            {
                for (int j = 0; j < recordArray.GetLength(1); j++)
                {
                    if (isAdded == false && recordArray[i, j] == null )
                    {
                        recordArray[i, 0] = inputRecord.name;
                        recordArray[i, 1] = inputRecord.category;
                        recordArray[i, 2] = inputRecord.structure;
                        recordArray[i, 3] = inputRecord.definition;
                        isAdded = true;
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxName.Text) == false && string.IsNullOrEmpty(txtBoxCategory.Text) == false &&
                    string.IsNullOrEmpty(txtBoxStructure.Text) == false && string.IsNullOrEmpty(txtBoxDefinition.Text) == false)
            {
                Record newRecord = new Record(txtBoxName.Text, txtBoxCategory.Text, txtBoxStructure.Text, txtBoxDefinition.Text);
                AddRecordToArray(newRecord);
                ClearTextBoxes();
                DisplayListBox();

            }
            else
            {
                toolStripStatusLabel1.Text = "Make sure all attributes are filled before adding a record";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to edit selected value?", "Confirmation Required", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes && listBox1.SelectedIndex != -1)
            {
                if (listBox1.SelectedIndex == -1)
                {
                    toolStripStatusLabel1.Text = "Select a value to delete";
                    txtBoxName.Focus();
                }
                else
                {
                    int ptr = listBox1.SelectedIndex;

                    // basically, this will always evaluate true. it's just saying to only loop only once, at the selected index.
                    for (int i = ptr; i == listBox1.SelectedIndex; i++)
                    {
                        // loop to the three parameters of a record
                        for (int j = 0; j < 4; j++)
                        {
                            // make these parameters null on the given record
                            recordArray[i, j] = null;
                        }
                    }
                    DisplayListBox();
                    ClearTextBoxes();
                    txtBoxName.Focus();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxName_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ClearTextBoxes();
            txtBoxName.Focus();
        }
    }
}