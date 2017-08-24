using App.Models.Sys;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Collections.Generic;
using System.Linq;

namespace App.BLL.Core
{/*
    public class NPOIHandler:BaseNPOIHandler
    {
        /// <summary>
        /// 调用NPOI参数表
        /// </summary>
        /// <param name="parm"></param>
        public NPOIHandler(NPOIParameter parm) : base(parm)
        {
            XSSFWorkbook book = CreateEmptyExcelFile();
            CreateRowsAndCols(book);
            MergeTheCell(book);
            SetCell(book);
            SetColumnNameAndHead(book);
            SetValueToCell(book);
            WriteToFile(book);
        }

        /// <summary>
        /// 应用单元格样式（若要修改样式，请重写CellStyle方法）
        /// </summary>
        /// <param name="book"></param>
        protected override void SetCell(XSSFWorkbook book)
        {
            //获取单元格样式
            ICellStyle head = GetCellStyle(book, FontType.Head);
            ICellStyle title = GetCellStyle(book, FontType.Title);
            ICellStyle ordinary = GetCellStyle(book, FontType.Ordinary);

            for (int i = 0; i < sheetNumber; i++)
            {
                ISheet sheet = book.GetSheetAt(i);
                sheet.GetRow(0).GetCell(0).CellStyle = head;
                for (int p = 1; p < parm.RowNumber[i]; p++)
                {
                    for (int q = 0; q < parm.ColumnNumber; q++)
                    {
                        if (p == 1 || p == 2)
                        {   //列名
                            sheet.GetRow(p).GetCell(q).CellStyle = title;
                            continue;
                        }
                        sheet.GetRow(p).GetCell(q).CellStyle = ordinary;
                    }
                }
            }
        }

        /// <summary>
        /// 设置列名和表名
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        protected override void SetColumnNameAndHead(XSSFWorkbook book)
        {
            int columnNameCount = parm.ColumnName.Count;
            for (int i = 0; i < sheetNumber; i++)
            {
                ISheet sheet = book.GetSheetAt(i);
                //设置表名,行高
                sheet.GetRow(0).GetCell(0).SetCellValue(parm.Head);
                sheet.GetRow(0).HeightInPoints = 58.5f;
                //设置父列合并单元格的列名
                sheet.GetRow(1).GetCell(0).SetCellValue("商学院");
                sheet.GetRow(1).GetCell(1).SetCellValue("专业：");
                sheet.GetRow(1).GetCell(4).SetCellValue("学号");
                sheet.GetRow(1).GetCell(8).SetCellValue("姓名");
                //子列列名
                for (int j = 0; j < columnNameCount; j++)
                    sheet.GetRow(2).GetCell(j).SetCellValue(parm.ColumnName[j]);
            }
            //return book;
        }

        /// <summary>
        /// 向单元格中填充值
        /// </summary>
        /// <param name="book"></param>
        protected override void SetValueToCell(XSSFWorkbook book)
        {
            List<StudentModel> listStudent = parm.ListOfStudent;
            for (int i = 0; i < sheetNumber; i++)
            {
                ISheet sheet = book.GetSheetAt(i);
                //标题列
                sheet.GetRow(1).GetCell(2).SetCellValue(listStudent[i].Major);
                sheet.GetRow(1).GetCell(5).SetCellValue(listStudent[i].StudentId);
                sheet.GetRow(1).GetCell(9).SetCellValue(listStudent[i].StudentName);
                //表值
                int recordsNumber = listStudent[i].Grade.Count;
                for (int j = 0; j < recordsNumber; j++)
                {
                    IRow row = sheet.GetRow(j + 3);
                    row.GetCell(0).SetCellValue((int)listStudent[i].Grade[j].Semester);
                    row.GetCell(1).SetCellValue(listStudent[i].Grade[j].Course);
                    row.GetCell(2).SetCellValue(listStudent[i].Grade[j].CourseType);
                    row.GetCell(3).SetCellValue(listStudent[i].Grade[j].IsDegree);
                    row.GetCell(4).SetCellValue((int)listStudent[i].Grade[j].StudyTime);
                    row.GetCell(5).SetCellValue(listStudent[i].Grade[j].TestType);
                    row.GetCell(6).SetCellValue((int)listStudent[i].Grade[j].Credit);
                    row.GetCell(7).SetCellValue((int)listStudent[i].Grade[j].Score);
                    row.GetCell(8).SetCellValue(listStudent[i].Grade[j].TeacherName);
                    row.GetCell(9).SetCellValue(listStudent[i].Grade[j].Remark1);
                    row.GetCell(10).SetCellValue(listStudent[i].Grade[j].Remark2);
                }
            }
        }
        
    }*/
}
