using System;
using System.Collections.Generic;

namespace API.DTOs
{
    public class MemberDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; }
        public ICollection<AccountDto> Accounts { get; set; }
    }
}