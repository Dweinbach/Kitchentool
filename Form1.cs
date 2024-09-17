using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace KitchenUnitConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeComboBoxes();
            AddAboutToContextMenu();
        }

        private void AddAboutToContextMenu()
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem aboutItem = new ToolStripMenuItem("About");
            aboutItem.Click += AboutItem_Click;
            contextMenu.Items.Add(aboutItem);
            this.ContextMenuStrip = contextMenu;
        }

        private void InitializeComboBoxes()
        {
            // Volume units
            cboVolumeFrom.Items.AddRange(new string[] { "ml", "tsp", "tbsp", "cups" });
            cboVolumeTo.Items.AddRange(new string[] { "ml", "tsp", "tbsp", "cups" });
            cboVolumeFrom.SelectedIndex = 0;
            cboVolumeTo.SelectedIndex = 0;

            // Weight units
            cboWeightFrom.Items.AddRange(new string[] { "g", "lbs", "oz" });
            cboWeightTo.Items.AddRange(new string[] { "g", "lbs", "oz" });
            cboWeightFrom.SelectedIndex = 0;
            cboWeightTo.SelectedIndex = 0;
        }

        private void btnConvertVolume_Click(object sender, EventArgs e)
        {
            ConvertVolume();
        }

        private void btnConvertWeight_Click(object sender, EventArgs e)
        {
            ConvertWeight();
        }

        private void ConvertVolume()
        {
            string input = txtVolumeFrom.Text;
            string fromUnit = ExtractUnit(input, new string[] { "ml", "tsp", "tbsp", "cups" });
            if (fromUnit == null)
            {
                fromUnit = cboVolumeFrom.SelectedItem.ToString();
            }

            if (double.TryParse(Regex.Match(input, @"\d+(\.\d+)?").Value, out double value))
            {
                string toUnit = cboVolumeTo.SelectedItem.ToString();
                double result = ConvertVolumeUnit(value, fromUnit, toUnit);
                txtVolumeTo.Text = $"{result:F2} {toUnit}";
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a number followed by a unit.");
            }
        }

        private void ConvertWeight()
        {
            string input = txtWeightFrom.Text;
            string fromUnit = ExtractUnit(input, new string[] { "g", "lbs", "oz" });
            if (fromUnit == null)
            {
                fromUnit = cboWeightFrom.SelectedItem.ToString();
            }

            if (double.TryParse(Regex.Match(input, @"\d+(\.\d+)?").Value, out double value))
            {
                string toUnit = cboWeightTo.SelectedItem.ToString();
                double result = ConvertWeightUnit(value, fromUnit, toUnit);
                txtWeightTo.Text = $"{result:F2} {toUnit}";
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a number followed by a unit.");
            }
        }

        private string ExtractUnit(string input, string[] units)
        {
            foreach (string unit in units)
            {
                if (input.ToLower().Contains(unit.ToLower()))
                {
                    return unit;
                }
            }
            return null;
        }

        private double ConvertVolumeUnit(double value, string fromUnit, string toUnit)
        {
            // Convert to ml first
            double mlValue = fromUnit switch
            {
                "ml" => value,
                "tsp" => value * 4.92892,
                "tbsp" => value * 14.7868,
                "cups" => value * 236.588,
                _ => throw new ArgumentException("Invalid unit"),
            };

            // Convert from ml to target unit
            return toUnit switch
            {
                "ml" => mlValue,
                "tsp" => mlValue / 4.92892,
                "tbsp" => mlValue / 14.7868,
                "cups" => mlValue / 236.588,
                _ => throw new ArgumentException("Invalid unit"),
            };
        }

        private double ConvertWeightUnit(double value, string fromUnit, string toUnit)
        {
            // Convert to grams first
            double gValue = fromUnit switch
            {
                "g" => value,
                "lbs" => value * 453.592,
                "oz" => value * 28.3495,
                _ => throw new ArgumentException("Invalid unit"),
            };

            // Convert from grams to target unit
            return toUnit switch
            {
                "g" => gValue,
                "lbs" => gValue / 453.592,
                "oz" => gValue / 28.3495,
                _ => throw new ArgumentException("Invalid unit"),
            };
        }

        private void AboutItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright 2024 David Weinbach", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}