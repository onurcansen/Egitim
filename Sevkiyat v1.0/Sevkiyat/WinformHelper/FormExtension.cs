using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.Windows.Forms
{
    public static class FormExtension
    {
        public static void MdiChildShow<TForm>(this Form form)
            where TForm : Form, new()
        {
            if (!form.IsMdiContainer)
            {
                throw new Exception("Bu form MdiContainer durumunda olmadığından bu işlem yapılamaz.");
            }
            TForm frm = new TForm();
            frm.MdiParent = form;
            frm.Show();
        }
        public static void MdiBroShow<TForm>(this Form form)
            where TForm : Form, new()
        {
            if (form.MdiParent == null)
            {
                throw new Exception("Bu formun MdiParent ögesi bulunmadığından bu işlem yapılamaz.");
            }
            TForm frm = new TForm();
            frm.MdiParent = form.MdiParent;
            frm.Show();
        }
        public static void EnumLoad<TEnum>(this ListControl control)
        {
            if (!typeof(TEnum).IsEnum)
            {
                throw new Exception("Bu metot sadece enum tipi için kullanılabilir.");
            }

            var enums = ((TEnum[])Enum.GetValues(typeof(TEnum))) // bu satırdaki kod enum üzerindeki tüm değerleri dizi olarak verir.
                .Select(e => new { Value = Convert.ToInt32(e), Name = e.ToString() }) //burada ilgili dizi elemanlarını listeleme öğelerinde görünmesi için value ve text(display) formatına çekiyoruz.
                .ToList();

            control.DataSource = enums;
            control.DisplayMember = "Name";
            control.ValueMember = "Value";
        }
        public static void Load<T>(this ListControl control, DbContext db, string displayMember, string valueMember, Expression<Func<T, bool>> filter = null) where T : class
        { 
            control.DataSource = null;
            control.DisplayMember = displayMember;
            control.ValueMember = valueMember;

            if (filter != null)
            {
                control.DataSource = db.Set<T>().Where(filter).ToList();
            }
            else
            {
                control.DataSource = db.Set<T>().ToList();
            }
        }
    }
}
