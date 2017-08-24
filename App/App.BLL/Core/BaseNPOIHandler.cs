using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;
using System.IO;

namespace App.BLL.Core
{/*
    /// <summary>
    /// 基类只要填写相应的Parm类里的参数即可使用
    /// </summary>
    public abstract class BaseNPOIHandler
    {
        public NPOIParameter parm;// 参数类
        public enum FontType { Head, Title, Ordinary }
        protected int sheetNumber;// 页数
        public BaseNPOIHandler(NPOIParameter parm)
        {
            this.parm = parm;
            sheetNumber = parm.SheetName.Count;
        }

        /// <summary>
        ///  创建空的Excel表,并创建Sheet
        /// </summary>
        /// <param name="sheet名"></param>
        protected XSSFWorkbook CreateEmptyExcelFile()
        {
            XSSFWorkbook book = new XSSFWorkbook();
            for (int i = 0; i < sheetNumber; i++)
                book.CreateSheet(parm.SheetName[i]);
            return book;
        }

        /// <summary>
        /// 创建所有单元格
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public void CreateRowsAndCols(XSSFWorkbook book)
        {
            for (int i = 0; i < sheetNumber; i++)
            {
                ISheet sheet = book.GetSheetAt(i);
                for (int p = 0; p < parm.RowNumber[i]; p++)
                {
                    sheet.CreateRow(p);
                    for (int q = 0; q < parm.ColumnNumber; q++)
                        sheet.GetRow(p).CreateCell(q);
                }
            }
            //return book;
        }

        /// <summary>
        /// 合并单元格....需要加参数
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public void MergeTheCell(XSSFWorkbook book)
        {
            int RowsListCount = 0;
            if (parm.MergeCellAddress != null)
                RowsListCount = parm.MergeCellAddress.Count;
            //开始合并
            for (int i = 0; i < sheetNumber; i++)
            {
                ISheet sheet = book.GetSheetAt(i);
                for (int j = 0; j < RowsListCount; j++)
                {
                    sheet.AddMergedRegion(parm.MergeCellAddress[j]);
                }
            }
        }

        /// <summary>
        /// 设置单元格样式
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public virtual ICellStyle GetCellStyle(XSSFWorkbook book, FontType fontType)
        {
            //需要选择字体类型
            //FontType fontType = 0;
            ICellStyle cellStyle = book.CreateCellStyle();
            IFont font = book.CreateFont();
            //外框线：四边，默认黑
            cellStyle.BorderBottom = BorderStyle.Thin;
            cellStyle.BorderLeft = BorderStyle.Thin;
            cellStyle.BorderRight = BorderStyle.Thin;
            cellStyle.BorderTop = BorderStyle.Thin;
            //水平居中对齐,自动换行
            cellStyle.Alignment = HorizontalAlignment.Center;
            cellStyle.VerticalAlignment = VerticalAlignment.Center;
            cellStyle.WrapText = true;
            //字体
            switch (fontType)
            {
                //表名:宋体，加粗，18
                case FontType.Head:
                    font.FontHeightInPoints = 18;
                    font.FontName = "宋体";
                    font.IsBold = true;
                    break;
                //列名：宋体，加粗，11
                case FontType.Title:
                    font.FontHeightInPoints = 11;
                    font.FontName = "宋体";
                    font.IsBold = true;
                    break;
                //内容：宋体，11
                case FontType.Ordinary:
                    font.FontHeightInPoints = 11;
                    font.FontName = "宋体";
                    break;
            }
            cellStyle.SetFont(font);
            return cellStyle;
        }

        /// <summary>
        /// 写出到磁盘
        /// </summary>
        /// <param name="book"></param>
        public void WriteToFile(XSSFWorkbook book)
        {
            FileStream file = new FileStream(@"D:\hhhh.xlsx", FileMode.Create);
            book.Write(file);
            file.Close();
        }

        /// <summary>
        /// 应用单元格样式（若要修改样式，请重写CellStyle方法）
        /// </summary>
        /// <param name="book"></param>
        protected abstract void SetCell(XSSFWorkbook book);
        /// <summary>
        /// 设置列名和表名
        /// </summary>
        /// <param name="book"></param>
        protected abstract void SetColumnNameAndHead(XSSFWorkbook book);
        /// <summary>
        /// 向单元格中填充值
        /// </summary>
        /// <param name="book"></param>
        protected abstract void SetValueToCell(XSSFWorkbook book);

    }
    */
}
