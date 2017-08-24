using App.Models.Sys;
using NPOI.SS.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.BLL.Core
{
    /*
    /// <summary>
    /// 需要另外设定格式的时候请重写SetSheetName，SetRowNumber，SetMergeCellAddress方法
    /// </summary>
    public class NPOIParameter : BaseNPOIParameter
    {
        /// <summary>
        /// 参数表
        /// </summary>
        /// <param name="学生表"></param>
        /// <param name="列数"></param>
        /// <param name="列名"></param>
        /// <param name="表名"></param>
        /// <param name="列名，表名所占的行数"></param>
        public NPOIParameter(List<StudentModel> listOfStudent, int columnNumber, List<string> columnName, string head, int rowNumberOfAttributes)
        {
            ListOfStudent = listOfStudent;
            ColumnNumber = columnNumber;
            ColumnName = columnName;
            RowNumberOfAttributes = rowNumberOfAttributes;
            Head = head;
            SetSheetName();
            SetRowNumber();
            SetMergeCellAddress();
        }

        /// <summary>
        /// 存放所有数据的List
        /// </summary>
        public List<StudentModel> ListOfStudent;

        /// <summary>
        /// 设定页名
        /// </summary>
        protected override void SetSheetName()
        {
            SheetName = (from student in ListOfStudent
                         orderby student.StudentName
                         select student.StudentName).Distinct<string>().ToList<string>();
        }

        /// <summary>
        /// 设定每页的行数
        /// </summary>
        protected override void SetRowNumber()
        {
            List<StudentGradeModel> list = new List<StudentGradeModel>();
            for (int i = 0; i < ListOfStudent.Count; i++)
            {
                list.AddRange(ListOfStudent[i].Grade);
            }
            RowNumber = (from student in list
                         group student by student.StudentId into idCount
                         select idCount.Count() + RowNumberOfAttributes).ToList<int>();
        }

        /// <summary>
        /// 设定合并单元格
        /// </summary>
        protected override void SetMergeCellAddress()
        {
            MergeCellAddress = new List<CellRangeAddress>(new CellRangeAddress[]{
                                                        new CellRangeAddress(0,0,0,10),
                                                        new CellRangeAddress(1,1,2,3),
                                                        new CellRangeAddress(1,1,5,7),
                                                        new CellRangeAddress(1,1,9,10)});
        }
    }*/
}

