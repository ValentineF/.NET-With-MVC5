using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.SS.Util;
using App.Models.Sys;
using System.Collections;

namespace App.BLL.Core
{
    public abstract class BaseNPOIParameter
    {
        /// <summary>
        /// 列名，表名所占的行数
        /// </summary>
        public int RowNumberOfAttributes;

        /// <summary>
        /// 页名
        /// </summary>
        public List<string> SheetName;

        /// <summary>
        /// 每页的行数(从数据库记录数获取的)
        /// </summary>
        public List<int> RowNumber;

        /// <summary>
        /// 列数（固定，设计表结构的时候给出）
        /// </summary>
        public int ColumnNumber;

        /// <summary>
        /// 表格名(固定，设计表结构的时候给出)
        /// </summary>
        public string Head;

        /// <summary>
        /// 单行合并单元格的范围
        /// </summary>
        public List<CellRangeAddress> MergeCellAddress;

        /// <summary>
        /// 列名
        /// </summary>
        public List<string> ColumnName;

        /// <summary>
        /// 设定页名
        /// </summary>
        protected abstract void SetSheetName();

        /// <summary>
        /// 设定每页的行数
        /// </summary>
        protected abstract void SetRowNumber();

        /// <summary>
        /// 设定合并单元格
        /// </summary>
        protected abstract void SetMergeCellAddress();
    }
}

