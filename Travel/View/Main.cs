using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using TravelCore.Controller;
using TravelCore.DAO;
using TravelCore.Model;
using TravelCore.ViewModel;

namespace TravelCore.View
{
    public partial class Main : Form
    {
        private readonly TravelController controller;

        public Main()
        {
            InitializeComponent();

            controller = new TravelController(new TravelAdoDao());

            var categories = controller.GetCategories();

            categoryFilterComboBox.Items.Add("");

            foreach (var category in categories)
            {
                categoryFilterComboBox.Items.Add(category); 
            }
        }

        private void addTravelMenuItem_Click(object sender, EventArgs e)
        {
            using var addTravelForm = new AddTravel(controller);
            var result = addTravelForm.ShowDialog();

            // TODO: check for uniqueness
            if (result == DialogResult.OK)
                categoryFilterComboBox.Items.Add(addTravelForm.addedCategory);
        }

        private void listTravelsMenuItem_Click(object sender, EventArgs e)
        {
            IEnumerable<Travel> travels;

            if (categoryFilterComboBox.SelectedItem == null || categoryFilterComboBox.SelectedItem.Equals(""))
                travels = controller.GetTravels();
            else 
                travels = controller.GetTravelsOfCategory(categoryFilterComboBox.SelectedItem.ToString());

            var travelViewModels = new List<TravelViewModel>();

            foreach (var travel in travels) {
                travelViewModels.Add(new TravelViewModel
                {
                    Name = travel.Name,
                    Category = travel.Category,
                    Country = travel.Country,
                    Description = travel.Description,
                    Priority = travel.Priority
                });
            }

            travelsDataGridView.DataSource = travelViewModels.OrderByDescending(travelVM => travelVM.Priority).ToList();
        }
    }
}
