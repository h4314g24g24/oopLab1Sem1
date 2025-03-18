using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oopLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = cmbType.SelectedItem.ToString();

            if (selectedType == "Car")
            {
                lblExtra.Text = "Тип пального";
                txtExtra.Visible = true;
            }
            else if (selectedType == "Bus")
            {
                lblExtra.Text = "Номер маршруту";
                txtExtra.Visible = true;
            }
            else if (selectedType == "Bicycle")
            {
                lblExtra.Text = "Є передачі";
                txtExtra.Visible = true; 
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string brand = txtBrand.Text;
            int speed, capacity;

            if (!int.TryParse(txtSpeed.Text, out speed) || speed <= 0)
            {
                MessageBox.Show("Швидкість має бути додатним числом!");
                return;
            }
            if (!int.TryParse(txtCapacity.Text, out capacity) || capacity <= 0)
            {
                MessageBox.Show("Вмістимість має бути додатним числом!");
                return;
            }

            Transport transport = null;

            // Отримуємо значення вибраного типу транспорту, обрізаємо зайві пробіли
            string selectedType = cmbType.SelectedItem.ToString().Trim();

            // Діагностика, щоб перевірити, яке значення реально отримується
            MessageBox.Show($"Обраний тип: '{selectedType}'");

            switch (selectedType)
            {
                case "Car":
                    transport = new Car(brand, speed, capacity, txtExtra.Text);
                    break;
                case "Bus":
                    int route;
                    if (!int.TryParse(txtExtra.Text, out route) || route <= 0)
                    {
                        MessageBox.Show("Номер маршруту має бути додатним числом!");
                        return;
                    }
                    transport = new Bus(brand, speed, capacity, route);
                    break;
                case "Bicycle":
                    bool hasGears = txtExtra.Text.ToLower() == "так" || txtExtra.Text == "1";
                    transport = new Bicycle(brand, speed, capacity, hasGears);
                    break;
                default:
                    MessageBox.Show($"Невідомий тип транспорту: '{selectedType}'!");
                    return;
            }

            if (transport != null)
            {
                lstTransport.Items.Add(transport.GetInfo());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstTransport.Items.Clear();
        }

        private void btnSave_Click_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("data.txt"))
            {
                foreach (var item in lstTransport.Items)
                {
                    writer.WriteLine(item.ToString());
                }
            }
            MessageBox.Show("Дані збережено у файл data.txt!");
        }

        private void btnLoad_Click_Click(object sender, EventArgs e)
        {
            if (File.Exists("data.txt"))
            {
                lstTransport.Items.Clear();
                using (StreamReader reader = new StreamReader("data.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lstTransport.Items.Add(line);
                    }
                }
                MessageBox.Show("Дані завантажено з файлу!");
            }
            else
            {
                MessageBox.Show("Файл не знайдено!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstTransport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
