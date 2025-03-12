namespace SimpleFormsAppWithCheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] movies = { "NeedForSpeed", "Fast&Furious", "DeathRace", "Cars", "GranTurismo" };
            mvSeriesList.Items.AddRange(movies);
        }

        private void rmvButton_Click(object sender, EventArgs e)
        {
            if (favoriteList.Items.Count >= 1)
            {
                favoriteList.Items.Remove(favoriteList.SelectedItem);
            }
        }

        private void clrButton_Click(object sender, EventArgs e)
        {
            favoriteList.Items.Clear();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            foreach (var movies in mvSeriesList.Items)
            {
                bool isSelected = mvSeriesList.GetItemChecked(mvSeriesList.Items.IndexOf(movies));
                if (isSelected && !favoriteList.Items.Contains(movies))
                {
                    favoriteList.Items.Add(movies);
                }

            }
        }
    }
}
