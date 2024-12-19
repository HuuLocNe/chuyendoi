using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuyenDoi
{
    public class ChuyenDoi
    {
        public List<GrUnit> DsLoaiDv { get; set; } // Danh sách nhóm đơn vị
        public ChuyenDoi()
        {
            DsLoaiDv = new List<GrUnit>();
        }
        public void AddLoaiDonVi(GrUnit v)
        {
            DsLoaiDv.Add(v);
        }
        public double Convertc_CD(double value, string from, string to, string groupName)
        {
            var group = DsLoaiDv.FirstOrDefault(g => g.NameGr == groupName);
            if (group == null)
                throw new ArgumentException($"Không tìm thấy nhóm đơn vị với tên '{groupName}'.");

            var fromUnit = group.UnitList.FirstOrDefault(u => u.Symbol == from);
            var toUnit = group.UnitList.FirstOrDefault(u => u.Symbol == to);

            if (fromUnit == null)
                throw new ArgumentException($"Đơn vị nguồn '{from}' không tồn tại trong nhóm {groupName}.");
            if (toUnit == null)
                throw new ArgumentException($"Đơn vị đích '{to}' không tồn tại trong nhóm {groupName}.");

            return group.Convert(from, to, value);
        }
    }
}


