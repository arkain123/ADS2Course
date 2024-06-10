namespace Lab6
{
    public partial class Form1 : Form
    {
        Hash init;
        public Form1()
        {
            InitializeComponent();
            init = new Hash();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            MiscTextBox.Clear();
            string response = init.AddElement(LastNameTextBox.Text);
            DisplayTree();
            MiscTextBox.Text += response;
        }

        public void DisplayTree()
        {
            treeView.Nodes.Clear();
            string[] arr = init.Arr;

            for (int i = 0; i < init.GetLEN(); i++)
            {
                if (arr[i] != "0")
                {
                    treeView.Nodes.Add(i + " : " + arr[i]);
                }
            }

            DisplayCoeff(treeView.Nodes.Count, 101 - treeView.Nodes.Count);
        }

        public void DisplayCoeff(double full_elem, double null_elem)
        {
            coeffTextBox.Text = (full_elem / null_elem).ToString();
        }
    }
}
