using System;
using System.Collections.Generic;
using System.Linq;
using DBUtil;

namespace Models
{
    /// <summary>
    /// ������
    /// </summary>
    public partial class BS_ORDER
    {
        /// <summary>
        /// ������ϸ����
        /// </summary>
        public List<BS_ORDER_DETAIL> DetailList { get; set; }

        /// <summary>
        /// �µ��û�����
        /// </summary>
        public string OrderUserRealName { get; set; }
    }
}
