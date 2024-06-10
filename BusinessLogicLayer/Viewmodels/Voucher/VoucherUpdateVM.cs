﻿using static DataAccessLayer.Entity.Voucher;

namespace BusinessLogicLayer.Viewmodels.Voucher
{
    public class VoucherUpdateVM
    {
        public string? ModifiedBy { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Quantity { get; set; }
        public Types Type { get; set; }
        public int MinimumAmount { get; set; }
        public int ReducedValue { get; set; }
        public bool IsActive { get; set; }
        public List<string> SelectedUser { get; set; } = new List<string>();
        public int Status { get; set; }
    }
}
