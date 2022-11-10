using TravelCore.Controller;
using TravelCore.Model;

namespace TravelCore.View
{
    internal partial class AddTravel : Form
    {
        private readonly TravelController controller;
        public string? addedCategory;

        public AddTravel(TravelController controller)
        {
            InitializeComponent();
            
            this.controller = controller;
        }

        private void addTravel_Click(object sender, EventArgs e)
        {
            addedCategory = null;

            string name = nameTextBox.Text;
            string category = categoryTextBox.Text;
            string country = countryTextBox.Text;
            string description = descriptionTextBox.Text;
            int priority = (int) priorityNumericUpDown.Value;

            if (name == string.Empty || category == string.Empty || country == string.Empty || description == string.Empty)
            {
                MessageBox.Show("Kotelezo megadni az osszes mezot", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Abort;
                return;
            }

            Travel travel = new Travel
            {
                Name = name,
                Category = category,
                Country = country,
                Description = description,
                Priority = priority
            };

            if (!controller.AddTravel(travel))
            {
                MessageBox.Show("Problema merult fel a muveletnel.", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Abort;
                return;
            }

            addedCategory = category;
        }
    }
}
