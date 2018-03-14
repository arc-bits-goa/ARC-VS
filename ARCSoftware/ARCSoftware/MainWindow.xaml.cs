
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace ARCSoftware
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        List<Student> list = new List<Student>();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BT_import_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Excel files |*.xls; *xlsx; *.xlsm";
            choofdlog.Multiselect = false;
            string sFileName = "";
            if (choofdlog.ShowDialog().ToString().Equals("OK"))
            {
                sFileName = choofdlog.FileName;
               // string[] arrAllFiles = choofdlog.FileNames; //used when Multiselect = true           
            }
            list = ExcelReader.Read(sFileName);
            
            for(int i=0;i<list.Count;i++)
            {
                LB_list.Items.Add(list[i]);
                
            }
            LB_list.IsDropDownOpen = true;
           
        }

        private void LB_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Student st = (Student)LB_list.SelectedValue;
            t_EMPID.Text = Convert.ToString(st.EMPID);
            t_GENDER.Text = st.Gender;
            t_CGPA.Text = Convert.ToString(st.CGPA);
            t_NAME.Text = Convert.ToString(st.Name);
            t_SEMESTER.Text = Convert.ToString(st.Semester);
            t_YEAR.Text = Convert.ToString(st.Year);
            t_ID.Text = Convert.ToString(st.ID);



        }
    }
}
