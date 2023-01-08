using System.ComponentModel;
using System.Text.Json;

namespace MonkeyManagement
{
    public partial class Form1 : Form
    {
        private List<Monkey> _monkeys;
        private int _currentRow = -1;
        private int _totalBananasAte = 0;
        private double _averageWeight = 0;

        public Form1()
        {
            string text = File.ReadAllText(@"../../../monkeys.json");
            var root = JsonSerializer.Deserialize<Root>(text);
            _monkeys = root.Monkeys;

            _averageWeight = GetAverageWeight(_monkeys);
            _totalBananasAte = GetTotalBananasAte(_monkeys);

            InitializeComponent();

            var list = new BindingList<Monkey>(_monkeys);
            dataGridView1.DataSource = list;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Columns[dataGridView1.Columns.Count - 1].Visible = false;

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.ImageLocation = _monkeys.FirstOrDefault().ImagePath;

            radioButton1.Checked = true;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != _currentRow)
            {
                _currentRow = dataGridView1.CurrentRow.Index;
                pictureBox1.ImageLocation = _monkeys[_currentRow].ImagePath;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = _totalBananasAte.ToString();
            label2.Text = "bananas";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = _averageWeight.ToString();
            label2.Text = "kg";
        }

        private double GetAverageWeight(List<Monkey> list)
        {
            double result = 0;

            foreach (Monkey monkey in list)
            {
                result += monkey.Weight;
            }

            return result / list.Count;
        }

        private int GetTotalBananasAte(List<Monkey> list)
        {
            int result = 0;

            foreach(Monkey monkey in list)
            {
                result += monkey.BananasAte;
            }

            return result;
        }
    }
}