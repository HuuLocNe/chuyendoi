using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ChuyenDoi
{
    public partial class Form1 : Form
    {
        private ChuyenDoi chuyenDoi;

        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView(); // Tạo cột tự động trong DataGridView

            chuyenDoi = new ChuyenDoi();

            // Khởi tạo các nhóm đơn vị
            GrUnit length = new GrUnit("Length");
            length.AddUnit(new LengthUnit("Meter", "m", 1));
            length.AddUnit(new LengthUnit("Kilometer", "km", 0.001));
            length.AddUnit(new LengthUnit("Hectometer", "hm", 0.01));
            length.AddUnit(new LengthUnit("Decameter", "dam", 0.1));
            length.AddUnit(new LengthUnit("Deximeter", "dm", 10));
            length.AddUnit(new LengthUnit("Centimeter", "cm", 100));
            length.AddUnit(new LengthUnit("Milimeter", "mm", 1000));
            length.AddUnit(new LengthUnit("Inch", "inch", 39.3701));

            GrUnit weight = new GrUnit("Weight");
            weight.AddUnit(new WeightUnit("Kilogram", "kg", 1));
            weight.AddUnit(new WeightUnit("Tấn", "tấn", 0.001));
            weight.AddUnit(new WeightUnit("Tạ", "tạ", 0.01));
            weight.AddUnit(new WeightUnit("Yến", "yến", 0.1));
            weight.AddUnit(new WeightUnit("Hectogram", "hg", 10));
            weight.AddUnit(new WeightUnit("Decagram", "dag", 100));
            weight.AddUnit(new WeightUnit("Gram", "g", 1000));
            weight.AddUnit(new WeightUnit("Pound", "lb", 2.20462));

            GrUnit temperature = new GrUnit("Temperature");
            temperature.AddUnit(new Temperature("Celsius", "°C"));
            temperature.AddUnit(new Temperature("Fahrenheit", "°F"));
            temperature.AddUnit(new Temperature("Kelvin", "°K"));

            // Thêm các nhóm đơn vị vào danh sách chuyển đổi
            chuyenDoi.AddLoaiDonVi(length);
            chuyenDoi.AddLoaiDonVi(weight);
            chuyenDoi.AddLoaiDonVi(temperature);

            // Thêm các nhóm đơn vị vào ComboBox GrUnit
            foreach (var unit in chuyenDoi.DsLoaiDv)
            {
                cbbGrUnit.Items.Add(unit.NameGr);
            }
            // Thiết lập chế độ chỉ đọc cho ComboBox
            cbbGrUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTo.DropDownStyle = ComboBoxStyle.DropDownList;

            // Xử lý sự kiện khi người dùng chọn nhóm đơn vị
            cbbGrUnit.SelectedIndexChanged += CbbGrUnit_SelectedIndexChanged;

            // Xử lý sự kiện khi nhấn phím Enter trong TextBox
            textValue.KeyDown += TxtValue_KeyDown;
        }

        // Cập nhật các ComboBox dựa trên nhóm đơn vị đã chọn
        private void CbbGrUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedGroup = cbbGrUnit.SelectedItem.ToString();
            GrUnit selectedGrUnit = chuyenDoi.DsLoaiDv.FirstOrDefault(g => g.NameGr == selectedGroup);

            if (selectedGrUnit != null)
            {
                if (selectedGrUnit != null)
                {
                    cbbFrom.DataSource = selectedGrUnit.getname();
                    cbbTo.DataSource = selectedGrUnit.getname();
                }
            }
        }

        // Thực hiện chuyển đổi đơn vị và hiển thị kết quả
        private void PerformConvert()
        {
            try
            {
                double input = double.Parse(textValue.Text);
                string fromUnit = cbbFrom.SelectedItem.ToString();
                string toUnit = cbbTo.SelectedItem.ToString();
                string groupName = cbbGrUnit.SelectedItem.ToString();

                if (fromUnit == null || toUnit == null)
                {
                    throw new ArgumentException("Vui lòng chọn cả đơn vị nguồn và đơn vị đích.");
                }

                double result = chuyenDoi.Convertc_CD(input, fromUnit, toUnit, groupName);
                labelKQ.Text = $"{input} {fromUnit} = {result} {toUnit}";

                // Lưu kết quả vào DataGridView
                dgvSave.Rows.Add(input, fromUnit, result, toUnit, DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý sự kiện nhấn phím Enter trong TextBox
        private void TxtValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformConvert();
                e.Handled = true;
            }
        }

        // Cập nhật DataGridView để hiển thị kết quả chuyển đổi
        private void InitializeDataGridView()
        {
            // Thêm các cột vào DataGridView
            dgvSave.Columns.Add("Giá trị", "Giá trị");
            dgvSave.Columns.Add("Đơn vị gốc", "Đơn vị gốc");
            dgvSave.Columns.Add("Kết quả", "Kết quả");
            dgvSave.Columns.Add("Đơn vị mới", "Đơn vị mới");
            dgvSave.Columns.Add("Mốc thời gian", "Mốc thời gian");

            // Cập nhật chiều rộng cột "Mốc thời gian"
            dgvSave.Columns["Mốc thời gian"].Width = 200;

            // Thiết lập cột "Mốc thời gian" để hiển thị ngày giờ
            dgvSave.Columns["Mốc thời gian"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
        }
    }
}








