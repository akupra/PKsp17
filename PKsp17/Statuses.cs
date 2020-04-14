using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PKsp17
{
    /// <summary>
    /// Статусы
    /// </summary>
    public enum Statuses
    {
        [Description("Должник")]
        Debetor = 0,

        [Description("Недопущен")]
        NotAllowed = 1,

        [Description("Допущен")]
        Allowed = 2,

        [Description("")]
        None = -1,
    }

    public static class StatusesExtended
    {
        /// <summary>
        /// Заполнит комбобокс статусами студентов
        /// </summary>
        /// <param name="comboBox">Заполняемый комбобокс</param>
        /// <param name="withNoneValue">Показывает, следует ли в комбобокс добавить зачение Statuses.None</param>
        public static void IntoComboBox(ComboBox comboBox, bool withNoneValue)
        {
            Statuses[] statuses = (Statuses[])Enum.GetValues(typeof(Statuses));
            DataTable dt = new DataTable();
            dt.Columns.Add("text", typeof(string));
            dt.Columns.Add("value", typeof(Statuses));
            foreach (var status in statuses)
            {
                if (status != Statuses.None || withNoneValue)
                {
                    dt.Rows.Add(status.GetEnumDescription(), status);
                }
            }
            comboBox.DataSource = dt;
            comboBox.DisplayMember = "text";
            comboBox.ValueMember = "value";
        }
    }
}
