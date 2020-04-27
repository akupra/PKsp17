using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKsp17
{
    public class Student
    {
        private string _photoString;
        private Image _photo;

        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// ФИО студента
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Своевременность 1-го просмотра
        /// </summary>
        public bool ViewMark1 { get; set; }

        /// <summary>
        /// Своевременность 2-го просмотра
        /// </summary>
        public bool ViewMark2 { get; set; }

        /// <summary>
        /// Оценки за первые 6ть лаб
        /// </summary>
        public int LaboratoriesMark { get; set; }

        /// <summary>
        /// Все первые 6ть оаб сданы вовремя?
        /// </summary>
        public bool TimelyLaboratories { get; set; }

        /// <summary>
        /// Все ли лабы сданы?
        /// </summary>
        public bool AllLaboratoriesPassed { get; set; }

        /// <summary>
        /// Балл за Кр (из 100)
        /// </summary>
        public int CourseWorkBall { get; set; }

        /// <summary>
        /// Оценка за КР
        /// </summary>
        public Marks CourseWorkMark { get; set; }

        /// <summary>
        /// Автомат за экзамен
        /// </summary>
        public Marks AutoExamMark { get; set; }

        /// <summary>
        /// Оценка за экзамен
        /// </summary>
        public Marks ExamMark { get; set; }

        /// <summary>
        /// Должник или молодец???
        /// </summary>
        public Statuses Status { get; set; }

        /// <summary>
        /// Аватарка
        /// </summary>
        public Image Photo
        {
            get
            {
                if (this._photo == null)
                {
                    if ((this._photoString?.Length ?? 0) > 0)
                    {
                        try
                        {
                            this._photo = Image.FromStream(new MemoryStream(Convert.FromBase64String(this._photoString)));
                        }
                        catch { }
                    }
                }
                return this._photo;
            }
            set
            {
                this._photo = value;
                if (value != null)
                {
                    using (MemoryStream m = new MemoryStream())
                    {
                        value.Save(m, value.RawFormat);
                        byte[] imageBytes = m.ToArray();
                        this._photoString = Convert.ToBase64String(imageBytes);

                        m.Close();
                    }
                }
                else
                {
                    this._photoString = null;
                }
            }
        }

        /// <summary>
        /// Показывавет, существует ли студент в источнике данных
        /// </summary>
        public bool IsReal => this.Id > -1;

        /// <summary>
        /// Задание на защиту
        /// </summary>
        public string Exercise { get; set; }

        public Student()
        {
            this.Id = -1;
            this.Name = "";
            this.ViewMark1 = false;
            this.ViewMark2 = false;
            this.LaboratoriesMark = 0;
            this.TimelyLaboratories = false;
            this.AllLaboratoriesPassed = false;
            this.CourseWorkBall = 0;
            this.CourseWorkMark = Marks.None;
            this.AutoExamMark = Marks.None;
            this.ExamMark = Marks.None;
            this.Status = Statuses.Debetor;
            this.Exercise = "";

            this._photoString = null;
        }
        public Student(string line)
            : this()
        {
            var items = line.Split(DataFile.Delimiter);
            if (items.Length > 0)
            {
                int n = 0;
                if (int.TryParse(items[0], out n))
                {
                    this.Id = n;
                }
            }
            if (items.Length > 1) { this.Name = items[1]; }
            if (items.Length > 2)
            {
                int n = 0;
                int.TryParse(items[2], out n);
                this.ViewMark1 = Convert.ToBoolean(n);
            }
            if (items.Length > 3)
            {
                int n = 0;
                int.TryParse(items[3], out n);
                this.ViewMark2 = Convert.ToBoolean(n);
            }
            if (items.Length > 4)
            {
                int n = 0;
                if (int.TryParse(items[4], out n))
                {
                    this.LaboratoriesMark = n;
                }
            }
            if (items.Length > 5)
            {
                int n = 0;
                int.TryParse(items[5], out n);
                this.TimelyLaboratories = Convert.ToBoolean(n);
            }
            if (items.Length > 6)
            {
                int n = 0;
                if (int.TryParse(items[6], out n))
                {
                    this.CourseWorkBall = n;
                }
            }
            if (items.Length > 7)
            {
                int n = 0;
                if (int.TryParse(items[7], out n))
                {
                    this.CourseWorkMark = (Marks)n;
                }
            }
            if (items.Length > 8)
            {
                if (items[8].Length > 0)
                {
                    int n = 0;
                    if (int.TryParse(items[8], out n))
                    {
                        this.AutoExamMark = (Marks)n;
                    }
                }
                else
                {
                    this.AutoExamMark = Marks.None;
                }
            }
            if (items.Length > 9)
            {
                int n = 0;
                int.TryParse(items[9], out n);
                this.Status = (Statuses)n;
            }
            if (items.Length > 10)
            {
                int n = 0;
                int.TryParse(items[10], out n);
                this.AllLaboratoriesPassed = Convert.ToBoolean(n);
            }
            if (items.Length > 11)
            {
                if (items[11].Length > 0)
                {
                    int n = 0;
                    if (int.TryParse(items[11], out n))
                    {
                        this.ExamMark = (Marks)n;
                    }
                }
                else
                {
                    this.ExamMark = Marks.None;
                }
            }
            if (items.Length > 12) { this._photoString = items[12]; }
            if (items.Length > 13) 
            {
                for (int i = 13; i < items.Length; ++i)
                {
                    this.Exercise += items[i] + DataFile.Delimiter;
                }
                this.Exercise = this.Exercise.Substring(0, this.Exercise.Length - 1);
            }
        }

        /// <summary>
        /// Преобразует объект в строковое представление для записи в файл
        /// </summary>
        /// <returns></returns>
        public string ToFileLine()
            => string.Format
            (
                "{0}{1}{2}{1}{3}{1}{4}{1}{5}{1}{6}{1}{7}{1}{8}{1}{9}{1}{10}{1}{11}{1}{12}{1}{13}{1}{14}",
                this.Id,
                DataFile.Delimiter,
                this.Name,
                Convert.ToInt32(this.ViewMark1),
                Convert.ToInt32(this.ViewMark2),
                this.LaboratoriesMark,
                Convert.ToInt32(this.TimelyLaboratories),
                this.CourseWorkBall,
                (int)this.CourseWorkMark,
                this.AutoExamMark == Marks.None ? "" : ((int)this.AutoExamMark).ToString(),
                (int)this.Status,
                Convert.ToInt32(this.AllLaboratoriesPassed),
                this.ExamMark == Marks.None ? "" : ((int)this.ExamMark).ToString(),
                this._photoString ?? "",
                this.Exercise
            );

        /// <summary>
        /// Сохраняет текущие изменения в студенте
        /// </summary>
        public void Save() => DataFile.SaveStudent(this);

        /// <summary>
        /// Удаляет студента из списка
        /// </summary>
        public void Delete()
        {
            if (this.IsReal)
            {
                DataFile.DeleteStudent(this);
                this.Id = -1;
            }
        }

        public override string ToString() => this.Name;
    }
}
