﻿namespace AuthService.Models
{
    public class UserHoldMapper: BaseEntity
    {
        public int? UserId { get; set; }
        public User? User { get; set; }
        public int? HoldId { get; set; }
        public Hold? Hold { get; set; }
        public int? StatusId { get; set; }
        public Status? Status { get; set; }
    }
}
