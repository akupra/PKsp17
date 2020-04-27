using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKsp17
{
    public partial class FormStudentCollection : Form
    {
        private bool IsShown { get; }
        private BindingList<Student> Students { get; }
        public FormStudentCollection()
        {
            InitializeComponent();

            this.IsShown = false;

            #region Заполнение комбобокса со статусами
            StatusesExtended.IntoComboBox(this.cmbxStatus, true);
            this.cmbxStatus.SelectedValue = Statuses.None;
            #endregion

            #region Инициализация списка студентов
            this.Students = DataFile.GetAllStudents();
            #endregion

            #region Установка двойной буферизации для DataGridView, чтобы рисовалась по-человечески
            {
                PropertyInfo pi = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic);
                if (pi != null)
                {
                    pi.SetValue(this.dgvStudents, true, null);
                }
            }
            #endregion

            this.IsShown = true;
            this.Fill();
        }

        /// <summary>
        /// Применяет фильтр к списку студентов
        /// </summary>
        private void Fill()
        {
            if (!this.IsShown) { return; }

            var mask = this.txtbxFilter.Text.ToLower().Trim();
            var status = (Statuses)this.cmbxStatus.SelectedValue;
            var students = this.Students.Where
                            (
                                c =>
                                c.Name.ToLower().Contains(mask)
                                && (c.Status == status || status == Statuses.None)
                            )
                            .ToList();

            bool fisrtTime = this.dgvStudents.DataSource == null;
            this.dgvStudents.DataSource = students;

            this.lblStudentAmount.Text = string.Format("Отображено студентов: {0}", students.Count);

            //Если фильтр применен в самый первый раз, то зададим заголовки столбцов
            if (fisrtTime)
            {
                this.dgvStudents.Columns["Id"].Visible = false;
                this.dgvStudents.Columns["Photo"].Visible = false;
                this.dgvStudents.Columns["IsReal"].Visible = false;
                this.dgvStudents.Columns["Exercise"].Visible = false;
                this.dgvStudents.Columns["Name"].HeaderText = "ФИО";
                this.dgvStudents.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                this.dgvStudents.Columns["ViewMark1"].HeaderText = "Просмотр\n1";
                this.dgvStudents.Columns["ViewMark2"].HeaderText = "Просмотр\n2";
                this.dgvStudents.Columns["LaboratoriesMark"].HeaderText = "Баллы\nза лабы\n(6 шт.)";
                this.dgvStudents.Columns["AllLaboratoriesPassed"].HeaderText = "Сданы\nвсе\nлабы";
                this.dgvStudents.Columns["TimelyLaboratories"].HeaderText = "Лабы\nсданы\nвовремя\n(6 шт.)";
                this.dgvStudents.Columns["CourseWorkBall"].HeaderText = "Балл\nза КР\n(из100)";
                this.dgvStudents.Columns["CourseWorkMark"].HeaderText = "Оценка\nза курсовик";
                this.dgvStudents.Columns["AutoExamMark"].HeaderText = "Автомат\nза экзамен";
                this.dgvStudents.Columns["ExamMark"].HeaderText = "Оценка\nза экзамен";
                this.dgvStudents.Columns["Status"].HeaderText = "Статус";

                //Добавить кнопку "удалить" в каждой строке
                this.dgvStudents.Columns.Add
                    (
                        new DataGridViewButtonColumn
                        {
                            Name = "Delete",
                            HeaderText = "",
                            Text = "удалить",
                            UseColumnTextForButtonValue = true,
                        }
                    );
            }
        }

        /// <summary>
        /// Отобразит карточку студента
        /// </summary>
        /// <param name="student">Студент</param>
        private void ViewStudent(Student student)
        {
            if (student != null)
            {
                bool isNew = !student.IsReal;
                FormStudentInfo f = new FormStudentInfo(student);
                f.ShowDialog(this);

                if (isNew && student.IsReal)
                {
                    this.Students.Add(student);
                    this.Fill();
                }
                else if (!isNew && !student.IsReal)
                {
                    this.Students.Remove(student);
                    this.Fill();
                }
                this.PaintStudents();
                this.dgvStudents.Refresh();
            }
        }

        /// <summary>
        /// Раскрасит список студентов
        /// </summary>
        private void PaintStudents()
        {
            foreach (DataGridViewRow row in this.dgvStudents.Rows)
            {
                var student = row.DataBoundItem as Student;

                row.DefaultCellStyle.BackColor = student.Status == Statuses.Debetor ? Color.Gray
                                                    : student.Status == Statuses.NotAllowed ? Color.LightGray
                                                    : Color.White;

                row.Cells["ExamMark"].Style.BackColor = student.ExamMark == Marks.V ? Color.LightGreen
                                                                    : student.ExamMark == Marks.IV ? Color.LightYellow
                                                                    : student.ExamMark == Marks.III ? Color.LightGray
                                                                    : Color.LightCoral;
                row.Cells["CourseWorkMark"].Style.BackColor = student.CourseWorkMark == Marks.V ? Color.LightGreen
                                                                    : student.CourseWorkMark == Marks.IV ? Color.LightYellow
                                                                    : student.CourseWorkMark == Marks.III ? Color.LightGray
                                                                    : Color.LightCoral;
                row.Cells["AutoExamMark"].Style.BackColor = student.AutoExamMark == Marks.V ? Color.LightGreen
                                                                    : student.AutoExamMark == Marks.IV ? Color.LightYellow
                                                                    : student.AutoExamMark == Marks.III ? Color.LightGray
                                                                    : Color.White;
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e) => this.ViewStudent(new Student());
        private void btnRefresh_Click(object sender, EventArgs e) => this.Fill();

        private void dgvStudents_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) { return; }
            var student = (sender as DataGridView).Rows[e.RowIndex].DataBoundItem as Student;
            this.ViewStudent(student);
        }
        private void dgvStudents_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) => this.PaintStudents();
        private void dgvStudents_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            var student = dgv.Rows[e.RowIndex].DataBoundItem as Student;

            if (dgv.Columns[e.ColumnIndex].Name == "AutoExamMark")
            {
                e.Value = student.AutoExamMark == Marks.None ? "" : student.AutoExamMark.ToString();
            }
            else if (dgv.Columns[e.ColumnIndex].Name == "CourseWorkMark")
            {
                e.Value = student.CourseWorkMark == Marks.None ? "" : student.CourseWorkMark.ToString();
            }
            else if (dgv.Columns[e.ColumnIndex].Name == "ExamMark")
            {
                e.Value = student.ExamMark == Marks.None ? "" : student.ExamMark.ToString();
            }
            else if(dgv.Columns[e.ColumnIndex].Name == "Status")
            {
                e.Value = student.Status.GetEnumDescription();
            }
        }
        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            var student = dgv.Rows[e.RowIndex].DataBoundItem as Student;

            if (dgv.Columns[e.ColumnIndex].Name == "Delete")
            {
                string message = string.Format("Вы уверены, что хотите удалить студента '{0}'?", student.Name);
                if
                (
                    MessageBox.Show(message, "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                    == DialogResult.Yes
                )
                {
                    student.Delete();
                    this.Students.Remove(student);
                    this.Fill();
                }
            }
        }
    }
}
