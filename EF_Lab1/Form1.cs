using EF_Lab1.Models;
using Microsoft.EntityFrameworkCore;
namespace EF_Lab1
{
    public partial class Form1 : Form
    {
        CompanyContext db;
        public Form1()
        {
            db = new CompanyContext();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_employees.DataSource = db.Employees.Include(n => n.DnoNavigation).Select(n => new { n.Ssn, n.Fname, n.Lname, n.Salary, n.Address, deptname = n.DnoNavigation.Dname }).ToList();

            cb_dept.DataSource = db.Departments.ToList();
            cb_dept.ValueMember = "Dnumber";
            cb_dept.DisplayMember = "Dname";

            btn_delete.Visible = false;
            btn_update.Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Employee s = new Employee()
            {
                Fname = txt_fname.Text,
                Lname = txt_lname.Text,
                Salary = int.Parse(txt_salary.Text),
                Address = txt_address.Text,
                Dno = (int)cb_dept.SelectedValue,
            };

            db.Employees.Add(s);
            db.SaveChanges();

            dgv_employees.DataSource = db.Employees.Include(n => n.DnoNavigation).Select(n => new { n.Ssn, n.Fname, n.Lname, n.Salary, n.Address, deptname = n.DnoNavigation.Dname, location = n.DnoNavigation.DeptLocations }).ToList();
            txt_address.Text = txt_fname.Text = txt_lname.Text = txt_salary.Text = "";
            MessageBox.Show("sucessfuly added");
        }
        int id;
        private void dgv_employees_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_employees.SelectedRows[0].Cells[0].Value;

            Employee s = db.Employees.Where(s => s.Ssn == id).SingleOrDefault();

            txt_fname.Text = s.Fname;
            txt_lname.Text = s.Lname;
            txt_salary.Text = (s.Salary ?? 0).ToString();
            txt_address.Text = s.Address;
            cb_dept.SelectedValue = s.Dno;

            btn_add.Visible = false;
            btn_delete.Visible = true;
            btn_update.Visible = true;

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Employee s = db.Employees.Where(n => n.Ssn == id).SingleOrDefault();
            s.Fname = txt_fname.Text;
            s.Lname = txt_lname.Text;
            s.Salary = decimal.Parse(txt_salary.Text);
            s.Address = txt_address.Text;
            s.Dno = (int)cb_dept.SelectedValue;

            db.SaveChanges();
            dgv_employees.DataSource = db.Employees.Include(n => n.DnoNavigation).Select(n => new { n.Ssn, n.Fname, n.Lname, n.Salary, n.Address, deptname = n.DnoNavigation.Dname, location = n.DnoNavigation.DeptLocations }).ToList();
            txt_address.Text = txt_fname.Text = txt_lname.Text = txt_salary.Text = "";
            MessageBox.Show("sucessfuly updated");

            btn_add.Visible = true;
            btn_delete.Visible = false;
            btn_update.Visible = false;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Employee s = db.Employees.Where(n => n.Ssn == id).SingleOrDefault();

            db.Employees.Remove(s);

            db.SaveChanges();


            dgv_employees.DataSource = db.Employees.Include(n => n.DnoNavigation).Select(n => new { n.Ssn, n.Fname, n.Lname, n.Salary, n.Address, deptname = n.DnoNavigation.Dname, location = n.DnoNavigation.DeptLocations }).ToList();
            txt_address.Text = txt_fname.Text = txt_lname.Text = txt_salary.Text = "";
            MessageBox.Show("sucessfuly deleted");
            btn_add.Visible = true;
            btn_delete.Visible = false;
            btn_update.Visible = false;
        }


    }
}
