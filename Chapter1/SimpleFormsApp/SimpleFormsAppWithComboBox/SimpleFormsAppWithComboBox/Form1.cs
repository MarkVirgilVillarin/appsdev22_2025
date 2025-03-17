using System.Diagnostics.Eventing.Reader;

namespace SimpleFormsAppWithComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] foodCuisine = { "Filipino", "Japanese", "Chinese", "Korean" };
            comboBox.Items.AddRange(foodCuisine);
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.SelectedIndex = 0;


        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count >= 1)
            {
                listBox.Items.Remove(listBox.SelectedItem);

            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox.Items)
            {
                bool isSelected = checkedListBox.GetItemChecked(checkedListBox.Items.IndexOf(item));
                if (isSelected && !listBox.Items.Contains(item))
                {
                    listBox.Items.Add(item);
                }

            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {

        }

        private void selcBtn_Click(object sender, EventArgs e)
        {
            string[] FilipinoFood = { "Adobo", "Lechon baboy", "Lechon manok", "Bicol", "ginamay" };
            string[] JapaneseFood = { "Sushi", "Ramen", "Udon", "Takoyaki", "Sashimi", };
            string[] ChineseFood = { "Kung Pao", "Dumplings", "Xiao Long Bao", "Chow Mein", "Dim Sum" };
            string[] KoreanFood = { "Kimchi", "Galbi", "Samgyeopsal", "Samyang", "Bibimbap" };

            checkedListBox.Items.Clear();

            if (comboBox.SelectedItem.ToString().Contains("Filipino"))
            {
                checkedListBox.Items.AddRange(FilipinoFood);
            }
            else if (comboBox.SelectedItem.ToString().Contains("Japanese"))
            {
                checkedListBox.Items.AddRange(JapaneseFood);
            }
            else if (comboBox.SelectedItem.ToString().Contains("Chinese"))
            {
                checkedListBox.Items.AddRange(ChineseFood);
            }
            else if (comboBox.SelectedItem.ToString().Contains("Korean"))
            {
                checkedListBox.Items.AddRange(KoreanFood);
            }

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }



}               
            
        
    

