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

namespace PKsp17
{
    public partial class FormStudentInfo : Form
    {
        /// <summary>
        /// Редактируемый студент
        /// </summary>
        private Student Student { get; }
        public FormStudentInfo(Student student)
        {
            InitializeComponent();

            this.Student = student;

            #region Заполнение комбобоксов с оценками
            Marks[] marks = (Marks[])Enum.GetValues(typeof(Marks));
            this.cmbxMaxMark.DataSource = marks.Where(c => c != Marks.None).ToList();
            this.cmbxAutoMark.DataSource = marks.ToList();
            #endregion

            #region Заполнение комбобокса со статусами
            StatusesExtended.IntoComboBox(this.cmbxStatus, false);
            #endregion

            this.Fill();
        }

        /// <summary>
        /// Заполнит информацию о студенте
        /// </summary>
        private void Fill()
        {
            this.Text = this.Student.IsReal ? this.Student.Name : "Добавление студента";
            this.btnDelete.Visible = this.Student.IsReal;
            this.txtbxName.Text = this.Student.Name;
            this.cmbxStatus.SelectedValue = this.Student.Status;

            this.pctrbxPhoto.Image = this.Student.Photo;

            this.txtbxLaboratoriesMark.Text = this.Student.LaboratoriesMark.ToString();
            this.chbxTimelyLaboratories.Checked = this.Student.TimelyLaboratories;
            this.chbxAllLaboratoriesPassed.Checked = this.Student.AllLaboratoriesPassed;

            this.chbxViewMark1.Checked = this.Student.ViewMark1;
            this.chbxViewMark2.Checked = this.Student.ViewMark2;
            this.txtbxCourseWorkBall.Text = this.Student.CourseWorkBall.ToString();
            this.cmbxMaxMark.SelectedItem = this.Student.MaxCourseWorkMark;
            this.cmbxAutoMark.SelectedItem = this.Student.AutoCourseWorkMark;
        }

        /// <summary>
        /// Сохранит изменения в источнике данных
        /// </summary>
        private void Save()
        {
            string message = "";

            if (string.IsNullOrWhiteSpace(this.txtbxName.Text)) { message += "Не указано ФИО\n"; }
            if (string.IsNullOrWhiteSpace(this.txtbxLaboratoriesMark.Text)) { message += "Не указан балл за лабы\n"; }
            if (string.IsNullOrWhiteSpace(this.txtbxCourseWorkBall.Text)) { message += "Не указан балл за КР\n"; }
            if ((Marks)this.cmbxMaxMark.SelectedItem == Marks.None) { message += "Не указана максимальная оценка\n"; }
            if (this.cmbxStatus.SelectedValue == null) { message += "Не указан статус\n"; }

            if (!string.IsNullOrWhiteSpace(message))
            {
                message = message.Trim('\n');
                MessageBox.Show(message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.Student.Name = this.txtbxName.Text.Trim();
            this.Student.Status = (Statuses)this.cmbxStatus.SelectedValue;

            this.Student.LaboratoriesMark = Convert.ToInt32(this.txtbxLaboratoriesMark.Text);
            this.Student.TimelyLaboratories = this.chbxTimelyLaboratories.Checked;
            this.Student.AllLaboratoriesPassed = this.chbxAllLaboratoriesPassed.Checked;

            this.Student.ViewMark1 = this.chbxViewMark1.Checked;
            this.Student.ViewMark2 = this.chbxViewMark2.Checked;
            this.Student.CourseWorkBall = Convert.ToInt32(this.txtbxCourseWorkBall.Text);
            this.Student.MaxCourseWorkMark = (Marks)this.cmbxMaxMark.SelectedItem;
            this.Student.AutoCourseWorkMark = (Marks)this.cmbxAutoMark.SelectedItem;

            this.Student.Save();
            this.Fill();
        }

        /// <summary>
        /// Удалит студента из источника данных
        /// </summary>
        private void Delete()
        {
            if (!this.Student.IsReal) { return; }

            if
            (
                MessageBox.Show("Вы уверены, что хотите удалить студента?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes
            )
            {
                this.Student.Delete();
                this.Close();
            }
        }

        /// <summary>
        /// Откроет и сохранит аватарку для студента
        /// </summary>
        private void SetImage()
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Файлы JPG (*.jpg)|*.jpg",
                Multiselect = false
            };

            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                this.Student.Photo = Image.FromFile(ofd.FileName);
                this.pctrbxPhoto.Image = this.Student.Photo;
            }
        }

        /// <summary>
        /// Удалит аватарку студента
        /// </summary>
        private void DeleteImage()
        {
            if
            (
                MessageBox.Show("Вы уверены, что хотите удалить аватарку студента?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes
            )
            {
                this.Student.Photo = null;
                this.pctrbxPhoto.Image = this.Student.Photo;
            }
        }

        private void txtbxLaboratoriesMark_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-' && (sender as TextBox).Text.Contains(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
            else if
            (
                !Char.IsDigit(e.KeyChar)
                && (e.KeyChar != '\b')
                && (e.KeyChar != '\r')
                && (e.KeyChar != '-')
                && (e.KeyChar != 3) /*Ctrl+C*/
                && (e.KeyChar != 22) /*Ctrl+V*/
            )
            {
                e.Handled = true;
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e) => this.Save();
        private void btnDelete_Click(object sender, EventArgs e) => this.Delete();

        private void btnSelectImage_Click(object sender, EventArgs e) => this.SetImage();
        private void btnDeleteImage_Click(object sender, EventArgs e) => this.DeleteImage();
    }
}
