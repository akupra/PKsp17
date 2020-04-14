using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKsp17
{
    /// <summary>
    /// Работа с источником данных
    /// </summary>
    public static class DataFile
    {
        private const string Path = "students.csv";
        public const char Delimiter = ';';

        /// <summary>
        /// Полчит список всех студентов
        /// </summary>
        /// <returns></returns>
        public static BindingList<Student> GetAllStudents()
        {
            var res = new BindingList<Student>();
            if (File.Exists(Path))
            {
                var lines = File.ReadAllLines(Path);
                foreach(var line in lines)
                {
                    res.Add(new Student(line));
                }
            }
            return res;
        }

        /// <summary>
        /// Полчит максимальный существующий Id
        /// </summary>
        /// <returns></returns>
        public static int GetMaxId()
        {
            int res = -1;
            if (File.Exists(Path))
            {
                var lines = File.ReadAllLines(Path);
                foreach (var line in lines)
                {
                    int n;
                    if (int.TryParse(line.Split(Delimiter)[0], out n))
                    {
                        if (n > res) { res = n; }
                    }
                }
            }
            return res;
        }

        /// <summary>
        /// Сохранит одного студента в источник данных
        /// </summary>
        /// <param name="student">Студент</param>
        public static void SaveStudent(Student student)
        {
            if (student != null)
            {
                var lines = File.Exists(Path) ? File.ReadAllLines(Path).ToList() : new List<string>();
                if (!student.IsReal)
                {
                    student.Id = DataFile.GetMaxId() + 1;
                    lines.Add(student.ToFileLine());
                }
                else
                {
                    for (int i = 0; i < lines.Count; ++i)
                    {
                        string id = lines[i].Split(Delimiter)[0];
                        if (id == student.Id.ToString())
                        {
                            lines[i] = student.ToFileLine();
                            break;
                        }
                    }
                }
                File.WriteAllLines(Path, lines.ToArray());
            }
        }

        /// <summary>
        /// Удалит студента из источника данных
        /// </summary>
        /// <param name="student">Студент</param>
        public static void DeleteStudent(Student student)
        {
            if ((student?.IsReal ?? false) && File.Exists(Path))
            {
                var lines =  File.ReadAllLines(Path).ToList();
                for (int i = 0; i < lines.Count; ++i)
                {
                    string id = lines[i].Split(Delimiter)[0];
                    if (id == student.Id.ToString())
                    {
                        lines.RemoveAt(i);
                        break;
                    }
                }
                File.WriteAllLines(Path, lines.ToArray());
            }
        }
    }
}
