using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Linq.Dynamic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace BloodManagement
{
    public partial class ReportForm : Form
    {
        DataBase dataBase = new DataBase();      
        public ReportForm() {InitializeComponent();}    
        public ReportForm(string aggregateFunction, string aggregateFunctionText) : this()
        {
            SetAggregateFunction(aggregateFunction, aggregateFunctionText);
        }
        private void ReportForm_Load(object sender, EventArgs e)
        {
            using (var context = new BloodBankEntities2())
            {
                var data = GetCombinedData();
                var reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource("BloodDataSet", data);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                reportViewer1.LocalReport.ReportPath = "C:\\Users\\sawbeenah\\source\\repos\\BloodManagement\\BloodManagement\\BloodReport.rdlc";
                reportViewer1.RefreshReport();
            }
            SetAggregateFunction("SUM", "Sum quantity of units requested: ");
        }
        public List<CombinedClass> GetCombinedData()
        {
            try
            {
                using (var context = new BloodBankEntities2())
                {
                    var query = (from br in context.vw_BloodRequest
                                 select new CombinedClass
                                 {
                                     RequestID = br.RequestID,
                                     HospitalName = br.HospitalName,
                                     BloodType = br.BloodType,
                                     RhFactor = br.RhFactor,
                                     RequestUrgency = br.RequestUrgency,
                                     RequestDate = br.RequestDate,
                                     DeliveryDate = br.DeliveryDate,
                                     Status = br.Status,
                                     NumberOfUnits = br.NumberOfUnits
                                 });
                    if (checkBox1.Checked)
                    {
                        query = query.Where(data => data.HospitalName.Contains(comboBoxHospitalName.Text));
                    }
                    if (checkBox3.Checked)
                    {
                        var type = comboBoxBloodType.Text;
                        var factor = comboBoxRhFactor.Text;
                        query = query.Where(data => data.BloodType == type && data.RhFactor == factor);
                    }                    
                    if (checkBox2.Checked)
                    {
                        query = query.Where(data => data.RequestUrgency.ToString().Contains(comboBoxUrgency.Text));
                    }
                    if (checkBox6.Checked)
                    {
                        query = query.Where(data => data.DeliveryDate.ToString().Contains(dateTimePickerDeliveryDate.Text));
                    }
                    if (checkBox5.Checked)
                    {
                        var startdate = dateTimePickerRequestDate.Value;
                        var enddate = dateTimePicker1.Value;
                        query = query.Where(data => data.RequestDate >= startdate && data.RequestDate <= enddate);
                    }
                    return query.ToList();
                }               
            }
            catch 
            {
                using (var context = new BloodBankEntities2())
                {
                    var query = (from br in context.vw_BloodRequest
                                 select new CombinedClass
                                 {
                                     RequestID = br.RequestID,
                                     HospitalName = br.HospitalName,
                                     BloodType = br.BloodType,
                                     RhFactor = br.RhFactor,
                                     RequestUrgency = br.RequestUrgency,
                                     RequestDate = br.RequestDate,
                                     DeliveryDate = br.DeliveryDate,
                                     Status = br.Status,
                                     NumberOfUnits = br.NumberOfUnits
                                 }).Distinct();
                    return query.ToList();
                }
            }
        }
        private void reportViewer1_Load(object sender, EventArgs e) { }
        private void SetAggregateFunction(string function, string functionText)
        {
            string aggregateExpression = function;
            Microsoft.Reporting.WinForms.ReportParameter parameter = new Microsoft.Reporting.WinForms.ReportParameter("AggregateFunction", aggregateExpression);
            Microsoft.Reporting.WinForms.ReportParameter parameterText = new Microsoft.Reporting.WinForms.ReportParameter("AggregateFunctionText", functionText);
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter[] { parameter, parameterText });
            reportViewer1.RefreshReport();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SetAggregateFunction("SUM", "Sum quantity of units requested: ");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SetAggregateFunction("AVG", "Average quantity of units requested: ");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SetAggregateFunction("MIN", "Minimum quantity of units requested: ");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            SetAggregateFunction("MAX", "Maximum quantity of units requested: ");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            SetAggregateFunction("COUNT", "Count of requests: ");
        }
        private void pictureBox1_Click(object sender, EventArgs e) {this.Hide();}
        private void comboBoxHospitalName_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBoxUrgency_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBoxBloodType_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBoxRhFactor_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dateTimePickerRequestDate_ValueChanged(object sender, EventArgs e) { }
        private void dateTimePickerDeliveryDate_ValueChanged(object sender, EventArgs e) { }
        private void button7_Click(object sender, EventArgs e)
        {
            List<CombinedClass> data = GetCombinedData();                        
            LoadReportWithData(data);
        }
        private void LoadReportWithData(List<CombinedClass> data)
        {
            var reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource("BloodDataSet", data);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.ReportPath = "C:\\Users\\sawbeenah\\source\\repos\\BloodManagement\\BloodManagement\\BloodReport.rdlc";
            reportViewer1.RefreshReport();
        }
    }
}
